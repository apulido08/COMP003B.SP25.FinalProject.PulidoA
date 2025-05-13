using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.PulidoA.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int GenreId { get; set; }

        public int PlatformId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool Completed { get; set; }

    }
}
