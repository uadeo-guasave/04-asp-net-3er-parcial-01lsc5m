using System;
using System.ComponentModel.DataAnnotations;

namespace mywebapi.Models
{
    public class Recibo
    {
        public int Id { get; set; }

        [Required]
        public int ClienteCuenta { get; set; }

        [Required, MaxLength(30)]
        public string Periodo { get; set; }

        [Required]
        public int LecturaAnterior { get; set; }

        [Required]
        public int LecturaActual { get; set; }

        [Required]
        public int ConsumoEnM3 { get; set; }

        [Required]
        public DateTime FechaDeLectura { get; set; }

        [Required]
        public DateTime FechaDelUltimoPago { get; set; }

        [Required]
        public double MontoDelUltimoPago { get; set; }

        [Required]
        public double Agua { get; set; }

        [Required]
        public double Drenaje { get; set; }

        [Required]
        public double Saneamiento { get; set; }

        [Required]
        public double Bomberos { get; set; }

        [Required]
        public double CruzRoja { get; set; }

        [Required]
        public double AdeudoAnterior { get; set; }

        [Required]
        public double Multas { get; set; }

        [Required]
        public double Recargos { get; set; }

        [Required]
        public double Otros { get; set; }

        [Required]
        public double SubTotal { get; set; }

        [Required]
        public double Iva { get; set; }

        [Required]
        public double Total { get; set; }

        [Required]
        public bool EstaPagado { get; set; }

        [Required]
        public int PagoId { get; set; }

        // Controlado por EFCore
        public Cliente Cliente { get; set; }
        public Pago Pago { get; set; }
    }
}