﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    static class Validaciones
    {
        public static int pedirNumero(string mensaje, int minimo, int max)
        {
            int num = 0;
            do
            {
                Console.Write("Ingrese " + mensaje + ": ");
                if (!(int.TryParse(Console.ReadLine(), out num)))
                {
                    num = -1;
                    Console.WriteLine("Reingrese numero");
                }
                else if (num < minimo || num > max)
                {
                    Console.WriteLine("El numero debe estar entre " + minimo + " y " + max);
                }
            } while (num < minimo || num > max);
            return num;
        }
        public static string pedirTexto(string mensaje)
        {
            string texto = "";
            do
            {
                Console.Write("Ingrese " + mensaje + ": ");
                texto = Console.ReadLine();
                if (string.IsNullOrEmpty(texto))
                    Console.WriteLine("Por favor, ingrese un texto");
            } while (string.IsNullOrEmpty(texto));
            return texto;
        }
        public static string pedirContinuar()
        {
            string texto = "";
            bool estaOk = false;
            do
            {
                Console.Write("Ingrese: S para continuar o N para salir: ");
                texto = Console.ReadLine().ToUpper();
                if (string.IsNullOrEmpty(texto))
                    Console.WriteLine("Por favor, ingrese un texto");
                if (string.Compare(texto, "S") == 0)
                    estaOk = true;
                if (string.Compare(texto, "N") == 0)
                    estaOk = true;
                if(!estaOk)
                    Console.WriteLine("Por favor, ingrese S o N");
            } while (!estaOk);
            return texto;
        }
    }
}
