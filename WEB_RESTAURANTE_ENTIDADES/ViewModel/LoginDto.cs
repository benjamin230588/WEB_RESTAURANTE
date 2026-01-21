using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_RESTAURANTE_ENTIDADES.ViewModel
{
    public class LoginDto
    {
        public int Idusuario { get; set; }
       
        public string Usuario { get; set; }
      
    }
}
