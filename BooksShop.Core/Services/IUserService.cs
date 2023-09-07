namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Users;
    using BooksShop.Infrastructure.Data;

    public interface IUserService
    {
        Task<UserEditModel> GetUserProfile(string id);

        Task UpdateUserAsync(ApplicationUser user, UserEditModel model);

        Task<int> GetUsersCount(string? search);

        Task<UsersListViewModel> GetAll(
           int page,
           int itemsPerPage = 7,
           string? search = null);
    }
}
