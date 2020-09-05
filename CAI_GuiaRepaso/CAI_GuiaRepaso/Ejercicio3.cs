using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio3:IEjercicios
    {
        string palabra;
        string alrevez;
        public void Inicial()
        {
            palabra = Validaciones.pedirTexto("Palabra");
            int longitud = palabra.Length;
            int contador = longitud;
            for (int i = 0;  i < longitud; i++) //Invierto palabra
            {
                alrevez = alrevez + palabra.Substring(contador-1,1);
                contador--;
            }
            if (string.Compare(palabra, alrevez) == 0) //comparo texto original e invertido
            {
                Console.WriteLine("La palabra " + palabra + " es Palíndromo.");
            }
            else
            {
                Console.WriteLine("La palabra " + palabra + " NO es Palíndromo.");

            }

        }
    }
}
