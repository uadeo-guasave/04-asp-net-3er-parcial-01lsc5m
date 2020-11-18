using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mywebapi.Models
{
    public class Cliente
    {
        [Key]
        public int Cuenta { get; set; }

        [Required]
        public string ClaveDeLocalizacion { get; set; }

        [Required]
        public string NumeroDeContrato { get; set; }

        [Required]
        public string NumeroDeMedidor { get; set; }

        [Required, MaxLength(50)]
        public string Nombres { get; set; }

        [Required, MaxLength(50)]
        public string Apellidos { get; set; }

        [Required, MaxLength(30)]
        public string TipoDeContrato { get; set; }

        [Required, MaxLength(200)]
        public string Giro { get; set; }

        [Required, MaxLength(200)]
        public string RazonSocial { get; set; }

        [Required, MaxLength(13)]
        public string Rfc { get; set; }

        [Required]
        public int DomicilioId { get; set; }

        // Controlado por EFCore
        public Domicilio Domicilio { get; set; }
        public List<Recibo> Recibos { get; set; }
    }
}