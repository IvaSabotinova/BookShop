// <copyright file="Message.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BooksShop.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations;
    using static BooksShop.Infrastructure.Data.Constants;

    public class Message
    {
        public int Id { get; set; }

        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [MaxLength(EmailMaxLenght)]

        public string Email { get; set; } = null!;

        [MaxLength(PhoneNumberMaxLenght)]
        public string? Phone { get; set; }

        public string Subject { get; set; }

        [MaxLength(MessageContentMaxLenght)]
        public string Content { get; set; } = null!;

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
