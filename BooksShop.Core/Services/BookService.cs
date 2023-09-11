namespace BooksShop.Core.Services
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Core.ViewModels.Books.Enums;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using static BooksShop.Infrastructure.Data.Constants;

    public class BookService : IBookService
    {
        private readonly IRepository<Book> booksRepo;
        private readonly IRepository<Category> categoryRepo;
        private readonly IMapper mapper;

        public BookService(
            IRepository<Book> booksRepo,
            IRepository<Category> categoryRepo,
            IMapper mapper)
        {
            this.booksRepo = booksRepo;
            this.categoryRepo = categoryRepo;
            this.mapper = mapper;
        }

        public async Task<int> GetBooksCount(string? search = null)
        {
            IQueryable<Book> booksQuery = this.booksRepo.AllAsNoTracking().AsQueryable();

            if (string.IsNullOrEmpty(search) == false)
            {
                search = $"%{search.Trim().ToLower()}%";
                booksQuery = booksQuery.Where(x => EF.Functions.Like(x.Title.ToLower(), search)
                || EF.Functions.Like(x.Author.ToLower(), search));
            }

            return await booksQuery.CountAsync();
        }

        public async Task<BooksListViewModel> GetAll(
            int page,
            int itemsPerPage,
            string? search,
            string? column,
            string? order)
        {
            IQueryable<Book> booksQuery = this.booksRepo.AllAsNoTracking()
                .Include(x => x.Category)
                .OrderByDescending(x => x.Id)
                .AsQueryable();

            if (string.IsNullOrEmpty(search) == false)
            {
                string searchQuery = $"%{search.Trim().ToLower()}%";
                booksQuery = booksQuery.Where(x => EF.Functions.Like(x.Title.ToLower(), searchQuery)
                || EF.Functions.Like(x.Author.ToLower(), searchQuery));
            }

            string[] validColumns = { "id", "title", "author", "num_of_pages", "price", "category", "created_on" };

            if (column != null && validColumns.Contains(column))
            {
                if (order == "asc")
                {
                    booksQuery = column switch
                    {
                        "id" => booksQuery.OrderBy(x => x.Id),
                        "title" => booksQuery.OrderBy(x => x.Title),
                        "author" => booksQuery.OrderBy(x => x.Author),
                        "num_of_pages" => booksQuery.OrderBy(x => x.NumOfPages),
                        "price" => booksQuery.OrderBy(x => x.Price),
                        "category" => booksQuery.OrderBy(x => x.Category.Name),
                        _ => booksQuery.OrderBy(x => x.CreatedOn),
                    };
                }
                else
                {
                    booksQuery = column switch
                    {
                        "id" => booksQuery.OrderByDescending(x => x.Id),
                        "title" => booksQuery.OrderByDescending(x => x.Title),
                        "author" => booksQuery.OrderByDescending(x => x.Author),
                        "num_of_pages" => booksQuery.OrderByDescending(x => x.NumOfPages),
                        "price" => booksQuery.OrderByDescending(x => x.Price),
                        "category" => booksQuery.OrderByDescending(x => x.Category.Name),
                        _ => booksQuery.OrderByDescending(x => x.CreatedOn),
                    };
                }
            }

            List<BookInListViewModel> books = await booksQuery
                .ProjectTo<BookInListViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();

            return new BooksListViewModel()
            {
                CurrentPageNumber = page,
                ItemsPerPage = itemsPerPage,
                AllItemsCount = await this.GetBooksCount(search),
                Books = books,
                Search = search,
                Column = column,
                Order = order,
            };
        }

        public async Task<IEnumerable<SelectListItem>> GetAllCategories()
        {
            return await this.categoryRepo.AllAsNoTracking()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name,
                })
                .ToListAsync();
        }

        public async Task CreateBookAsync(BookInputModel model, string webRootPath)
        {
            Book book = await this.booksRepo.AllAsNoTracking()
                .FirstOrDefaultAsync(x => x.ISBN == model.ISBN);

            if (book != null)
            {
                throw new InvalidOperationException(BookExists);
            }

            Book newBook = this.mapper.Map<Book>(model);

            // Save image to wwwroot
            string fullImageURL = webRootPath + newBook.ImageUrl;

            using FileStream fileStream = new FileStream(fullImageURL, FileMode.Create);
            await model.Image.CopyToAsync(fileStream);

            await this.booksRepo.AddAsync(newBook);
            await this.booksRepo.SaveChangesAsync();
        }

        public async Task<Book> GetBookById(int id)
            => await this.booksRepo.All()
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<BookEditModel> GetBookForEdit(int id)
        {
            return await this.booksRepo.All()
                .Where(x => x.Id == id)
                .ProjectTo<BookEditModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task EditBookAsync(BookEditModel model, string webRootPath)
        {
            Book otherBookWithSameISBN = await this.booksRepo.AllAsNoTracking()
                .Where(x => x.Id != model.Id)
                .Where(x => x.ISBN == model.ISBN)
                .FirstOrDefaultAsync();

            if (otherBookWithSameISBN != null)
            {
                throw new InvalidOperationException(ISBNExists);
            }

            Book editedBook = this.mapper.Map<Book>(model);

            if (model.ImageFile != null)
            {
                editedBook.ImageUrl = "/images/books/" + Guid.NewGuid().ToString() + Path.GetExtension(model.ImageFile.FileName);

                // Save new image to wwwroot
                string fullImageURL = webRootPath + editedBook.ImageUrl;

                using FileStream fileStream = new FileStream(fullImageURL, FileMode.Create);
                await model.ImageFile.CopyToAsync(fileStream);

                // Delete old image
                string oldImagePath = webRootPath + model.ImageUrl;

                if (File.Exists(oldImagePath))
                {
                    File.Delete(oldImagePath);
                }
            }

            this.booksRepo.Update(editedBook);
            await this.booksRepo.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id, string webRootPath)
        {
            Book book = await this.GetBookById(id);
            string bookImageUrl = webRootPath + book.ImageUrl;
            if (book != null)
            {
                this.booksRepo.Delete(book);
                await this.booksRepo.SaveChangesAsync();
                File.Delete(bookImageUrl);
            }
        }

        public async Task<IEnumerable<BookViewModel>> GetFourNewestBooks()
        => await this.booksRepo.AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .ProjectTo<BookViewModel>(this.mapper.ConfigurationProvider)
                .Take(4)
                .ToListAsync();

        public async Task<BookDetailsViewModel> GetDetailsById(int id)
        => await this.booksRepo.AllAsNoTracking()
                .Where(x => x.Id == id)
                .ProjectTo<BookDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();

        public async Task<int> AdvancedSearchBooksCount(
            string? search,
            PriceRange? priceRange,
            PageRange? pageRange,
            int? categoryId)
        {
            IQueryable<Book> books = this.booksRepo.AllAsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                search = $"%{search.Trim().ToLower()}%";
                books = books.Where(x => EF.Functions.Like(x.Title.ToLower(), search)
                || EF.Functions.Like(x.Author.ToLower(), search));
            }

            if (priceRange != null)
            {
                books = priceRange switch
                {
                    PriceRange.UnderFifty => books.Where(x => x.Price < 50),
                    PriceRange.FiftyToOneHundred => books.Where(x => x.Price >= 50 && x.Price <= 100),
                    _=> books.Where(x => x.Price > 100),
                };
            }

            if (pageRange != null)
            {
                books = pageRange switch
                {
                    PageRange.UnderOneHundred => books.Where(x => x.NumOfPages < 100),
                    PageRange.OneHundredToTwoHundredNinetyNine => books.Where(x => x.NumOfPages >= 100 && x.NumOfPages <= 299),
                    PageRange.AboveThreeHundred => books.Where(x => x.NumOfPages >= 300),
                };
            }

            if (categoryId != 0)
            {
                books = books.Where(x => x.CategoryId == categoryId);
            }

            return await books.CountAsync();
        }

        public async Task<BookAdvancedSearchAndPagingViewModel> AdvancedSearch(
            int page,
            int itemsPerPage,
            string? search,
            PriceRange? priceRange,
            PageRange? pageRange,
            int? categoryId)
        {
            IQueryable<Book> booksQuery = this.booksRepo.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                string searchQuery = $"%{search.Trim().ToLower()}%";
                booksQuery = booksQuery.Where(x => EF.Functions.Like(x.Title.ToLower(), searchQuery)
                || EF.Functions.Like(x.Author.ToLower(), searchQuery));
            }

            if (priceRange != null)
            {
                booksQuery = priceRange switch
                {
                    PriceRange.UnderFifty => booksQuery.Where(x => x.Price < 50),
                    PriceRange.FiftyToOneHundred => booksQuery.Where(x => x.Price >= 50 && x.Price <= 100),
                    _ => booksQuery.Where(x => x.Price > 100),
                };
            }

            if (pageRange != null)
            {
                booksQuery = pageRange switch
                {
                    PageRange.UnderOneHundred => booksQuery.Where(x => x.NumOfPages < 100),
                    PageRange.OneHundredToTwoHundredNinetyNine => booksQuery.Where(x => x.NumOfPages >= 100 && x.NumOfPages <= 299),
                    _ => booksQuery.Where(x => x.NumOfPages >= 300),
                };
            }

            if (categoryId != 0)
            {
                booksQuery = booksQuery.Where(x => x.CategoryId == categoryId);
            }

            List<BookViewModel> books = await booksQuery
                .ProjectTo<BookViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();

            return new BookAdvancedSearchAndPagingViewModel()
            {
                CurrentPageNumber = page,
                ItemsPerPage = itemsPerPage,
                AllItemsCount = await this.AdvancedSearchBooksCount(search, priceRange, pageRange, categoryId),
                Books = books,
                Search = search,
                PriceRange = priceRange,
                PageRange = pageRange,
                CategoryId = categoryId,
                Categories = await this.GetAllCategories(),
            };
        }
    }
}
