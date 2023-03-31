using Microsoft.AspNetCore.Routing;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using YusupovHotel.Shared;

namespace YusupovHotel.Data
{
    public class User
    {
        public User(string fullName, string phoneNumber, string email, string password, string confirmPassword)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [Required]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z]+ [а-яА-ЯёЁa-zA-Z]+ ?[а-яА-ЯёЁa-zA-Z]+$", ErrorMessage = "Введите ваш номер телефона")]
        public string FullName { get; set; }
        
        [Required]
        [RegularExpression(@"^((\+7|7|8)\(([0-9]{3})\)-([0-9]){3}-([0-9]){2}-([0-9]){2})$", ErrorMessage = "Введите ваш номер телефона")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Введите ваш email")]
        [EmailValidation(ErrorMessage = "Такая почта уже зарегистрирована")]
        public string Email { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "Пароль должен содержать минимум 5 символов", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль не сходиться!")]
        public string ConfirmPassword { get; set; }

    }
}