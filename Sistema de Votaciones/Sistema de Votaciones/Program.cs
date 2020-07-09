using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Votaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -Cantidad de candidatos 4
               - Cantidad de votos 1,000, estos seran de forma aleatoria.
               - Los resultados se mostraran(Total de votos por candidatos, % de votos acumulados y Ordenados descendente).
               - El sistema es tipo consola en C#.
               -Datos candidato: Partido, Nombre completo, poscición a la que aspira(presidente).
               -Partidos: Fecha de fundacion(ficticia), Nombre completo y sigla */

            Random rand = new Random();
            int PPC = 0, PLR = 0, PNO = 0, PAA = 0;


            for (int i = 0; i < 1000; i++)
            {

                int numero = rand.Next(1, 5);

                switch (numero)
                {
                    case 1:
                        PPC++;
                        break;
                    case 2:
                        PLR++;
                        break;
                    case 3:
                        PNO++;
                        break;
                    case 4:
                        PAA++;
                        break;

                }
            }

            float[] ordenar = { PPC, PLR, PNO, PAA };
            float[] porciento = new float[4];
            Comparison<float> comparador = new Comparison<float>((numero1, numero2) => numero2.CompareTo(numero1));
            Array.Sort<float>(ordenar, comparador);

            for (int a = 0; a < 4; a++)
            {
                porciento[a] = ((ordenar[a] / 1000) * 100);
                
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Resultado de las votaciones:");
                Console.WriteLine("Puesto numero: {0} de 4", (i + 1));
                if (ordenar[i] == PPC)
                {
                    
                    Console.WriteLine("\nCandidato a presidente por el PARTIDO PALOMA COLORADA (PPC). Fundada el en 1970");
                    Console.WriteLine("Rafael Colorado Garcia");

                }
                else if (ordenar[i] == PLR)
                {

                    Console.WriteLine("\nCandidato a presidente por el PARTIDO LEON REVOLUCIONARIO (PLR). Fundada el en 1972");
                    Console.WriteLine("Escarllet Suriel Valdez");
                }
                else if (ordenar[i] == PNO)
                {
                    Console.WriteLine("\nCandidato a presidente por el PARTIDO NUTRIA GRANATE (PNG). Fundada el en 1980");
                    Console.WriteLine("Milagros Villanzuela Ramirez");
                }
                else if (ordenar[i] == PAA)
                {
                    Console.WriteLine("\n\nCandidato a presidente por el PARTIDO AGUILA AMARILLA (PAA). Fundada el en 1978");
                    Console.WriteLine("Matias Perez Perez");
                }
                Console.WriteLine("\nTotal de votos obtenidos " + ordenar[i]);
                Console.WriteLine("\nPorcentaje de votos acumulados: {0}% " , porciento[i]);
                Console.WriteLine("\n---------------------------------------------");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Finalizando programa...");
            Console.ReadKey();

        }
    }
}
