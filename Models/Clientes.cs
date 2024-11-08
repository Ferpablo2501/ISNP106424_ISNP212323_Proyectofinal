using System.ComponentModel.DataAnnotations;

namespace ISNP106424_ISNP212323_Proyectofinal.Models {
    public class Clientes {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string CorreoElectrónico { get; set; }
        public string Teléfono { get; set; }
        public string Dirección { get; set; }
    }
}
