namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels;

    public interface IContactService
    {
        Task CreateAsync(MessageInputModel model);
    }
}
