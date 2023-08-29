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

        public async Task<IActionResult> All(int id = 1, int itemsPerPage = 10)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            MessagesListViewModel model = await this.contactService.GetAll(id, itemsPerPage);
            return this.View(model);
        }
    }
}
