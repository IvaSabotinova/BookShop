namespace BooksShop.Infrastructure.Data
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

        public const string ErrorMessageFirstName = "The First Name is required.";

        public const string DisplayFirstName = "First Name*";

        public const string ErrorMessageLastName = "The Last Name is required.";

        public const string DisplayLastName = "Last Name*";

        public const string ErrorMessageEmail = "The Email is required.";

        public const string DisplayEmail = "Email*";

        public const string ErrorMessageSubject = "The Subject is required.";

        public const string DisplaySubject = "Subject*";

        public const string ErrorMessageContent = "The Message is required.";

        public const string DisplayContent = "Message*";

        public const string MaxLengthErrorMessageContent = "The Message should be less than 7000 characters";

        public const string MinLengthErrorMessageContent = "The Message should be at least 5 characters";
    }
}
