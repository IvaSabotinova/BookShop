namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels.Messages;
    using Microsoft.AspNetCore.Mvc;

    public class ContactController : AdministrationController
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<MessageAllViewModel> model = await this.contactService.GetAll();
            return this.View(model);
        }
    }
}
