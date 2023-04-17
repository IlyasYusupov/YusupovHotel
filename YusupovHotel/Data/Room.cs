using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using YusupovHotel.Shared;

namespace YusupovHotel.Data
{
    public class Room
    {
        public Room(int number, string type, int capacity, double area, int cost, string description)
        {
            Number = number;
            Type = type;
            Capacity = capacity;
            Area = area;
            Cost = cost;
            Description = description;
        }
        public Room()
        {
        }


        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [Required(ErrorMessage = "Укажите номер комнаты")]
        [InputNumberValidation(ErrorMessage = "Такой номер уже зарегистрирован")]
        public int? Number { get; set; }

        [Required(ErrorMessage = "Выберите тип номера")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Укажите вместимость номера")]
        public int? Capacity { get; set; }

        [Required(ErrorMessage = "Укажите площадь номера")]
        public double? Area { get; set; }

        [Required(ErrorMessage = "Стоимость за ночь не указана")]
        public double? Cost { get; set; }

        [Required(ErrorMessage = "Поле описание не заполнено")]
        [StringLength(4000, MinimumLength = 10, ErrorMessage = "Недостаточно описания")]
        public string Description { get; set; }
        [BsonIgnoreIfNull]
        public List<byte[]> photos { get; set; }

        [BsonIgnoreIfNull]
        public List<string> photosUrl { get; set; }

    }
}
