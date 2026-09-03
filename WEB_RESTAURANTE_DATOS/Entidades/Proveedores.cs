using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_RESTAURANTE_DATOS.Entidades
{
    public class Proveedores
    {
        
        public int Id { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string? Nombre { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string? Apellidos { get; set; }
        
       

    }
}
