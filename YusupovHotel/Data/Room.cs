using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

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


        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [Required(ErrorMessage = "Укажите номер комнаты")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Выберите тип номера")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Укажите вместимость номера")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "Укажите рлощадь номера")]
        public double Area { get; set; }

        [Required(ErrorMessage = "Стоимость за ночь не указана")]
        public int Cost { get; set; }

        [Required(ErrorMessage = "Поле описание не заполнено")]
        public string Description { get; set; }

        [BsonIgnoreIfNull]
        public List<byte[]> photos { get; set; }
        public byte[] images { get; set; }

        [BsonIgnoreIfNull]
        public List<string> photosUrl { get; set; }

    }
}
