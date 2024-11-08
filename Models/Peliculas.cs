using System.ComponentModel.DataAnnotations;

namespace ISNP106424_ISNP212323_Proyectofinal.Models
{
    public class Peliculas{
        [Key]
        public int IdPeliculas { get; set; }
        public string Titulo { get;   set; } 
        public string Director { get;   set; }
        public string Sinopsis { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
    }
}
