namespace BooksShop.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;

    public class ContactController : Controller
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            MessageInputModel model = new MessageInputModel();
            return this.View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(MessageInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.contactService.CreateAsync(model);
                this.TempData[Constants.Message] = SuccessMessage;
                return this.RedirectToAction("Index", "Home", new { area = string.Empty });
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ErrorMessage);

                this.TempData[Constants.Message] = ex.Message;
                return this.View(model);
            }
        }

    }
}
