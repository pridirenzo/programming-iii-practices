using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Domain.Entities
{
    public class Videogame
    {
        public Videogame() { }
        // constructor predeterminado

        public string Name { get; set; }

        [Key]
        public int Id { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public IList<Review> Reviews = new List<Review>();
    }
}
