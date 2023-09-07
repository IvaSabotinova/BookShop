namespace BooksShop.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels;
    using BooksShop.Core.ViewModels.Users;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;
    using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IUserService userService;

        public UserController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IUserService userService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            ApplicationUser newUser = new ApplicationUser()
            {
                 UserName = model.UserName,
                 FirstName = model.Firstname,
                 LastName = model.Lastname,
                 Email = model.Email,
                 PhoneNumber = model.PhoneNumber,
                 Address = model.Address,
                 RegisteredOn = DateTime.Now,
            };

            IdentityResult result = await this.userManager.CreateAsync(newUser, model.Password);
            result = await this.userManager.AddToRoleAsync(newUser, ClientRoleName);

            if (result.Succeeded)
            {
                return this.RedirectToAction(nameof(this.Login));
            }

            foreach (IdentityError error in result.Errors)
            {
                this.ModelState.AddModelError(string.Empty, error.Description);
            }

            return this.View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            ApplicationUser user = await this.userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                SignInResult result = await this.signInManager.PasswordSignInAsync(
                    user, model.Password, false, false);
                if (result.Succeeded)
                {
                    return this.RedirectToAction("Index", "Home");
                }
            }

            this.ModelState.AddModelError(string.Empty, SignInErrorMessage);
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();
            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]

        public async Task<IActionResult> Profile(string id)
        {
            ApplicationUser currentUser = await this.userManager.FindByIdAsync(id);

            if (currentUser == null)
            {
                return this.NotFound();
            }

            UserEditModel model = await this.userService.GetUserProfile(id);

            string? role = this.userManager.GetRolesAsync(currentUser).Result
               .FirstOrDefault();

            if (role != null)
            {
                model.Role = role;
            }

            return this.View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Profile(UserEditModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            ApplicationUser user = await this.userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                return this.NotFound();
            }

            try
            {
                await this.userService.UpdateUserAsync(user, model);
                IdentityResult result = await this.userManager.UpdateAsync(user);
                this.TempData[Constants.Message] = UserUpdatedSuccessfully;
                return this.RedirectToAction(nameof(this.Profile));
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                this.TempData[Constants.Message] = ex.Message;
                return this.View(model);
            }
        }
    }
}
