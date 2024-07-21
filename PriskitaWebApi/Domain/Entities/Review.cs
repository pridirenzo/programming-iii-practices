using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review
    {
        public Review() { } // constructor predeterminado

        /* public Review(int id, string author, string description)
         {


         }*/

        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int VideogameId { get; set; } // foreign key 
        public Videogame videogame { get; set; } // propiedad de navegacion

    }
}
