using Services.Logica;
using Repository.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Sucursal;
using Repository.Factura;


string connectionString = "Host=localhost;port=5432;database=Store;Username=postgres;Password=matias;";
PersonaService personaService = new PersonaService(connectionString);
SucursalService sucursalService = new SucursalService(connectionString);
FacturaService facturaService = new FacturaService(connectionString);

Console.WriteLine("Tabla cliente \n Ingrese: \n a - para insertar \n b - para listar");
Console.WriteLine("Tabla sucursal \n Ingrese: \n c - para insertar \n d - para listar");
Console.WriteLine("Tabla factura \n Ingrese: \n e - para insertar \n f - para listar");

string opcion = Console.ReadLine();

if (opcion == "a")
{
    personaService.add(new PersonaModel
    {
        id_banco = 1,
        nombre = "Matias",
        apellido = "Martinez",
        documento = "4185539",
        direccion = "San Martin 136 c/ P. J. Caballero",
        mail = "matias_wicho@hotmail.com",
        celular = 985138981,
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