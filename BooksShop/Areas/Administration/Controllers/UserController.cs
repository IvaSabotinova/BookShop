namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels.Users;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class UserController : AdministrationController
     {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserService userService;

        public UserController(
            UserManager<ApplicationUser> userManager,
            IUserService userService)
        {
            this.userManager = userManager;
            this.userService = userService;
        }

        [HttpGet]

        public async Task<IActionResult> All(
            int page = 1,
            int itemsPerPage = 7,
            string? search = null)
        {
            if (page <= 0)
            {
                return this.NotFound();
            }

            UsersListViewModel model = await this.userService.GetAll(page, itemsPerPage, search);

            foreach (UserInListViewModel user in model.Users)
            {
                ApplicationUser currentUser = await this.userManager.FindByIdAsync(user.Id);
                string? role = this.userManager.GetRolesAsync(currentUser).Result.FirstOrDefault();

                if (role != null)
                {
                    user.Role = role;
                }
            }

            return this.View(model);
        }
     }
}
