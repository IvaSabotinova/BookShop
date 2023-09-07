namespace BooksShop.Core.ViewModels.Users
{
     public class UsersListViewModel : PagingViewModel
     {
        public IEnumerable<UserInListViewModel> Users { get; set; }

        public string? Search { get; set; }
     }
}
