using Services.Logica;
using Repository.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


string connectionString = "Host=localhost;port=5432;database=Store;Username=postgres;Password=matias;";
PersonaService personaService = new PersonaService(connectionString);

Console.WriteLine("Ingrese: \n a - para insertar \n b - para listar");
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
        celular = 0985138981,
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
