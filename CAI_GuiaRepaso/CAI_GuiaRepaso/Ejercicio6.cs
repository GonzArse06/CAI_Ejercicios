using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio6:IEjercicios
    {
        int num1, num2;

        public void Inicial()
        {
            num1 = Validaciones.pedirNumero(" el primer numero", 0, 99999999);
            num2 = Validaciones.pedirNumero(" el segundo numero", 0, 99999999);

            Console.WriteLine("Resultado de " + "("+num1+"+"+num2+")*(" + num1 + "-" + num2 + ")" + " es:" + (num1+num2)*(num1-num2));
        }
    }
}
