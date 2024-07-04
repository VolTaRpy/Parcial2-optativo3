using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Proveedor
{
    public class ProveedorModel
    {
        public int id_proveedor { get; set; }
        public string razonsocial { get; set; }
        public string documento { get; set; }
        public string direccion { get; set; }
        public string mail { get; set; }
        public int celular { get; set; }
        public string estado { get; set; }


    }
}
