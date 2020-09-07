using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio18:IEjercicios
    {
        int dec;
        public void Inicial()
        {
            dec = Validaciones.pedirNumero("numero Decimal", 0, 9999999);
            Console.WriteLine("El numero decimal es: {0}\nBinario: {1}\nOctal: {2}\nHexadecimal: {3}",dec,Convert.ToString(dec, 2), Convert.ToString(dec, 8), Convert.ToString(dec, 16));
        }
    }
}
