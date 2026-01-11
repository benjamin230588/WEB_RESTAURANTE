using Microsoft.AspNetCore.Mvc;
using WEB_RESTAURANTE_DATOS;
using WEB_RESTAURANTE_DATOS.Datos;

namespace WEB_RESTAURANTE.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AplicacionContexto context;
        public ClienteController(AplicacionContexto context)
        {
            this.context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var dao = new DaoCliente(context);

            var clientes = await dao.ListaCategoria();

            return View("ClienteIndex");
        }

        public async Task<IActionResult> Form()
        {
            

            return View("FormCliente");
        }
    }
}
