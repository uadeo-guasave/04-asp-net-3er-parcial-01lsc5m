using System;

namespace mywebapi.Models
{
    public class Recibo
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Periodo { get; set; }
        public int LecturaAnterior { get; set; }
        public int LecturaActual { get; set; }
        public int ConsumoEnM3 { get; set; }
        public DateTime FechaDeLectura { get; set; }
        public DateTime FechaDelUltimoPago { get; set; }
        public double MontoDelUltimoPago { get; set; }
        public double Consumo { get; set; }
        public double Drenaje { get; set; }
        public double Saneamiento { get; set; }
        public double Bomberos { get; set; }
        public double CruzRoja { get; set; }
        public double AdeudoAnterior { get; set; }
        public double Multas { get; set; }
        public double Recargos { get; set; }
        public double SubTotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public string TitularDeTarjeta { get; set; }
        public string NumeroDeTarjeta { get; set; }
        public int Autorizacion { get; set; }
        public DateTime FechaDePago { get; set; }
        public string Banco { get; set; }
        public bool EstaPagado { get; set; }

        // Controlado por EFCore
        public Cliente Cliente { get; set; }
    }
}