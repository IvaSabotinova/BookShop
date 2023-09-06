namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Users;
    using BooksShop.Infrastructure.Data;

    public interface IUserService
    {
        Task<UserViewModel> GetUserProfile(ApplicationUser user);
    }
}
