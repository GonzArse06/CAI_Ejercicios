using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio8:IEjercicios
    {
        DateTime hoy = DateTime.Now;
        DateTime fecha;
        bool ok = false;
        public void Inicial()
        {
            do
            {
                if (!DateTime.TryParse(Validaciones.pedirTexto("fecha"), out fecha))
                {
                    Console.WriteLine("Error. Ingresar una fecha: ");
                }
                else if (hoy < fecha)
                {
                    Console.WriteLine("No puede ingresar una fecha mayor a hoy. Reingrese.");
                } 
                else
                {
                    ok = true;
                }
            } while (!ok);
            TimeSpan span = hoy.Subtract(fecha);

            Console.WriteLine("La diferencia de fechas es {0} dias.", + span.Days);
        }
    }
}
