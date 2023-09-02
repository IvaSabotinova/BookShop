namespace BooksShop.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;

    public class BookService : IBookService
    {
        private readonly IRepository<Book> booksRepo;
        private readonly IMapper mapper;

        public BookService(
            IRepository<Book> booksRepo,
            IMapper mapper)
        {
            this.booksRepo = booksRepo;
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

        public async Task<BooksListViewModel> GetAll(int page, int itemsPerPage, string? search)
        {
            IQueryable<Book> booksQuery = this.booksRepo.AllAsNoTracking().AsQueryable();

            if (string.IsNullOrEmpty(search) == false)
            {
                string searchQuery = $"%{search.Trim().ToLower()}%";
                booksQuery = booksQuery.Where(x => EF.Functions.Like(x.Title.ToLower(), searchQuery)
                || EF.Functions.Like(x.Author.ToLower(), searchQuery));
            }

            List<BookInListViewModel> books = await booksQuery
                .OrderByDescending(x => x.Id)
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
            };
        }
    }
}
