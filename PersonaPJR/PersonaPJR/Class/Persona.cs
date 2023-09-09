

using System;
using System.Collections.Generic;

namespace PersonaPJR.Class
{
    public abstract class Persona : IPersonaCommando
    {
       
        public virtual List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public virtual void Guardar(Persona persona)
        {
            throw new NotImplementedException();
        }

        public virtual void Modificar(Persona persona)
        {
            throw new NotImplementedException();
        }
              
        public virtual void Revover(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
