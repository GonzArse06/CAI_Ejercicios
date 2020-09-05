using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio4:IEjercicios
    {
        string palabra1;
        string palabra2;
        string auxpalabra1;
        string auxpalabra2;

        string[] arraypalabra1;
        string[] arraypalabra2;
        bool mismaLongitud = false;
        public void Inicial()
        {
            palabra1 = Validaciones.pedirTexto("la primera palabra");
            palabra2 = Validaciones.pedirTexto("la segunda palabra");

            if (palabra1.Length == palabra2.Length)
                mismaLongitud = true;
            if (!mismaLongitud)
            {
                Console.WriteLine("Las palabras ingresadas no tienen la misma longitud.");

            }
            else
            { //myStr.ToCharArray(); ver esta opcion.
                arraypalabra1 = new string[palabra1.Length];
                arraypalabra2 = new string[palabra2.Length];
                for (int i = 0; i < palabra1.Length; i++)
                {
                    arraypalabra1[i] = palabra1.Substring(i, 1);
                    arraypalabra2[i] = palabra2.Substring(i, 1);
                }
                Array.Sort(arraypalabra1);
                Array.Sort(arraypalabra2);
                auxpalabra1 = string.Concat(arraypalabra1);
                auxpalabra2 = string.Concat(arraypalabra2);
                if (string.Compare(auxpalabra1, auxpalabra2) == 0)
                {
                    Console.WriteLine("La palabra " + palabra1 + " Es Anagrama de " + palabra2+"."); 
                }
                else
                {
                    Console.WriteLine("La palabra " + palabra1 + " NO es Anagrama de " + palabra2 + ".");
                }

            }
            

        }

    }
}
