using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json;
using System.Net;
using WEB_RESTAURANTE_DATOS;
using WEB_RESTAURANTE_DATOS.Datos;
using WEB_RESTAURANTE_DATOS.Entidades;
using WEB_RESTAURANTE_ENTIDADES.Helper;

namespace WEB_RESTAURANTE.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AplicacionContexto context;
        public ClienteController(AplicacionContexto context)
        {
            this.context = context;
            
        }
        [HttpGet]
        public  ActionResult Index()
        {
            //var dao = new DaoCliente(context);
            //var obj = new Clientes() { Id = 1, Nombre = "delia" };
            //return obj;
            //var clientes = await dao.ListaCategoria();
            //ViewBag.usuario= HttpContext.Session.GetString("PERSONA");
            return View("ClienteIndex");
        }
        [HttpPost]
        public async Task<JsonResult> ListarClientes()
        {
            var dao = new DaoCliente(context);

            var clientes = await dao.ListaCliente();

            return Json(clientes);
           
        }
        [HttpGet]
        public ActionResult FormNuevo()
        {
            Clientes objeto = new Clientes();
           // objeto.Nombre = "carlos";

            return View("FormCliente",objeto);
        }

        [HttpGet]
        public async Task<ActionResult> FormEditar23(string cadena)
        {

            var dao = new DaoCliente(context);

            var objeto = await dao.GetCliente(1);

            return View("FormCliente", objeto);
        }

        [HttpGet]
        public async Task<ActionResult> FormEditar(int id)
        {
           
            var dao = new DaoCliente(context);

            var objeto = await dao.GetCliente(id);

            return View("FormCliente", objeto);
        }
        [HttpPost]
        public async Task<JsonResult> Grabar(Clientes model)
        {

            var response = new ResponseModel();
          
            try
            {

                var dao = new DaoCliente(context);
                Respuesta Rspta;
                if (model.Id==0) {
                    Rspta = await dao.GrabarCliente(model);

                }
                else
                {
                    Rspta = await dao.Modificarliente(model);
                }

                  
                if (Rspta.estado)
                {
                    response.success = true;
                    response.error = "";
                }
                else
                {
                    response.success = false;
                    response.error = Rspta.mensaje;
                }

            }


            catch (Exception ex)
            {
                response.success = false;
                response.error = ex.Message;

            }
            return Json(response);
        }
    }
}
