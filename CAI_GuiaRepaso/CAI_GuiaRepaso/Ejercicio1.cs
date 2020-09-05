using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio1
    {
        const int min = 1;
        const int max = 999999;
        int numRegistroaux = 0;
        public void Inicial()
        { 
            numRegistroaux = Validaciones.pedirNumero("numero de registro",min,max);
            string sregistro = numRegistroaux.ToString().Substring(3, 3);
            int numRegistro = int.Parse(sregistro);
            if (int.Parse(sregistro.Substring(0, 1)) == 0)
                numRegistro += 100;

            for (int i = min; i < numRegistro; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine(i + "FooBar");
                else if(i % 3 == 0)
                    Console.WriteLine(i + "Foo");
                else if (i % 5 == 0)
                    Console.WriteLine(i + "Bar");                 
                else
                    Console.WriteLine(i);
            }
            
        }

    }
}
