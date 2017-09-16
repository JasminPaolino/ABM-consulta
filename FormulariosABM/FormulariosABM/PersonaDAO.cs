using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulariosABM
{
    class PersonaDAO
    {
        PracticaEntities1 contexto = new PracticaEntities1();

        public List<Persona> listar()
        {
            return contexto.Persona.ToList();
        }

        public void agregar(Persona personaNueva)
        {
            contexto.Persona.Add(personaNueva);
            contexto.SaveChanges();
        }

        public void eliminar(string id)
        {
            int valor = Convert.ToInt32(id);

            Persona persona = contexto.Persona.Where(X => X.Id == valor).FirstOrDefault();

            if (persona != null)
            {
                contexto.Persona.Remove(persona);
                contexto.SaveChanges();
            }
        }

        public void modificar(string id, Persona p)
        {
            int valor = Convert.ToInt32(id);

            Persona persona = contexto.Persona.Where(x => x.Id == valor).FirstOrDefault();

            if (persona != null)
            {
                persona.Nombre = p.Nombre;
                persona.Apellido = p.Apellido;
                persona.Sueldo = p.Sueldo;
                contexto.SaveChanges();
            }
        }


        public Persona obtenerUno(string id)
        {
            int valor = Convert.ToInt32(id);

            Persona persona = contexto.Persona.Where(x => x.Id == valor).FirstOrDefault();

            if (persona != null)
            {
                return persona;
            }
            return null;
        }

    }
}
