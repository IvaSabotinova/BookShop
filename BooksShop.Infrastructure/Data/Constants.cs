﻿namespace BooksShop.Infrastructure.Data
{
    public static class Constants
    {
        public const string Message = "Message";

        public const string SuccessMessage = "Message successfully sent!";

        public const string ErrorMessage = "Please fill in all required fields!";

        public const int FirstNameMaxLength = 30;

        public const int LastNameMaxLength = 30;

        public const int PhoneNumberMaxLenght = 20;

        public const int EmailMaxLenght = 330;

        public const int MessageContentMaxLenght = 7000;

        public const string FirstNameErrorMessage = "The First Name is required.";

        public const string DisplayFirstName = "First Name*";

        public const string LastNameErrorMessage = "The Last Name is required.";

        public const string DisplayLastName = "Last Name*";

        public const string EmailErrorMessage = "The Email is required.";

        public const string DisplayEmail = "Email*";

        public const string SubjectErrorMessage = "The Subject is required.";

        public const string DisplaySubject = "Subject*";

        public const string ContentErrorMessage = "The Message is required.";

        public const string DisplayContent = "Message*";

        public const string MaxLengthContentErrorMessage = "The Message should be less than 7000 characters";

        public const string MinLengthContentErrorMessageContent = "The Message should be at least 5 characters";

        public const int TitleMaxLength = 100;

        public const string MaxLengthTitleErrorMessage = "The Title cannot exceed 100 characters";

        public const string TitleErrorMessage = "The Title is required";

        public const string AuthorErrorMessage = "The Author is required";

        public const int AuthorMaxLength = 255;

        public const string MaxLengthAuthorErrorMessage = "The Author cannot exceed 255 characters";

        public const string ISBNErrorMessage = "The ISBN is required";

        public const int ISBNMaxLength = 20;

        public const string MaxLengthISBNErrorMessage = "The ISBN cannot exceed 20 characters";

        public const string NumOfPagesErrorMessage = "The Number of Pages is required";

        public const string MaxNumOfPagesErrorMessage = "The Number of Pages cannot exceed 10000!";

        public const string MinNumOfPagesErrorMessage = "The Number of Pages should be at least 1";

        public const string NumOfPagesRangeErrorMessage = "The Number of Pages must be in the range from 1 to 10000";

        public const string PriceErrorMessage = "The Price is required";

        public const string DecimalType = "decimal(18,2)";

        public const string MaxLengthDescriptionErrorMessage = "The Description cannot exceed 1000 characters";

        public const int DescriptionMaxLength = 3000;

        public const string ImageErrorMessage = "The Image File is required";

        public const int CategoryNameMaxLength = 100;








    }
}
