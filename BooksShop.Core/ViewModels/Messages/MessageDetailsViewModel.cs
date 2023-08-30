namespace BooksShop.Core.ViewModels.Messages
{
    public class MessageDetailsViewModel : MessageInListViewModel
    {
        public string Content { get; set; }

        public int CurrentPageNumber { get; set; }
    }
}
