using System;

namespace Siberian.Demo.Shared
{
    public class Restaurante
    {
        public int IdRestaurante { get; set; }

        public string NombreRestaurante { get; set; }

        public int IdCiudad { get; set; }

        public Ciudad Ciudad { get; set; }

        public int NumeroAforo { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
