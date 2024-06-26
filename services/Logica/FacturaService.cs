﻿using Repository.Factura;
using Repository.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class FacturaService : IFacturaRepository
    {
        private FacturaRepository facturaRepository;
        public FacturaService(string connectionString)
        {
            facturaRepository = new FacturaRepository(connectionString);
        }

        public bool add(FacturaModel factura)
        {
            return validarDatos(factura) ? facturaRepository.add(factura) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }

        public bool delete(int id)
        {
            return id > 0 ? facturaRepository.delete(id) : false;
        }

        public IEnumerable<FacturaModel> Get(int id)
        {
            return facturaRepository.Get(id);
        }

        public IEnumerable<FacturaModel> GetAll()
        {
            return facturaRepository.GetAll();
        }

        public bool update(FacturaModel facturaModel)
        {
            return validarDatos(facturaModel) ? facturaRepository.update(facturaModel) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }
        private bool validarDatos(FacturaModel factura)
        {
            int num;
            if (factura == null)
                return false;
            if (string.IsNullOrEmpty(factura.total_letras) || factura.total_letras.Length < 6)
                return false;
            if (!int.TryParse(Convert.ToString(factura.total), out num) )
                return false;
            if (!int.TryParse(Convert.ToString(factura.total_iva5), out num) )
                return false;
            if (!int.TryParse(Convert.ToString(factura.total_iva10), out num) )
                return false;
            if (!int.TryParse(Convert.ToString(factura.total_iva), out num))
                return false;
            return true;
        }
    }
}
