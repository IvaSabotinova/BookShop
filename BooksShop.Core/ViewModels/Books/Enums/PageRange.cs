namespace BooksShop.Core.ViewModels.Books.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum PageRange
    {
        [Display(Name = Infrastructure.Data.Constants.UnderOneHundred)]
        UnderOneHundred,
        [Display(Name = Infrastructure.Data.Constants.OneHundredToTwoHundredNinetyNine)]
        OneHundredToTwoHundredNinetyNine,
        [Display(Name = Infrastructure.Data.Constants.AboveThreeHundred)]
        AboveThreeHundred,
    }
}
