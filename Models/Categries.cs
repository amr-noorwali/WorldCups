using System.ComponentModel.DataAnnotations;

namespace WorldCups.Models
{
    public class Categries
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }


    }
}
