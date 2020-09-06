using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CAI_GuiaRepaso
{
    class Ejercicio10:IEjercicios
    {
        char letra;
        bool datook = true;
        
        public void Inicial()
        {
            do
            {
                if (!char.TryParse(Validaciones.pedirTexto("una tecla").ToLower(), out letra))
                {
                    Console.WriteLine("Error. Debe ingresar solo una tecla. Reingrese: ");
                    datook = false;
                }
            } while (!datook);
            

            if ("aeiou".Contains(letra))
            {
                Console.WriteLine("La tecla {0} es una vocal.", letra);
            }
            else if ("1234567890".Contains(letra))
            {
                Console.WriteLine("La tecla {0} es un numero.", letra);
            }
            else if ("bcdfghjklmnpqrstvwxyz".Contains(letra))
            {
                Console.WriteLine("La tecla {0} es una consonante.", letra);
            }
            else
            {
                Console.WriteLine("La tecla {0} no es una vocal, consonante o numero.", letra);
            }
        }
    }
}
