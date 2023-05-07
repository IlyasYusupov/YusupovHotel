
namespace YusupovHotel.Data
{
    public static class SorterClass
    {
        public static List<Rooms> GetRoomWithSelectType(List<Rooms> newSortingRooms, ref bool isRoomTypeSortON, string roomType)
        {
            isRoomTypeSortON = true;
            var sortingRooms = newSortingRooms.Where((element) =>
                element.RoomType.ToLower().Contains(roomType.ToLower()))
            .ToList();
            return sortingRooms;
        }

        public static List<Rooms> GetRoomWithoutBooking(List<Rooms> newSortingRooms, List<Booking> bookings)
        {
            List<Rooms> list = new();
            foreach (var room in newSortingRooms)
            {
                var temp = bookings.FirstOrDefault((element) => element.Room.RoomNumber == room.RoomNumber);
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

        public static List<Rooms> GetRoomForPeopleCount(List<Rooms> newSortingRooms, ref bool isClientCountSortON, string adaltCount, string childCount)
        {
            isClientCountSortON = true;
            int adaltCnt = 0;
            int childCnt = 0;
            if (adaltCount != "") adaltCnt = int.Parse(adaltCount);
            if (childCount != "") childCnt = int.Parse(childCount);
            var sortingRooms = new List<Rooms>();
            foreach (var i in newSortingRooms)
            {
                sortingRooms = newSortingRooms.Where((element) => 
                    Mongo.GetRoomType(element.RoomType).Capacity >= adaltCnt + childCnt)
                    .ToList();
            }

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
