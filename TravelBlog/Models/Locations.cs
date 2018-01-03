using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Locations
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
