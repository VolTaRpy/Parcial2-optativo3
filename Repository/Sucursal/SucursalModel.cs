using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sucursal
{
    public class SucursalModel
    {
        public int id_sucursal { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int whatsapp { get; set; }
        public string mail { get; set; }
        public string estado { get; set; }
    }
}
