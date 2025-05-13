using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.PulidoA.Models
{
    public class Platform
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<Game> Games { get; set; }

    }
}
