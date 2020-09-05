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
                    Console.WriteLine("Ingrese una fecha.");
                }
                else
                {
                    ok = true;
                }
            } while (!ok);
            TimeSpan span = hoy.Subtract(fecha);

            Console.WriteLine("La diferencia de fechas es "+ span.Days);
        }
    }
}
