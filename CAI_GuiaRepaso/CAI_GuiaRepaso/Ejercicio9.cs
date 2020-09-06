using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio9:IEjercicios
    {
        public void Inicial()
        {
            string nombre = Validaciones.pedirTexto("Nombre Usuario");
            if(string.Compare(nombre, Environment.UserName)==0) //https://docs.microsoft.com/es-es/dotnet/api/system.environment.username?view=netcore-3.1
                Console.WriteLine("Hola {0}!", nombre);
            else
                Console.WriteLine("No te conozco.");
        }
    }
}
