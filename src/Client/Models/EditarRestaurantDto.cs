using System.ComponentModel.DataAnnotations;

namespace Siberian.Demo.Client.Models
{
    public class EditarRestaurantDto
    {
        [Required]
        public int IdRestaurante { get; set; }

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
