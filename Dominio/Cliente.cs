using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente 
    {
       

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Phone { get; set; }

    }
}
