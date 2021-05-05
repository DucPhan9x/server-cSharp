
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MovieTheater.Core.Models
{
    [Table("Room")]
    public class Room
    {
        public Room()
        {
            Films = new List<Film>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Film> Films { get; set; }
    }
}