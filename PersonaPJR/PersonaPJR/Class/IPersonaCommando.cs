
using System.Collections.Generic;


namespace PersonaPJR.Class
{
    public interface IPersonaCommando
    {
        void Guardar(Persona persona);
        void Modificar(Persona persona);
        List<Persona> GetPersonas();
        void Revover(Persona persona);
    }
}
