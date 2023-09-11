namespace BooksShop.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Users;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;

    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly IRepository<ApplicationUser> userRepo;

        public UserService(
            IMapper mapper,
            IRepository<ApplicationUser> userRepo)
        {
            this.mapper = mapper;
            this.userRepo = userRepo;
        }

        public async Task<UserEditModel> GetUserProfile(string userId)
        {
            return await this.userRepo.All()
                .Where(x => x.Id == userId)
                .ProjectTo<UserEditModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task UpdateUserAsync(ApplicationUser user, UserEditModel model)
        {
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;
            user.Address = model.Address;
        }

        public async Task<int> GetUsersCount(string? search = null)
        {
            IQueryable<ApplicationUser> usersQuery = this.userRepo.AllAsNoTracking()
               .AsQueryable();
            if (string.IsNullOrEmpty(search) == false)
            {
                search = $"%{search.Trim().ToLower()}%";
                usersQuery = usersQuery.Where(x => EF.Functions.Like(x.FirstName.ToLower() + " " + x.LastName.ToLower(), search)
                || EF.Functions.Like(x.PhoneNumber, search));
            }

            return await usersQuery.CountAsync();
        }

        public async Task<UsersListViewModel> GetAll(
            int page,
            int itemsPerPage = 7,
            string? search = null)
        {
            IQueryable<ApplicationUser> usersQuery = this.userRepo.AllAsNoTracking()
                .OrderBy(x => x.FirstName)
                .AsQueryable();

            if (string.IsNullOrEmpty(search) == false)
            {
                string searchQuery = $"%{search.Trim().ToLower()}%";
                usersQuery = usersQuery.Where(x => EF.Functions.Like(x.FirstName.ToLower() + " " + x.LastName.ToLower(), searchQuery)
                || EF.Functions.Like(x.PhoneNumber, searchQuery));
            }

            List<UserInListViewModel> users = await usersQuery
                .ProjectTo<UserInListViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();

            return new UsersListViewModel()
            {
                CurrentPageNumber = page,
                ItemsPerPage = itemsPerPage,
                AllItemsCount = await this.GetUsersCount(search),
                Users = users,
                Search = search,
            };
        }
    }
}
