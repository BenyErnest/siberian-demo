using System;
using System.ComponentModel.DataAnnotations;

namespace Siberian.Demo.Client.Models
{
    public class CiudadDto
    {
        [Required]
        public string NombreCiudad { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
