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
            IEjercicios practica = new Ejercicio1();

            bool esCaso; 
            string seguir = "n";
            do
            {
                numero = Validaciones.pedirNumero("numero de ejercicio", minimo, numEjercicio);
                esCaso = false;
                switch (numero)
                {

                    case 1:
                        practica = new Ejercicio1();
                        esCaso = true;
                        break;
                    case 2:
                        practica = new Ejercicio2();
                        esCaso = true;
                        break;
                    case 3:
                        practica = new Ejercicio3();
                        esCaso = true;
                        break;
                    case 4:
                        practica = new Ejercicio4();
                        esCaso = true;
                        break;
                    case 5:
                        practica = new Ejercicio5();
                        esCaso = true;
                        break;
                    case 6:
                        practica = new Ejercicio6();
                        esCaso = true;
                        break;
                    case 7:
                        practica = new Ejercicio7();
                        esCaso = true;
                        break;
                    case 8:
                        practica = new Ejercicio8();
                        esCaso = true;
                        break;
                    default:
                        break;
                }
                if (esCaso)
                { 
                    practica.Inicial();
                    Console.ReadKey();
                }
                seguir = Validaciones.pedirContinuar();
                               
            } while (seguir == "S");
        }
    }
}
