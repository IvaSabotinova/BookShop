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

        public async Task<int> GetBooksCount()
        => await this.booksRepo.AllAsNoTracking().CountAsync();

        public async Task<BooksListViewModel> GetAll(int page, int itemsPerPage)
        {
            List<BookInListViewModel> books = await this.booksRepo.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .ProjectTo<BookInListViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();

            return new BooksListViewModel()
            {
                CurrentPageNumber = page,
                ItemsPerPage = itemsPerPage,
                AllItemsCount = await this.GetBooksCount(),
                Books = books,
            };
        }
    }
}
