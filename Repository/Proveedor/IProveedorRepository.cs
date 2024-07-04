using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Proveedor
{
    public interface IProveedorRepository
    {
        bool add(ProveedorModel personaModel);
        bool update(ProveedorModel personaModel);
        bool delete(int id);
        IEnumerable<ProveedorModel> GetAll();
        IEnumerable<ProveedorModel> get(int id);
    }
}
