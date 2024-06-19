using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DetalleFactura
{
    public interface IDetalleFactura
    {
        bool add(DetalleFacturaModel detalleFactura);
        bool update(DetalleFacturaModel detalleFactura);
        bool delete(int id);
        IEnumerable<DetalleFacturaModel> getAll();
        IEnumerable<DetalleFacturaModel> get(int id);

    }
}
