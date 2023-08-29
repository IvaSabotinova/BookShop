namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Messages;

    public interface IContactService
    {
        Task CreateAsync(MessageInputModel model);

        Task<MessagesListViewModel> GetAll(int page, int itemsPerPage = 10);

        Task<int> GetMessagesCount();
    }
}
