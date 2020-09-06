using System;
using System.Collections.Generic;
using System.Text;

namespace CAI_GuiaRepaso
{
    class Ejercicio12:IEjercicios
    {
        DateTime[] fechas = new DateTime[2];
        //TimeSpan span;
        int anios, meses, dias,mayor,menor;
        public void Inicial()
        {
            fechas[0] = Validaciones.PedirFecha("la primera fecha");
            fechas[1] = Validaciones.PedirFecha("la segunda fecha");

            if (fechas[0] > fechas[1])
            {
                mayor = 0;
                menor = 1;
            }
            else
            { 
                mayor = 1;
                menor = 0;
            }
            //span = fechas[mayor].Subtract(fechas[menor]);
            anios = fechas[mayor].Year - fechas[menor].Year;
            meses = fechas[mayor].Month - fechas[menor].Month;
            dias = fechas[mayor].Day - fechas[menor].Day;

            if (meses < 0)
            {
                anios -= 1;
                meses += 12;
            }
            if (dias < 0)
            {
                meses -= 1;
                dias += DateTime.DaysInMonth(fechas[mayor].Year, fechas[mayor].Month);
            }

            Console.WriteLine("La diferencia entre {3} y {4} es de {0} años, {1} meses, {2} dias.",anios,meses,dias,fechas[menor].ToShortDateString(),fechas[mayor].ToShortDateString());

        }
    }
}
