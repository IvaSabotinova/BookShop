namespace BooksShop.Core.ViewModels.Messages
{
    public class MessagesListViewModel : PagingViewModel
    {
        public IEnumerable<MessageInListViewModel> Messages { get; set; }
    }
}
