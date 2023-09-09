using PersonaPJR.Class;
using System;

namespace PersonaPJR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Docente docente = new Docente();

            Persona persona = new Medico();

            docente.Guardar(docente);
        }
    }
}
