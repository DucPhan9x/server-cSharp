using System.Collections.Generic;
using MovieTheater.Core.Models;

namespace MovieTheater.Service
{
    public interface IRoomServices
    {
        public List<Room> GetRooms();
        public Room GetRoom(int roomID);
        public Room AddRoom(Room room);
        public Room EditRoom(int roomID, Room room);
        public void DeleteRoom(int roomID);
    }
}