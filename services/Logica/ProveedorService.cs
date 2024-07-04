using Repository.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ProveedorService : IProveedorRepository
    {
        private ProveedorRepository proveedorRepository;
        public ProveedorService(string connectionString)
        {
            proveedorRepository = new ProveedorRepository(connectionString);
        }

        public bool add(ProveedorModel proveedor)
        {
            return validarDatos(proveedor) ? proveedorRepository.add(proveedor) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }

        public bool delete(int id)
        {
            return id > 0 ? proveedorRepository.delete(id) : false;
        }

        public IEnumerable<ProveedorModel> get(int id)
        {
            return proveedorRepository.get(id);
        }

        public IEnumerable<ProveedorModel> GetAll()
        {
            return proveedorRepository.GetAll();
        }

        public bool update(ProveedorModel proveedorModel)
        {
            return validarDatos(proveedorModel) ? proveedorRepository.update(proveedorModel) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }
        private bool validarDatos(ProveedorModel proveedor)
        {
            if (proveedor == null)
                return false;
            if (string.IsNullOrEmpty(proveedor.razonsocial) || proveedor.razonsocial.Length < 3)
                return false;
            if (string.IsNullOrEmpty(proveedor.documento) || proveedor.documento.Length < 3)
                return false;
            if (proveedor.celular.ToString().Length != 9)
                return false;
            //falta validacion si es numero ingresado .-.
            else
            {
            return true;
            }
        }
    }
}
