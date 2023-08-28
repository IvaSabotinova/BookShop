namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;

    public class ContactService : IContactService
    {
        private readonly IRepository<Message> messageRepo;

        public ContactService(IRepository<Message> messageRepo)
        {
            this.messageRepo = messageRepo;
        }

        public async Task CreateAsync(MessageInputModel model)
        {
            Message newMessage = new Message()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                Subject = model.Subject,
                Content = model.Content,
                CreatedOn = model.CreatedOn,
            };

            await this.messageRepo.AddAsync(newMessage);
            await this.messageRepo.SaveChangesAsync();
        }
    }
}
