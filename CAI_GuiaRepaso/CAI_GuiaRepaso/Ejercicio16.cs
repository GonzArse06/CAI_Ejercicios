using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio16:IEjercicios
    {
        int numero;
        //string numeroTexto;
        public void Inicial()
        {
            numero = Validaciones.pedirNumero("numero", 0, 9999999);
            Console.WriteLine("Numero ingresado: {0} - Tiene {1} digitos.", numero, numero.ToString().Length);
        }
    }
}
