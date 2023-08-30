namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels.Messages;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc;

    public class ContactController : AdministrationController
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]

        public async Task<IActionResult> Details(int id, int page = 1)
        {
            Message message = await this.contactService.GetById(id);

            if (message == null)
            {
                return this.NotFound();
            }

            MessageDetailsViewModel model = await this.contactService.DetailsById(id);
            model.CurrentPageNumber = page;

            return this.View(model);
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

        public async Task<IActionResult> Delete(int id, int page = 1)
        {
            Message message = await this.contactService.GetById(id);

            if (message == null)
            {
                return this.NotFound();
            }

            int messagesIndex = await this.contactService.GetIndex(id);
            page = (messagesIndex > 9 && messagesIndex % 10 == 0) ? page - 1 : page;

            await this.contactService.DeleteAsync(message);

            return this.RedirectToAction(nameof(this.All), new { id = page });
        }
    }
}
