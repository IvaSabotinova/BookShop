namespace BooksShop.Infrastructure.Data
{
    public static class Constants
    {
        public const string AdministratorRoleName = "Administrator";

        public const string ClientRoleName = "Client";

        public const string Message = "Message";

        public const string SuccessMessage = "Message successfully sent!";

        public const string ErrorMessage = "Please fill in all required fields!";

        public const int UserNameMaxLength = 50;

        public const int UserNameMinLength = 5;

        public const int FirstNameMaxLength = 30;

        public const int FirstNameMinLength = 2;

        public const int LastNameMaxLength = 30;

        public const int LastNameMinLength = 2;

        public const int EmailMaxLenght = 330;

        public const int EmailMinLength = 5;

        public const int PhoneNumberMaxLenght = 20;

        public const int AddressMaxLength = 120;

        public const int AddressMinLength = 10;

        public const int PasswordMaxLength = 50;

        public const int PasswordMinLength = 5;

        public const int SubjectMaxLength = 120;

        public const int SubjectMinLength = 2;

        public const int MessageContentMaxLenght = 7000;

        public const int MessageContentMinLenght = 7;

        public const string UserNameErrorMessage = "Username is required!";

        public const string FirstNameErrorMessage = "The First Name is required.";

        public const string DisplayFirstName = "First Name*";

        public const string LastNameErrorMessage = "The Last Name is required.";

        public const string DisplayLastName = "Last Name*";

        public const string EmailErrorMessage = "The Email is required.";

        public const string DisplayEmail = "Email*";

        public const string AddressErrorMessage = "The address is required.";

        public const string SubjectErrorMessage = "The Subject is required.";

        public const string DisplaySubject = "Subject*";

        public const string ContentErrorMessage = "The Message is required.";

        public const string DisplayContent = "Message*";

        public const string MaxLengthContentErrorMessage = "The Message should be less than 7000 characters";

        public const string MinLengthContentErrorMessageContent = "The Message should be at least 7 characters";

        public const int TitleMaxLength = 100;

        public const int TitleMinLength = 2;

        public const string MaxLengthTitleErrorMessage = "The Title cannot exceed 100 characters";

        public const string TitleErrorMessage = "The Title is required";

        public const string AuthorErrorMessage = "The Author is required";

        public const int AuthorMaxLength = 255;

        public const int AuthorMinLength = 2;

        public const string MaxLengthAuthorErrorMessage = "The Author cannot exceed 255 characters";

        public const string ISBNErrorMessage = "The ISBN is required";

        public const int ISBNMaxLength = 20;

        public const int ISBNMinLength = 10;

        public const string MaxLengthISBNErrorMessage = "The ISBN cannot exceed 20 characters";

        public const string NumOfPagesErrorMessage = "The Number of Pages is required";

        public const int MaxNumOfPages = 10000;

        public const int MinNumOfPages = 1;

        public const string MaxNumOfPagesErrorMessage = "The Number of Pages cannot exceed 10000!";

        public const string MinNumOfPagesErrorMessage = "The Number of Pages should be at least 1";

        public const string NumOfPagesRangeErrorMessage = "The Number of Pages must be in the range from 1 to 10000";

        public const string PriceErrorMessage = "The Price is required";

        public const string DecimalType = "decimal(18,2)";

        public const string MaxLengthDescriptionErrorMessage = "The Description cannot exceed 3000 characters";

        public const int DescriptionMaxLength = 3000;

        public const string ImageErrorMessage = "The Image File is required";

        public const int CategoryNameMaxLength = 100;

        public const int CategoryNameMinLength = 2;

        public const string BookCreated = "Book created successfully"!;

        public const string BookCreationFailed = "Something went wrong! Book could not be created! Please try again!";

        public const string BookExists = "Book with this ISBN already created!";

        public const string ISBNExists = "Book with same ISBN already exists! Please check / amend if necessary!";

        public const string BookEdited = "Book details updated successfully!";

        public const string SignInErrorMessage = "Attempt for signing-in failed!";

        public const string UserUpdatedSuccessfully = "Details updated successfully!";

        // Enums
        public const string UnderFifty = "Under 50$";

        public const string FiftyToOneHundred = "50$ to 100$";

        public const string AboveOneHundred = "Above 100$";

        public const string UnderOneHundred = "Under 100";

        public const string OneHundredToTwoHundredNinetyNine = "100 to 299";

        public const string AboveThreeHundred = "Above 300";

        public const string BookNotAvailable = "The book is currently not available";

        public const string Shopping_Cart = "shopping_cart";

    }
}
