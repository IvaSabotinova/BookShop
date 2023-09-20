namespace BooksShop.Core.MappingConfiguration
{
    using AutoMapper;
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Core.ViewModels.Messages;
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Core.ViewModels.ShoppingCart;
    using BooksShop.Core.ViewModels.Users;
    using BooksShop.Infrastructure.Data;
    using BooksShop.Infrastructure.Data.Enums;

    public class BooksShopProfile : Profile
    {
        public BooksShopProfile()
        {
            // Messages
            this.CreateMap<MessageInputModel, Message>();
            this.CreateMap<Message, MessageInListViewModel>()
                .ForMember(x => x.FullName, mo => mo
                .MapFrom(s => s.FirstName + " " + s.LastName));
            this.CreateMap<Message, MessageDetailsViewModel>()
                .ForMember(x => x.FullName, mo => mo
                .MapFrom(s => s.FirstName + " " + s.LastName));

            // Books
            this.CreateMap<Book, BookInListViewModel>();
            this.CreateMap<BookInputModel, Book>()
              .ForMember(x => x.ImageUrl, opt => opt
              .MapFrom(src => "/images/books/" + Guid.NewGuid().ToString() + Path.GetExtension(src.Image.FileName)));
            this.CreateMap<Book, BookEditModel>();
            this.CreateMap<BookEditModel, Book>();
            this.CreateMap<Book, BookViewModel>();

            // Shopping Cart
            this.CreateMap<Book, BookDetailsViewModel>();
            this.CreateMap<Book, BookInOrderViewModel>()
                .ForMember(x => x.Quantity, src => src.Ignore())
                .ForMember(x => x.TotalPrice, src => src.Ignore());
            this.CreateMap<OrderModel, Order>()
                .ForMember(x => x.OrderDate, mo => mo.MapFrom(src => DateTime.Now))
                .ForMember(x => x.DeliveryAddress, mo => mo
                .MapFrom(src => src.DeliveryAddress ?? string.Empty))
                .ForMember(x => x.PaymentMethod, mo => mo
                .MapFrom(src => src.PaymentMethod ?? PaymentMethod.CreditCard))
                .ForMember(x => x.PaymentStatus, mo => mo
                .MapFrom(src => PaymentStatus.Pending))
                .ForMember(x => x.OrderStatus, mo => mo
                .MapFrom(src => OrderStatus.Created));

            // Orders
            this.CreateMap<BookOrder, BookOrderViewModel>();
            this.CreateMap<Order, OrdersInListViewModel>();
            this.CreateMap<BookOrder, BookInOrderDetailsViewModel>();
            this.CreateMap<Order, OrderDetailsViewModel>()
                .ForMember(x => x.ApplicationUserFullName, mo => mo
                .MapFrom(src => src.ApplicationUser.FirstName + " " +
                              src.ApplicationUser.LastName));
            this.CreateMap<Order, UserOrderDetailsViewModel>();

            // Users
            this.CreateMap<ApplicationUser, UserEditModel>()
                .ForMember(x => x.Role, src => src.Ignore());
            this.CreateMap<ApplicationUser, UserInListViewModel>()
                .ForMember(x => x.Name, mo =>
                mo.MapFrom(src => src.FirstName + " " + src.LastName))
                .ForMember(x => x.Role, src => src.Ignore());
        }
    }
}
