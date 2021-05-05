using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieTheater.Core.Models;
using MovieTheater.Service;
using System;

namespace MovieTheater.Api.Controllers
{
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomServices _roomServices;
        public RoomController(IRoomServices roomServices)
        {
            _roomServices = roomServices;
        }
        [HttpGet]
        public List<Room> Get()
        {
            return _roomServices.GetRooms();
        }
        [HttpGet("{roomID}")]
        public Room Get(int roomID)
        {
            return _roomServices.GetRoom(roomID);
        }

        [HttpPost]
        public Room Post(Room room)
        {
            return _roomServices.AddRoom(room);
        }
        [HttpPut("{roomID}")]
        public Room Put(int roomID, Room room)
        {
            return _roomServices.EditRoom(roomID, room);
        }
        [HttpDelete("{roomID}")]
        public void Delete(int roomID)
        {
            _roomServices.DeleteRoom(roomID);
        }
    }
}