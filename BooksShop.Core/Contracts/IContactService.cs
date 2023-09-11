namespace BooksShop.Core.Contracts
{
    using BooksShop.Core.ViewModels.Messages;
    using BooksShop.Infrastructure.Data;

    public interface IContactService
    {
        Task CreateAsync(MessageInputModel model);

        Task<int> GetMessagesCount();

        Task<MessagesListViewModel> GetAll(int page, int itemsPerPage = 10);

        Task<Message> GetById(int id);

        Task<MessageDetailsViewModel> DetailsById(int id);

        Task<int> GetIndex(int id);

        Task DeleteAsync(Message message);
    }
}
