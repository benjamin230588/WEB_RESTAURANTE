using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB_RESTAURANTE_DATOS.Entidades;
using WEB_RESTAURANTE_ENTIDADES.Helper;

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
        public async Task<Clientes> GetCliente( int id)
        {


            Clientes objeto = new Clientes();

            objeto = await context.Cliente.Where(x => x.Id == id).FirstOrDefaultAsync();

            return objeto;
        }
        public async Task<Respuesta> GrabarCliente( Clientes objeto)
        {
            Respuesta Rsp = new Respuesta();


            try
            {
                context.Add(objeto);
                await context.SaveChangesAsync();

                Rsp.estado = true;
            }
            catch(Exception ex)
            {
                Rsp.estado = false;
                Rsp.mensaje = ex.Message;
            }

            return Rsp;
        }

        public async Task<Respuesta> Modificarliente(Clientes objeto)
        {
            Respuesta Rsp = new Respuesta();


            try
            {
                context.Update(objeto);
                await context.SaveChangesAsync();

                Rsp.estado = true;
            }
            catch (Exception ex)
            {
                Rsp.estado = false;
                Rsp.mensaje = ex.Message;
            }

            return Rsp;
        }

    }
}
