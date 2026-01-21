using Newtonsoft.Json;
using WEB_RESTAURANTE_DATOS.Entidades;
using WEB_RESTAURANTE_ENTIDADES.Helper;
using WEB_RESTAURANTE_ENTIDADES.ViewModel;

namespace WEB_RESTAURANTE.Sesiones
{
    public class SesionUtil
    {

        private static IHttpContextAccessor _accessor;

        public static void Configure(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        private static ISession Session =>
            _accessor?.HttpContext?.Session;

        public static LoginDto Usuario
        {
            get
            {
                var json = Session?.GetString(Constantes.SESSION_USUARIO);
                return json == null
                    ? null
                    : JsonConvert.DeserializeObject<LoginDto>(json);
            }
            set
            {
                if (value == null)
                    Session?.Remove(Constantes.SESSION_USUARIO);
                else
                    Session?.SetString(
                        Constantes.SESSION_USUARIO,
                        JsonConvert.SerializeObject(value)
                    );
            }
        }
    


}
}
