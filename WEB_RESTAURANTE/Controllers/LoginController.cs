using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WEB_RESTAURANTE.Helpers;
using WEB_RESTAURANTE_DATOS;
using WEB_RESTAURANTE_DATOS.Datos;
using WEB_RESTAURANTE_DATOS.Entidades;

namespace WEB_RESTAURANTE.Controllers
{
    public class LoginController : Controller
    {
        private readonly AplicacionContexto context;
        public LoginController(AplicacionContexto context)
        {
            this.context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Inicio(String usuario, string pasword)
        {

            var response = new ResponseModel("Home/Index");
            Usuarios model;
            try
            {
                var dao = new DaoUsuario(context);
                //Thread.Sleep(20000);
                //await Task.Delay(5000);
                model = await dao.LoginUsuario(usuario, pasword);
                // sistema s web
                if (model != null)
                {

                    response.success = true;
                    response.error = "usuario encontrado";



                }
                else
                {

                    response.success = false;
                    response.error = "Usuario No Encontrado Error";

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
