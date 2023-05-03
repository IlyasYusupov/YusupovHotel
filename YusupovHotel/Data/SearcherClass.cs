namespace YusupovHotel.Data
{
    public static class SearcherClass
    {
        public static List<Booking> BookingSearch(List<Booking> bookings, string searchBookByClientName)
        {
            var sortingBookings = bookings.Where((element) =>
                element.Client.ClientName.ToLower().Contains(searchBookByClientName.ToLower()))
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
    }
}
