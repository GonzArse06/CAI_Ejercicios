using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    static class Validaciones
    {
        public static int pedirNumero(string mensaje, int minimo, int max)
        {
            int num = 0;
            do
            {
                Console.WriteLine("Ingrese " + mensaje + ": ");
                if (!(int.TryParse(Console.ReadLine(), out num)))
                {
                    Console.WriteLine("Reingrese numero");
                }
                else if (num < minimo || num > max)
                {
                    Console.WriteLine("El numero debe estar entre " + minimo + " y " + max);
                }
            } while (num < minimo || num > max);
            return num;
        }
    }
}
