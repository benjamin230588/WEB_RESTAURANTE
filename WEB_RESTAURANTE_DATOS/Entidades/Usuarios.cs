using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_RESTAURANTE_DATOS.Entidades
{
    public class Usuarios
    {
        [Key]
        public int Idusuario { get; set; }
        public Nullable<int> Idcorrelativo { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Usuario { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Pasword { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }
    
    }
}
