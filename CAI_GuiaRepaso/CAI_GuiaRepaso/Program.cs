using System;

namespace CAI_GuiaRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numEjercicio = 20;
            const int minimo = 1;
            int numero = 0;
            numero = Validaciones.pedirNumero("numero de ejercicio", minimo, numEjercicio);
            switch (numero)
            {
                case 1:
                    Ejercicio1 a = new Ejercicio1();
                    a.Inicial();
                    break;
                case 2:
                    Ejercicio2 b = new Ejercicio2();
                    b.Inicial();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
