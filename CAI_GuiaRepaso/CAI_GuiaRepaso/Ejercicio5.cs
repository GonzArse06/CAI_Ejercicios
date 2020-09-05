using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio5:IEjercicios
    {
        int numero;
        string texto;
        string[] arraytexto;
        int longitud;
        public void Inicial()
        {
            numero = Validaciones.pedirNumero("numero", 0, 999999);
            texto = numero.ToString();
            longitud = texto.Length;
            arraytexto = new string[texto.Length];
            for (int i = 0; i < texto.Length; i++)
            {
                arraytexto[i] = texto.Substring(longitud - 1, 1);
                longitud--;
            }
            Console.WriteLine("El inverso de "+numero+" es "+ string.Concat(arraytexto));

        }
    }
}
