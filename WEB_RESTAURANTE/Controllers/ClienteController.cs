using Microsoft.AspNetCore.Mvc;
using WEB_RESTAURANTE_DATOS;
using WEB_RESTAURANTE_DATOS.Datos;

namespace WEB_RESTAURANTE.Controllers
{
    public class ClienteController : Controller
    {
        public async Task<IActionResult> Index()
        {

            using (var context = new AplicacionContexto())
            {
                var dao = new DaoCliente(context);

                var clientes = await dao.ListaCategoria();

               
            }

            return View();
        }
    }
}
