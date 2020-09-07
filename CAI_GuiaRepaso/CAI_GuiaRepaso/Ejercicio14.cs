using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio14:IEjercicios
    {
        int numero;
        const int maximo = 100;
        public void Inicial()
        {
            numero = Validaciones.pedirNumero("numero para mostrar tabla de multiplicacion",1,maximo);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",numero,i,numero*i);
            }
        }
    }
}
