using System.ComponentModel.DataAnnotations;

namespace WorldCups.Models
{
    public class CatogorisTransportation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
