namespace BooksShop.Core.Services
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

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

        public async Task CreateBook(BookInputModel model)
        {
            Book newBook = this.mapper.Map<Book>(model);

            // TODO - Save image
            await this.booksRepo.AddAsync(newBook);
            await this.booksRepo.SaveChangesAsync();
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
    }
}
