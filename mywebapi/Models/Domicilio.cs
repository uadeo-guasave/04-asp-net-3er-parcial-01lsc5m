using System.ComponentModel.DataAnnotations;

namespace mywebapi.Models
{
    public class Domicilio
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string CallePrincipal { get; set; }

        [Required, MaxLength(100)]
        public string CalleA { get; set; }
        
        [Required, MaxLength(100)]
        public string CalleB { get; set; }

        [Required]
        public int NumeroExterior { get; set; }

        [Required]
        public string NumeroInterior { get; set; }

        [Required]
        public int CodigoPostal { get; set; }

        [Required, MaxLength(100)]
        public string Colonia { get; set; }
        
        [Required, MaxLength(100)]
        public string Localidad { get; set; }
        
        [Required, MaxLength(100)]
        public string Municipio { get; set; }

        // Controlado por EFCore
        public Cliente Cliente { get; set; }
    }
}