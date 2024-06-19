using Repository.DetalleFactura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class DetalleFacturaService : IDetalleFactura
    {
        private DetalleFacturaRepository detalleFacturaRepository;
        public DetalleFacturaService(string connectionString) 
        {
            detalleFacturaRepository = new DetalleFacturaRepository(connectionString);
        }
        public bool add(DetalleFacturaModel detalleFactura)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetalleFacturaModel> get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetalleFacturaModel> getAll()
        {
            throw new NotImplementedException();
        }

        public bool update(DetalleFacturaModel detalleFactura)
        {
            throw new NotImplementedException();
        }
    }
}
