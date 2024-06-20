using Services.Logica;
using Repository.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Sucursal;
using Repository.Factura;
using Repository.Producto;

string connectionString = "Host=localhost;port=5432;database=Store;Username=postgres;Password=matias;";
PersonaService personaService = new PersonaService(connectionString);
SucursalService sucursalService = new SucursalService(connectionString);
FacturaService facturaService = new FacturaService(connectionString);
DetalleFacturaService detalleFactura = new DetalleFacturaService(connectionString);
ProductoService productoService = new ProductoService(connectionString);

Console.WriteLine("Tabla cliente \n Ingrese: \n a - para insertar \n b - para listar \n y - para buscar");
Console.WriteLine("Tabla sucursal \n Ingrese: \n c - para insertar \n d - para listar \n z - para buscar");
Console.WriteLine("Tabla factura \n Ingrese: \n e - para insertar \n f - para listar \n x - para buscar");
Console.WriteLine("Tabla producto \n Ingrese: \n g - para insertar \n h - para listar \n i - para buscar");
Console.WriteLine("Tabla detalle \n Ingrese: \n j - facturar");



string opcion = Console.ReadLine();

if (opcion == "a")
{
    personaService.add(new PersonaModel
    {
        id_banco = 1,
        nombre = "Javier",
        apellido = "Martinez",
        documento = "983539",
        direccion = "San Martin 136 c/ P. J. Caballero",
        mail = "chapita@hotmail.com",
        celular = 0961835983,
        estado = "Activo"
    });
}

if (opcion == "b")
{
    personaService.GetAll().ToList().ForEach(persona =>
    Console.WriteLine(
        $"id_cliente: {persona.id_cliente} \n" +
        $"id_banco: {persona.id_banco} \n" +
        $"Nombre: {persona.nombre} \n" +
        $"Apellido: {persona.apellido} \n" +
        $"Documento: {persona.documento} \n" +
        $"Direccion: {persona.direccion} \n" +
        $"Email: {persona.mail} \n" +
        $"Celular: {persona.celular} \n" +
        $"Estado: {persona.estado} \n"
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
    facturaService.add(new FacturaModel
    {
        id_cliente = 3,
        id_sucursal = 3,
        numero_factura = "80014723-333",
        fecha_hora = new DateTime(1990, 10, 5),
        total = 3000000,
        total_iva5 = 0,
        total_iva10 = 300000,
        total_iva = 300000,
        total_letras = "un millon3",
        sucursal = "luque"
    }
        );
}

if (opcion == "f")
{
    facturaService.GetAll().ToList().ForEach(factura =>
    Console.WriteLine(
         $"id_cliente: {factura.id_cliente}\n"+
         $"id_sucursal: {factura.id_sucursal}\n"+
         $"numero_factura: {factura.numero_factura}\n"+
         $"fecha_hora: {factura.fecha_hora}\n"+
         $"total: {factura.total}\n"+
         $"total_iva5:{factura.total_iva5}\n"+
         $"total_iva10 = {factura.total_iva10} \n"+
         $"total_iva = {factura.total_iva} \n"+
         $"total_letras = {factura.total_letras} \n"+
         $"sucursal = {factura.sucursal} \n"
        )
    );
}
if (opcion == "y")
{
    int bus = 8;
    personaService.get(bus).ToList().ForEach(persona =>
    Console.WriteLine(
        $"id_cliente: {persona.id_cliente} \n" +
        $"id_banco: {persona.id_banco} \n" +
        $"Nombre: {persona.nombre} \n" +
        $"Apellido: {persona.apellido} \n" +
        $"Documento: {persona.documento} \n" +
        $"Direccion: {persona.direccion} \n" +
        $"Email: {persona.mail} \n" +
        $"Celular: {persona.celular} \n" +
        $"Estado: {persona.estado} \n"
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
    facturaService.Get(bus).ToList().ForEach(factura =>
    Console.WriteLine(
         $"id_cliente: {factura.id_cliente}\n" +
         $"id_sucursal: {factura.id_sucursal}\n" +
         $"numero_factura: {factura.numero_factura}\n" +
         $"fecha_hora: {factura.fecha_hora}\n" +
         $"total: {factura.total}\n" +
         $"total_iva5:{factura.total_iva5}\n" +
         $"total_iva10 = {factura.total_iva10} \n" +
         $"total_iva = {factura.total_iva} \n" +
         $"total_letras = {factura.total_letras} \n" +
         $"sucursal = {factura.sucursal} \n"
        )
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