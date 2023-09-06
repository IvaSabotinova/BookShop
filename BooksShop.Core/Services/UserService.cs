namespace BooksShop.Core.Services
{
    using AutoMapper;
    using BooksShop.Core.ViewModels.Users;
    using BooksShop.Infrastructure.Data;

    public class UserService : IUserService
    {
        private readonly IMapper mapper;

        public UserService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<UserViewModel> GetUserProfile(ApplicationUser user)
        {
            UserViewModel userViewModel = this.mapper.Map<UserViewModel>(user);
            return userViewModel;
        }
    }
}
