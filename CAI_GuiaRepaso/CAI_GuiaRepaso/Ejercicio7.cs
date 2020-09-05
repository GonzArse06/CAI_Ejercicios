using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio7:IEjercicios
    {
        const int cant = 5;
        int[] numeros = new int[cant];
        public void Inicial()
        {
            for (int i = 0; i < cant; i++)
            {
                numeros[i] = Validaciones.pedirNumero("el numero " + i+1,0,99999999);
            }
            Array.Sort(numeros);
            Console.WriteLine("El menor numero: "+numeros[0] + ".\nEl intermedio numero: "+numeros[2] + ".\nEl mayor numero: " + numeros[4]);


        }
    }
}
