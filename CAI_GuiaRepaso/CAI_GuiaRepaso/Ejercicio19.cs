using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio19:IEjercicios
    {
        int cantidad;
        string[] palabras;
        public void Inicial()
        {
            cantidad = Validaciones.pedirNumero("cantidad de palabras a ingresar",1,99999);
            palabras = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                palabras[i] = Validaciones.pedirTexto("palabra "+(i+1));
            }
            Console.WriteLine("Las palabras ingresadas tienen la siguiente longitud:");
            foreach (string a in palabras)
            {
                Console.WriteLine("{0} \t- {1} caracteres.",a,a.Length);
            }
        }
    }
}
