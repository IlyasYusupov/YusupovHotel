using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace YusupovHotel.Data
{
    public class Booking
    {
        public Booking(Rooms room, Client client, int adaltCount, int childCount, DateOnly arrivalDate, DateOnly departureDate, double totalPrice)
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


        public Rooms Room { get; set; }

        public Client Client { get; set; }

        public int AdaltCount { get; set; }

        public int ChildCount { get; set; }


        public DateOnly ArrivalDate { get; set; }

        public DateOnly DepartureDate { get; set; }

        public double? TotalPrice { get; set; }
    }

}
