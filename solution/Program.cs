using Services.Logica;
using Repository.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Sucursal;
using Repository.Pedido_Compra;
using Repository.Producto;

string connectionString = "Host=localhost;port=5432;database=Examen;Username=postgres;Password=matias;";
ProveedorService proveedorService = new ProveedorService(connectionString);
SucursalService sucursalService = new SucursalService(connectionString);
PedidoService pedidoService = new PedidoService(connectionString);
DetallePedidoService detallePedido = new DetallePedidoService(connectionString);
ProductoService productoService = new ProductoService(connectionString);

Console.WriteLine("Tabla proveedor \n Ingrese: \n a - para insertar \n b - para listar \n y - para buscar");
Console.WriteLine("Tabla sucursal \n Ingrese: \n c - para insertar \n d - para listar \n z - para buscar");
Console.WriteLine("Tabla pedido \n Ingrese: \n e - para insertar \n f - para listar \n x - para buscar");
Console.WriteLine("Tabla producto \n Ingrese: \n g - para insertar \n h - para listar \n i - para buscar");
Console.WriteLine("Tabla detalle \n Ingrese: \n j - facturar");



string opcion = Console.ReadLine();

if (opcion == "a")
{
    proveedorService.add(new ProveedorModel
    {
        razonsocial = "Martinez S.A",
        documento = "983539",
        direccion = "San Martin 136 c/ P. J. Caballero",
        mail = "chapita@hotmail.com",
        celular = 0961835983,
        estado = "Activo"
    });
}

if (opcion == "b")
{
    proveedorService.GetAll().ToList().ForEach(proveedor =>
    Console.WriteLine(
        $"id_proveedor: {proveedor.id_proveedor} \n" +
        $"razonsocial: {proveedor.razonsocial} \n" +
        $"Documento: {proveedor.documento} \n" +
        $"Direccion: {proveedor.direccion} \n" +
        $"Email: {proveedor.mail} \n" +
        $"Celular: {proveedor.celular} \n" +
        $"Estado: {proveedor.estado} \n"
        )
    );
}

if (opcion == "c")
{
    sucursalService.add(new SucursalModel
    {
        descripcion = "Sucursal Luque",
        direccion = "San martin esq P. J. Caballero",
        telefono = 021242424,
        whatsapp = 0971710710,
        mail = "soporte@banco",
        estado = "Activo"
    }
        );
}

if (opcion == "d")
{
    sucursalService.GetAll().ToList().ForEach(sucursal =>
    Console.WriteLine(
        $"id_sucursal: {sucursal.id_sucursal} \n" +
        $"descripcion: {sucursal.descripcion} \n" +
        $"direccion: {sucursal.direccion} \n" +
        $"telefono: {sucursal.telefono} \n" +
        $"whatsapp: {sucursal.whatsapp} \n" +
        $"mail: {sucursal.mail} \n" +
        $"estado: {sucursal.estado} \n"
        )
    );
}
//probando_fk
if(opcion == "e")
{
    pedidoService.add(new PedidoModel
    {
        id_proveedor = 3,
        id_sucursal = 3,
        fecha_hora = new DateTime(1990, 10, 5),
        total = 3000000,

    }
        );
}

if (opcion == "f")
{
    pedidoService.GetAll().ToList().ForEach(pedido =>
    Console.WriteLine(
         $"id_pedido: {pedido.id_pedido}\n" +
         $"id_proveedor: {pedido.id_proveedor}\n"+
         $"id_sucursal: {pedido.id_sucursal}\n"+
         $"fecha_hora: {pedido.fecha_hora}\n"+
         $"total: {pedido.total}\n")
    );
}
if (opcion == "y")
{
    int bus = 8;
    proveedorService.get(bus).ToList().ForEach(proveedor =>
    Console.WriteLine(
        $"id_proveedor: {proveedor.id_proveedor} \n" +
        $"RazonSocial: {proveedor.razonsocial} \n" +
        $"Documento: {proveedor.documento} \n" +
        $"Direccion: {proveedor.direccion} \n" +
        $"Email: {proveedor.mail} \n" +
        $"Celular: {proveedor.celular} \n" +
        $"Estado: {proveedor.estado} \n"
        ));
}
if (opcion == "z")
{
    int bus = 1;
    sucursalService.Get(bus).ToList().ForEach(sucursal =>
    Console.WriteLine(
        $"id_sucursal: {sucursal.id_sucursal} \n" +
        $"descripcion: {sucursal.descripcion} \n" +
        $"direccion: {sucursal.direccion} \n" +
        $"telefono: {sucursal.telefono} \n" +
        $"whatsapp: {sucursal.whatsapp} \n" +
        $"mail: {sucursal.mail} \n" +
        $"estado: {sucursal.estado} \n"
        )
    );
}

if (opcion == "x")
{
    int bus = 1;
    pedidoService.Get(bus).ToList().ForEach(pedido =>
    Console.WriteLine(
         $"id_proveedor: {pedido.id_proveedor}\n" +
         $"id_sucursal: {pedido.id_sucursal}\n" +
         $"fecha_hora: {pedido.fecha_hora}\n" +
         $"total: {pedido.total}\n")
    );
}
if (opcion == "g")
{
    productoService.add(new ProductoModel
    {
        descripcion = "Remera",
        cantidad_minima = 0,
        cantidad_stock = 120,
        precio_compra = 700000,
        precio_venta = 110000,
        categoria = "ropa",
        marca = "Adidas",
        estado = "Disponible"
        
    }
   );
}
if (opcion == "h")
{
    productoService.GetAll().ToList().ForEach(producto =>
    Console.WriteLine(
        $"Id_producto: {producto.id_producto} \n" +
        $"Descripcion: {producto.descripcion} \n" +
        $"Cantidad_minima: {producto.cantidad_minima} \n" +
        $"Cantidad_stock: {producto.cantidad_stock} \n" +
        $"Precio_compra: {producto.precio_compra} \n" +
        $"Precio_venta: {producto.precio_venta} \n" +
        $"Categoria: {producto.categoria} \n" +
        $"Marca: {producto.marca} \n" +
        $"Estado: {producto.estado} \n"
        )
    );
}
if (opcion == "i")
{
    int bus=1;
    productoService.Get(bus).ToList().ForEach(producto =>
    Console.WriteLine(
        $"Id_producto: {producto.id_producto} \n" +
        $"Descripcion: {producto.descripcion} \n" +
        $"Cantidad_minima: {producto.cantidad_minima} \n" +
        $"Cantidad_stock: {producto.cantidad_stock} \n" +
        $"Precio_compra: {producto.precio_compra} \n" +
        $"Precio_venta: {producto.precio_venta} \n" +
        $"Categoria: {producto.categoria} \n" +
        $"Marca: {producto.marca} \n" +
        $"Estado: {producto.estado} \n"
        )
    );
}

if (opcion == "j")
{
    int subtotal = 0;
    Console.WriteLine("Posibles Productos a facturar");
    productoService.GetAll().ToList().ForEach(producto =>
    Console.WriteLine(
        $"Id_producto: {producto.id_producto} \n" +
        $"Descripcion: {producto.descripcion} \n" +
        $"Precio: {producto.precio_venta} \n" +
        $"Marca: {producto.marca} \n"
        )
    );
    Console.WriteLine("Elija una id y la cantidad a llevar");
    string ropa = Console.ReadLine(); 
    string cant = Console.ReadLine();
    productoService.Get(Convert.ToInt32(ropa)).ToList().ForEach(producto =>
    subtotal = Convert.ToInt32(producto.precio_venta)
    );
    Convert.ToInt32(cant);
    subtotal = Convert.ToInt32(subtotal) * Convert.ToInt32(cant);
    Console.WriteLine($"precio a pagar {subtotal}");
} 