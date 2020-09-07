using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio20:IEjercicios
    {
        int numero;
        int primos;
        long factorial =1;
        bool esPrimo;
        public void Inicial()
        {
            numero = Validaciones.pedirNumero("un numero cualquiera", 0, 999999);
            primos = 0;
            for (int i = 1; i <= numero; i++)
            {
                factorial *=  i;

                int aux = 2;
                esPrimo = true;
                while (aux < i)
                {
                    if (i % aux == 0)
                        esPrimo = false;
                    aux++;
                }
                if (esPrimo && i>1)
                    primos++;
            }
                        
            Console.WriteLine("Hasta el numero {0} hay {1} numeros primos y el factorial es {2}", numero, primos, factorial);
        }
    }
}
