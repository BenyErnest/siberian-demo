using System.ComponentModel.DataAnnotations;

namespace Siberian.Demo.Client.Models
{
    public class EditCityDto
    {
        [Required]
        public int IdCiudad { get; set; }

        [Required]
        public string NombreCiudad { get; set; }
    }
}
