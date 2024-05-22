using Repository.Sucursal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class SucursalService : ISucursalRepository
    {
        private SucursalRepository sucursalRepository;
        public SucursalService (string connectionString)
        {
            sucursalRepository = new SucursalRepository (connectionString);
        }

        public bool add(SucursalModel sucursalModel)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SucursalModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool update(SucursalModel sucursalModel)
        {
            throw new NotImplementedException();
        }

        private bool validarDatos(SucursalModel sucursal)
        {
            if (sucursal == null)
                return false;
            if (string.IsNullOrEmpty(sucursal.direccion) || sucursal.direccion.Length<9)
                return false;

        }
    }
}
