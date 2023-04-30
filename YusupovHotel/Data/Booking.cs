using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace YusupovHotel.Data
{
    public class Booking
    {
        public Booking(Room room, Client client, int adaltCount, int childCount, DateOnly arrivalDate, DateOnly departureDate, double totalPrice)
        {
            Room = room;
            Client = client;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            TotalPrice = totalPrice;
            AdaltCount = adaltCount;
            ChildCount = childCount;
        }
        public Booking( )
        {}

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;


        public Room Room { get; set; }

        public Client Client { get; set; }

        public int AdaltCount { get; set; }

        public int ChildCount { get; set; }


        public DateOnly ArrivalDate { get; set; }

        public DateOnly DepartureDate { get; set; }

        public double? TotalPrice { get; set; }
    }

}
