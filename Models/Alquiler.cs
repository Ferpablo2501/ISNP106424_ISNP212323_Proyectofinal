using System.ComponentModel.DataAnnotations;
namespace ISNP106424_ISNP212323_Proyectofinal.Models {
    public class Alquiler {
        [Key]
        public int IdAlquiler { get; set; } 
        public int Cliente { get; set; }
        public int Pelicula { get; set; }
        public int  FechaDeEntrega { get; set; }
        public int  FechaDeDevolucion { get; set; }
    }
}