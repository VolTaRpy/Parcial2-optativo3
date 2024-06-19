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
        private string arroba = "@";
        private string punto = ".";

        public SucursalService (string connectionString)
        {
            sucursalRepository = new SucursalRepository (connectionString);
        }

        public bool add(SucursalModel sucursal)
        {
            return validarDatos(sucursal) ? sucursalRepository.add(sucursal) : throw new Exception("Error en la validacion de dator, favor verificar");
        }

        public bool delete(int id)
        {
            return id > 0 ? sucursalRepository.delete(id) : throw new Exception("Error en la validacion de dator, favor verificar");
        }

        public IEnumerable<SucursalModel> Get(int id)
        {
            return sucursalRepository.Get(id);
        }

        public IEnumerable<SucursalModel> GetAll()
        {
            return sucursalRepository.GetAll();
        }

        public bool update(SucursalModel sucursalModel)
        {
            return validarDatos(sucursalModel) ? sucursalRepository.update(sucursalModel) : throw new Exception("Error en la validacion de dator, favor verificar");
        }

        private bool validarDatos(SucursalModel sucursal)
        {
            if (sucursal == null)
                return false;
            if (string.IsNullOrEmpty(sucursal.direccion) || sucursal.direccion.Length<9)
                return false;
            if (!sucursal.mail.Contains(arroba) || !sucursal.mail.Contains(punto))
                return false;
            return true;
        }
    }
}
