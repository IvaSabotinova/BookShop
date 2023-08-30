namespace BooksShop.Core.Services
{
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.ViewModels.Messages;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;

    public class ContactService : IContactService
    {
        private readonly IRepository<Message> messageRepo;
        private readonly IMapper mapper;

        public ContactService(
            IRepository<Message> messageRepo,
            IMapper mapper)
        {
            this.messageRepo = messageRepo;
            this.mapper = mapper;
        }

        public async Task CreateAsync(MessageInputModel model)
        {
            Message newMessage = this.mapper.Map<Message>(model);

            await this.messageRepo.AddAsync(newMessage);
            await this.messageRepo.SaveChangesAsync();
        }

        public async Task<int> GetMessagesCount()
        {
            return await this.messageRepo.AllAsNoTracking().CountAsync();
        }

        public async Task<MessagesListViewModel> GetAll(int page, int itemsPerPage)
        {
            List<MessageInListViewModel> messages = await this.messageRepo.AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .ProjectTo<MessageInListViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();

            return new MessagesListViewModel()
            {
                ItemsPerPage = itemsPerPage,
                AllItemsCount = await this.GetMessagesCount(),
                CurrentPageNumber = page,
                Messages = messages,
            };
        }

        public async Task<Message> GetById(int id)
            => await this.messageRepo.All()
            .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<MessageDetailsViewModel> DetailsById(int id)
        => await this.messageRepo.AllAsNoTracking()
                .Where(x => x.Id == id)
                .ProjectTo<MessageDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();

        public async Task<int> GetIndex(int id)
        {
            List<int> ids = await this.messageRepo.AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .Select(x => x.Id)
                .ToListAsync();
            return ids.FindIndex(x => x == id);
        }

        public async Task DeleteAsync(Message message)
        {
            this.messageRepo.Delete(message);
            await this.messageRepo.SaveChangesAsync();
        }
    }
}
