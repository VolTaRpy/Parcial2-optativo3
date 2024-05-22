using Repository.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class PersonaService : IPersonaRepository
    {
        private PersonaRepository personaRepository;
        public PersonaService(string connectionString)
        {
            personaRepository = new PersonaRepository(connectionString);
        }

        public bool add(PersonaModel persona)
        {
            return validarDatos(persona) ? personaRepository.add(persona) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }

        public bool delete(int id)
        {
            return id > 0 ? personaRepository.delete(id) : false;
        }

        public IEnumerable<PersonaModel> GetAll()
        {
            return personaRepository.GetAll();
        }

        public bool update(PersonaModel personaModel)
        {
            return validarDatos(personaModel) ? personaRepository.update(personaModel) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }
        private bool validarDatos(PersonaModel persona)
        {
            if (persona == null)
                return false;
            if (string.IsNullOrEmpty(persona.nombre) || persona.nombre.Length < 3)
                return false;
            if (string.IsNullOrEmpty(persona.apellido) || persona.apellido.Length < 3)
                return false;
            if (string.IsNullOrEmpty(persona.documento) || persona.documento.Length < 3)
                return false;
            if (persona.celular.ToString().Length != 10)
                return false;
            //falta validacion si es numero ingresado .-.
            else
            {
            return true;
            }
        }
    }
}
