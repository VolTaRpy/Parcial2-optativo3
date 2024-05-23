using Services.Logica;
using Repository.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Sucursal;


string connectionString = "Host=localhost;port=5432;database=Store;Username=postgres;Password=matias;";
PersonaService personaService = new PersonaService(connectionString);
SucursalService sucursalService = new SucursalService(connectionString);

Console.WriteLine("Tabla cliente \n Ingrese: \n a - para insertar \n b - para listar");
Console.WriteLine("Tabla sucursal \n Ingrese: \n c - para insertar \n d - para listar");

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