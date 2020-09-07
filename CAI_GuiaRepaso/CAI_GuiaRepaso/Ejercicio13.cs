using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio13:IEjercicios
    {
        int factorial,resultado=1;
        const int max = 999999;
        public void Inicial()
        {
            factorial = Validaciones.pedirNumero("numero a factorear", 0, max);

            for (int i = 1; i <= factorial; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("El factorial de {0} es: {1}",factorial,resultado);
            
        }
    }
}
