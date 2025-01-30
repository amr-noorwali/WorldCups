using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCups.Models
{
    public class TableFootbul
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "اسم الملعب مطلوب")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please Enter TableFootbul Ctiy")]

        public string Ctiy { get; set; }
        [Required(ErrorMessage = "please Enter TableFootbul studium1_id")]
        public int studium1_id { get; set; }
        [Required(ErrorMessage = "please Enter TableFootbul Ateam1")]
        public string Ateam1 { get; set; }
        [Required(ErrorMessage = "please Enter TableFootbul Ateam2")]
        public string Ateam2 { get; set; }
        [Required(ErrorMessage = "please Enter TableFootbul MatchTime")]
        public DateTime MatchTime { get; set; }
        


    }
}
