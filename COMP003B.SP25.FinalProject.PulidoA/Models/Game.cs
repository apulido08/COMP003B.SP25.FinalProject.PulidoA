using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.PulidoA.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Genre { get; set; }
        

        public string Platform{ get; set; }
        

        public DateTime ReleaseDate { get; set; }

        public bool Completed { get; set; }

        public int Rating { get; set; } // Will be added after database update is applied.

    }
}
