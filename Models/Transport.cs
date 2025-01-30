using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCups.Models
{
    public class Transport
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public  int vehicle{ get; set; }
        public string Name { get; set; }
        public string color { get; set; }
        public string Images { get; set; }
        public string Model { get; set; }
        public string ModelVersion { get; set; }
        public string Km { get; set; }
     
    }

}
