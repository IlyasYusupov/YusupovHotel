using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using YusupovHotel.Shared;

namespace YusupovHotel.Data
{
    public class Client
    {
        public Client(string clientName, string email, string phoneNumber)
        {
            ClientName = clientName;
            Email = email;
            PhoneNumber = phoneNumber;
        }


        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [Required(ErrorMessage = "Поле ФИО не заполнено")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z]+ [а-яА-ЯёЁa-zA-Z]+ ?[а-яА-ЯёЁa-zA-Z]+$", ErrorMessage = "Неверный формат ФИО")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Почтовый адресс не указан")]
        [EmailAddress(ErrorMessage = "Неверный формат почтового адреса")]
        [EmailValidation(ErrorMessage = "Такая почта уже зарегистрирована")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Номер телефона не указан")]
        [RegularExpression(@"^((\+7|7|8)\(([0-9]{3})\)-([0-9]){3}-([0-9]){2}-([0-9]){2})$", ErrorMessage = "Неверный формат номера")]
        public string PhoneNumber { get; set; }
    }
}
