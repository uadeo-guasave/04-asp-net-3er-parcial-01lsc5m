using Microsoft.AspNetCore.Mvc;

namespace mywebapi.Controllers
{
    [ApiController]
    [Route("api/admin")]
    class AdminController : ControllerBase
    {
        // TODO: endpoint para regresar la lista de pagos de un determinado periodo
        //       recibe como parametros dos fechas (periodo)
        //       utilizar el método POST para pasar los parametros
        //       body request: {"inicio":"2020-12-01", "fin":"2020-12-31"}
        //       https://localhost:5001/api/admin/periodo
        //       la respuesta debe incluir el número de cuenta, nombre de usuario, importe
        //       y los datos del pago
        //       body response: [{"cuenta":123,"usuario":"Bidkar Aragón","importe":200.00,
        //      "tarjeta":"123278163287","titular":"Bidkar","autorizacion":1232432,"fecha":2020-12-01}]
    }
}