using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio17:IEjercicios
    {
        const int cantidad = 5;
        const double maxsueldo = 10000000;
        double[] sueldo = new double[cantidad];
        string[] nombre = new string[cantidad];
        double maximo = 0;
        int posmaximo;
        public void Inicial()
        {
            for (int i = 0; i < cantidad; i++)
            {
                nombre[i] = Validaciones.pedirTexto("nombre del empleado "+(i+1));
                sueldo[i] = Validaciones.pedirDouble("sueldo", 0, maxsueldo);
            
                if (sueldo[i] > maximo)
                {
                    maximo = sueldo[i];
                    posmaximo=i;
                }
            }
            Console.WriteLine("El emplado con mayor sueldo es - Nombre: {0}, Sueldo: {1}",nombre[posmaximo],sueldo[posmaximo]);
            //solo muestro un resultado. No considero si hay mas de un empleado con el sueldo maximo.
        }
    }
}
