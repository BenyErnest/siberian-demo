using System.ComponentModel.DataAnnotations;

namespace Siberian.Demo.Client.Models
{
    public class CrearRestaurantDto
    {
        [Required]
        public string NombreRestaurante { get; set; }

        [Required]
        public int IdCiudad { get; set; }

        [Required]
        public int NumeroAforo { get; set; }

        [Required]
        [Phone]
        public string Telefono { get; set; }
    }
}
