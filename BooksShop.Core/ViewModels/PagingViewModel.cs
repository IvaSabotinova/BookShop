namespace BooksShop.Core.ViewModels
{
    using System;

    public class PagingViewModel
    {
        public int CurrentPageNumber { get; set; }

        public bool HasPreviousPage => this.CurrentPageNumber > 1;

        public int PreviousPageNumber => this.CurrentPageNumber - 1;

        public bool HasNextPage => this.CurrentPageNumber < this.PagesCount;

        public int NextPageNumber => this.CurrentPageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.AllItemsCount / this.ItemsPerPage);

        public int ItemsPerPage { get; set; }

        public int AllItemsCount { get; set; }
    }
}
