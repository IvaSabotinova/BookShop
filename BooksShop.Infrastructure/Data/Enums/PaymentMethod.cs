namespace BooksShop.Infrastructure.Data.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum PaymentMethod
    {
        [Display(Name = Constants.CashOnDelivery)]
        CashOnDelivery,
        [Display(Name = Constants.CreditCard)]
        CreditCard,
        Paypal
    }
}
