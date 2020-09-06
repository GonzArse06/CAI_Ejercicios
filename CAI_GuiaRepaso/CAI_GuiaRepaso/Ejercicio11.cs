using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CAI_GuiaRepaso
{
    class Ejercicio11:IEjercicios
    {
        const int cant = 3;
        int numero=0;
        string[] arraycadena = new string[cant];
        string cadena;
        int nom = -1, ape=-1, edad=-1;
        Regex reg = new Regex(@"^[0-9]\d{2}$");

        public void Inicial()
        {
            cadena = Validaciones.pedirTexto("nombre, apellido y edad en cualquier orden");
            arraycadena = cadena.Split(' ');
            for (int i = 0; i<cant; i++)
            {
                if (int.TryParse((arraycadena[i]),out numero))
                {
                    edad = i;
                }
                else if (nom == -1)
                {
                    nom = i;
                }
                else
                {
                    ape = i;
                }
            }
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}",arraycadena[nom],arraycadena[ape],arraycadena[edad]);
            

        }
    }
}
