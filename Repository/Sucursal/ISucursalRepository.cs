using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sucursal
{
    public interface ISucursalRepository
    {
        bool add(SucursalModel sucursalModel);
        bool update(SucursalModel sucursalModel);
        bool delete(int id);
        IEnumerable<SucursalModel> GetAll();
        IEnumerable<SucursalModel> Get(int id);

    }
}
