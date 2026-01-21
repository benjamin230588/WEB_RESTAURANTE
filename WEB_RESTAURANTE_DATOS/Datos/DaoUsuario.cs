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
            Usuarios model;
         
            model = await context.Usuario.Where(x => x.Usuario == usuario && x.Pasword == pasword).FirstOrDefaultAsync();
            

            return model;

        }
    }
}
