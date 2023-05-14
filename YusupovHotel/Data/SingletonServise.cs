namespace YusupovHotel.Data
{
    public class SingletonServise
    {
        public User user { get; set; }

        //public User GetUser()
        //{
        //    return user;
        //}

        //public void SetUser(User user)
        //{
        //    this.user = user;
        //}

        public Client client { get; set; }

        //public Client GetClient()
        //{
        //    return client;
        //}

        //public void SetClient(Client client)
        //{
        //    this.client = client;
        //}

        public RoomType roomType { get; set; }

        //public Room GetRoom()
        //{
        //    return room;
        //}

        //public void SetRoom(Room room)
        //{
        //    this.room = room;
        //}

        public Booking booking { get; set; }
    }
}