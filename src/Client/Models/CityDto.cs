using System.ComponentModel.DataAnnotations;

namespace Siberian.Demo.Client.Models
{
    public class CityDto
    {
        [Required]
        public string NombreCiudad { get; set; }
    }
}
