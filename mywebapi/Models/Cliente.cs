using System.Collections.Generic;

namespace mywebapi.Models
{
    public class Cliente
    {
        public int Cuenta { get; set; }
        public string ClaveDeLocalizacion { get; set; }
        public string NumeroDeContrato { get; set; }
        public string NumeroDeMedidor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDeContrato { get; set; }
        public string Giro { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public int DomicilioId { get; set; }

        // Controlado por EFCore
        public Domicilio Domicilio { get; set; }
        public List<Recibo> Recibos { get; set; }
    }
}