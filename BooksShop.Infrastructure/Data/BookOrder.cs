namespace BooksShop.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using static BooksShop.Infrastructure.Data.Constants;

    public class BookOrder
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = DecimalType)]
        public decimal UnitPrice { get; set; }

    }
}
