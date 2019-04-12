using System.Collections.Generic;
using System;
namespace HotelComparator.MyApplication
{
    public interface IComparator
    {
         List<RoomPrice> GetAvailableRooms(DateTime date);
    }
}