using System.ComponentModel.DataAnnotations;

namespace WorldCups.Models
{
    public class studium1
    {
        [Key]
        public int Id {get; set;}
        [Required (ErrorMessage= "please Enter studium Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please Enter studium Capcity")]
        public int Capcity { get; set; }

        [Required(ErrorMessage = "please Enter studium city")]
        public string city { get; set; }

        [Required(ErrorMessage = "please Enter studium Type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "please Enter studium DateTime")]
        public DateTime ConstractionDate { get; set; }

        [Required(ErrorMessage = "please Enter studium Owner")]
        public string Owner { get; set; }

        [Required(ErrorMessage = "please Enter studium Length")]
        public double Length { get; set; }

        [Required(ErrorMessage = "please Enter studium Width")]
        public int Width { get; set; }

        [Required(ErrorMessage = "please Enter studium Iamges")]
        public string Iamges { get; set; }

        [Required(ErrorMessage = "please Enter studium Height")]
        public double Height { get; set; }

        [Required(ErrorMessage = "please Enter studium Facility")]
        public List<string> Facility { get; set; } = new List<string>();
    }
}
