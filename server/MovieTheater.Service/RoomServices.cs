using System.Collections.Generic;
using MovieTheater.Core;
using System.Linq;
using MovieTheater.Core.Models;

namespace MovieTheater.Service
{
    public class RoomServices : IRoomServices
    {
        private readonly DataContext _context;
        public RoomServices(DataContext context)
        {
            _context = context;
        }
        public Room AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return room;
        }

        public void DeleteRoom(int roomID)
        {
            var room = _context.Rooms.FirstOrDefault(x => x.Id == roomID);
            if (room == null)
            {
                return;
            }
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }

        public Room EditRoom(int roomId, Room room)
        {
            var roomEdit = _context.Rooms.FirstOrDefault(x => x.Id == roomId);
            if (room == null)
            {
                return null;
            }
            roomEdit.Name = roomEdit.Name;
            _context.SaveChanges();
            return roomEdit;
        }

        public List<Room> GetRooms()
        {
            return _context.Rooms.ToList();
        }

        public Room GetRoom(int roomID)
        {
            return _context.Rooms.FirstOrDefault(x => x.Id == roomID);
        }
    }
}