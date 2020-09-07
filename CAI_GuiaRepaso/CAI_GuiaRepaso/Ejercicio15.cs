using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio15:IEjercicios
    {
        int intentos = 3;
        bool correcta=false;
        public void Inicial()
        {
            do
            {
                if (intentos == 0)
                {
                    Console.WriteLine("Clave bloqueada");
                    break;
                }
                if (string.Compare(Environment.UserName, Validaciones.pedirTexto("usuario")) == 0)
                {
                    Console.WriteLine("Bienvenido *{0}*", Environment.UserName);
                    correcta = true;
                } 
                else
                {
                    Console.WriteLine("Acceso denegado. La contraseña no es correcta.");
                    intentos--;
                }
            } while (!correcta);
            
        }
    }
}
