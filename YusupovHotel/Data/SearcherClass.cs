namespace YusupovHotel.Data
{
    public static class SearcherClass
    {
        public static List<Booking> BookingSearch(List<Booking> bookings, string searchBookByClientName)
        {
            var sortingBookings = bookings.Where((element) =>
                element.Client.ClientName.ToLower().Contains(searchBookByClientName.ToLower())
                || element.Room.RoomNumber.ToString().Contains(searchBookByClientName))
            .ToList();
            return sortingBookings;
        }

        public static List<Client> SearchingClientForSelect(List<Client> clients, string nameClient)
        {
            var sortingClients = clients.Where((element) =>
                element.ClientName.ToLower().Contains(nameClient.ToLower()))
            .ToList();
            return sortingClients;
        }

        public static List<Client> SearchingClient(List<Client> clients, string search)
        {
            var sortingClients = clients.Where((element) =>
                element.ClientName.ToLower().Contains(search.ToLower())
                || element.Email.ToLower().Contains(search.ToLower())
                || element.PhoneNumber.ToLower().Contains(search.ToLower()))
            .ToList();
            return sortingClients;
        }

        public static List<Rooms> SearchingRooms(List<Rooms> rooms, string search)
        {
            var sortingRooms = rooms.Where((element) =>
                element.RoomNumber.ToString().ToLower().Contains(search.ToLower())
                || element.RoomType.ToLower().Contains(search.ToLower()))
            .ToList();
            return sortingRooms;
        }
    }
}
