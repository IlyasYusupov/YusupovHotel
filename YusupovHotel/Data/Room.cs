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

        public int Number { get; set; }

        public string Type { get; set; }


        public int Capacity { get; set; }

        public double Area { get; set; }

        public int Cost { get; set; }

        public string Description { get; set; }

        [BsonIgnoreIfNull]
        public byte[] images { get; set; }

        [BsonIgnoreIfNull]
        public List<string> imagesUrl = new List<string>();

    }
}
