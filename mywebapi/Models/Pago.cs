using System.ComponentModel.DataAnnotations;

namespace mywebapi.Models
{
    public class Pago
    {
        public int Id { get; set; }

        [Required]
        public string TitularDeTarjeta { get; set; }

        [Required]
        public string NumeroDeTarjeta { get; set; }

        [Required]
        public int Autorizacion { get; set; }

        [Required]
        public System.DateTime FechaDePago { get; set; }

        [Required]
        public string Banco { get; set; }

        // [Required]
        // public int ReciboId { get; set; }

        // Controlado por EFCore
        public Recibo Recibo { get; set; }
    }
}