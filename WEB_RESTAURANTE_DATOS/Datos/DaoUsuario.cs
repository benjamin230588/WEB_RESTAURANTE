using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB_RESTAURANTE_DATOS.Entidades;

namespace WEB_RESTAURANTE_DATOS.Datos
{
    public class DaoUsuario
    {
        private readonly AplicacionContexto context;
        public DaoUsuario(AplicacionContexto context)
        {
            this.context = context;

        }

        public  async Task<Usuarios> LoginUsuario(string usuario , string pasword)
        {


            //List<Clientes> model = new List<Clientes>();

            //model = await context.Cliente.ToListAsync();
            Usuarios model;
            //var clave = Encrypt.GetSHA256(password);

            model = await context.Usuario.Where(x => x.Nombre == usuario && x.Pasword == pasword).FirstOrDefaultAsync();
            

            return model;

        }
    }
}
