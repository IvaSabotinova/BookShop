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

        public async Task<IEnumerable<MessageAllViewModel>> GetAll() =>
            await this.messageRepo.AllAsNoTracking()
            .OrderByDescending(x => x.CreatedOn)
            .ProjectTo<MessageAllViewModel>(this.mapper.ConfigurationProvider)
            .ToListAsync();
    }
}
