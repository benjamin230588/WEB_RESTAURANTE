using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_RESTAURANTE_DATOS.Entidades
{
    public class Clientes
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Apellido { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Direccion { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Destino { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Destino3 { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Destino4 { get; set; }

    }
}
