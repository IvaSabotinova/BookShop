namespace BooksShop.Core.ViewModels.Books.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum PriceRange
    {
        [Display(Name = Infrastructure.Data.Constants.UnderFifty)]
        UnderFifty,
        [Display(Name = Infrastructure.Data.Constants.FiftyToOneHundred)]
        FiftyToOneHundred,
        [Display(Name = Infrastructure.Data.Constants.AboveOneHundred)]
        AboveOneHundred,
    }
}
