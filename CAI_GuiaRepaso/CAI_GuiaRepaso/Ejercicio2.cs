using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio2:IEjercicios
    {
        const int min = 1;
        const int max = 999999;
        int numRegistroaux = 0;
        string resultado="";
        public void Inicial()
        {
            numRegistroaux = Validaciones.pedirNumero("numero de registro", min, max);
            string sregistro = numRegistroaux.ToString().Substring(3, 3);
            int numRegistro = int.Parse(sregistro);
            if (int.Parse(sregistro.Substring(0, 1)) == 0)
                numRegistro += 100;

            for (int i = min; i < numRegistro; i++)
            {
                int aux = 2;
                bool esPrimo = true;
                while (aux<i)
                {                    
                    if (i % aux == 0)
                        esPrimo = false;                    
                    aux++;
                }
                if (esPrimo && i % 3 == 0)
                    resultado = resultado + i + "- Es primo y divisible por 3\n";
                else if (i % 3 == 0)
                    resultado = resultado + i + "- Es divisible por 3\n";
                else if (esPrimo)
                    resultado = resultado + i + "- Es primo\n";
                else
                    resultado = resultado + i + "\n";
            }
            Console.WriteLine(resultado);

        }
    }
}
