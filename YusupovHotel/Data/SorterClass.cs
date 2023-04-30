
namespace YusupovHotel.Data
{
    public static class SorterClass
    {
        public static List<Room> GetRoomWithSelectType(List<Room> newSortingRooms, ref bool isRoomTypeSortON, string roomType)
        {
            isRoomTypeSortON = true;
            var sortingRooms = newSortingRooms.Where((element) =>
                element.Type.ToLower().Contains(roomType.ToLower()))
            .ToList();
            return sortingRooms;
        }

        public static List<Room> GetRoomWithoutBooking(List<Room> newSortingRooms, List<Booking> bookings)
        {
            List<Room> list = new();
            foreach (var room in newSortingRooms)
            {
                var temp = bookings.FirstOrDefault((element) => element.Room.Number == room.Number);
                if (temp != null)
                {
                    if (temp.DepartureDate < GetDate(DateTime.Now.Date.ToString("dd.MM.yyyy")))
                    {
                        list.Add(room);
                    }
                }
                else list.Add(room);
            }
            return list;
        }

        public static List<Room> GetRoomForPeopleCount(List<Room> newSortingRooms, ref bool isClientCountSortON, string adaltCount, string childCount)
        {
            isClientCountSortON = true;
            int adaltCnt = 0;
            int childCnt = 0;
            if (adaltCount != "") adaltCnt = int.Parse(adaltCount);
            if (childCount != "") childCnt = int.Parse(childCount);
            var sortingRooms = newSortingRooms.Where((element) =>
                        element.Capacity >= adaltCnt + childCnt)
            .ToList();
            return sortingRooms;
        }

        private static DateOnly GetDate(string date)
        {
            int day = int.Parse(date.Split('.', ',')[0]);
            int mounth = int.Parse(date.Split('.', ',')[1]);
            int year = int.Parse(date.Split('.', ',')[2]);
            return new DateOnly(year, mounth, day);
        }
    }
}
