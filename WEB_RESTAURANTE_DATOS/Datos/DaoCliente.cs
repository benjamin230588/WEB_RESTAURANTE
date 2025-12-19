using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB_RESTAURANTE_DATOS.Entidades;

namespace WEB_RESTAURANTE_DATOS.Datos
{
    public class DaoCliente
    {
        private readonly AplicacionContexto context;
        public DaoCliente(AplicacionContexto context)
        {
            this.context = context;

        }

        public async Task<List<Clientes>> ListaCategoria()
        {


            List<Clientes> model = new List<Clientes>();
          
            model = await context.Cliente.ToListAsync();






            return model;
        }
    }
}
