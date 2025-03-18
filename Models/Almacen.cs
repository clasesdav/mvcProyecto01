using System.ComponentModel.DataAnnotations;

namespace mvcProyecto.Models
{
    public class Almacen
    {
        [Key]
        public int Id { get; set; }
        public string NombreAlmacen { get; set; }
        public string Direccion { get; set; }
    }
}
