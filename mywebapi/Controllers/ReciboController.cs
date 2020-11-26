using Microsoft.AspNetCore.Mvc;

namespace mywebapi.Controllers
{
    [ApiController]
    [Route("api/recibo")]
    public class ReciboController : ControllerBase
    {
        // TODO: endpoint para consultar adeudo
        // GET https://localhost:5001/api/recibo/7642
        // recibe como parametro un numero de cuenta de cliente
        // si no tiene adeudo regresa en formato json {"EstaPagado":true}
        // si tiene adeudo regresa en formato json un objeto de tipo Recibo

        // TODO: endpoint para registrar pago
        // POST https://localhost:5001/api/recibo
        // recibe como parametro un objeto de tipo Pago
        // registra el pago correspondiente
        // regresa el recurso del comprobante de pago
        // el comprobante incluye datos del pago y del recibo
        // https://localhost:5001/api/comprobante/7642

        // TODO: endpoint para imprimir comprobante
        // Route("/api/comprobante/{clienteId}")
        // recibe como parametro el numero de cuenta de cliente
        // retorna el último comprobante de pago registrado
        // en caso de no tener pagos registrados regresa objeto en json {"sin_pagos":true}
    }
}