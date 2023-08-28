namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Messages;

    public interface IContactService
    {
        Task CreateAsync(MessageInputModel model);

        Task<IEnumerable<MessageAllViewModel>> GetAll();
    }
}
