using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

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

        public string ClientName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
