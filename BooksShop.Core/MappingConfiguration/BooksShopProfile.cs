namespace BooksShop.Core.MappingConfiguration
{
    using AutoMapper;
    using BooksShop.Core.ViewModels.Messages;
    using BooksShop.Infrastructure.Data;

    public class BooksShopProfile : Profile
    {
        public BooksShopProfile()
        {
            this.CreateMap<MessageInputModel, Message>();
            this.CreateMap<Message, MessageInListViewModel>()
                .ForMember(x => x.FullName, mo => mo
                .MapFrom(s => s.FirstName + " " + s.LastName));
        }
    }
}
