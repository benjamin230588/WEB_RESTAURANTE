using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WEB_RESTAURANTE_DATOS;
using WEB_RESTAURANTE_DATOS.Datos;
using WEB_RESTAURANTE_DATOS.Entidades;
using WEB_RESTAURANTE_ENTIDADES.Helper;
using WEB_RESTAURANTE_ENTIDADES.ViewModel;

namespace WEB_RESTAURANTE.Controllers
{
    public class LoginController : Controller
    {
        private readonly AplicacionContexto context;
        public LoginController(AplicacionContexto context)
        {
            this.context = context;

        }
        [HttpGet]
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
                var sesion = new LoginDto {Idusuario = model.Idusuario, Usuario = model.Usuario };
                string objetosesion = JsonConvert.SerializeObject(sesion);
                // sistema s web
                if (model != null)
                {

                    response.success = true;
                    response.error = "usuario encontrado";
                    HttpContext.Session.SetString(Constantes.SESSION_USUARIO, objetosesion);

                    //   Session["SESION"] = "hola";


                    /// crear la sesion 

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
