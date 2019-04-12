using System;
using System.Collections.Generic;

namespace HotelComparator
{
    public class ComparatorAdaptor : Client.IComparator
    {
        public List<Client.RoomAvailability> GetRoomAvailabilities(DateTime date)
        {
            List<RoomPrice> roomPrices = new Comparator().GetAvailableRooms(date);
            List<Client.RoomAvailability> roomAvailabilities = new List<Client.RoomAvailability>();

            foreach (RoomPrice roomPrice in roomPrices)
            {
                Client.RoomAvailability roomAvailability = new Client.RoomAvailability()
                {
                    RoomInformation = new Client.RoomInformation() 
                    { 
                        RoomNumber = roomPrice.Room.Number, 
                        //RoomType =  roomPrice.Room.RoomType == RoomType.Single ? "Single" : "Double",
                    },
                    Date = roomPrice.Date,
                    Price = new Client.Price() 
                    {
                        Amount = roomPrice.Price.Amount,
                        Currency = roomPrice.Price.Currency
                    }
                };
                roomAvailabilities.Add(roomAvailability);
            }

            return roomAvailabilities;
        }
    }
}