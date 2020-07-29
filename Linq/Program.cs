using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var calificaciones = new List<int> { 10, 10, 5, 7, 7, 10, 8, 9, 10, 9, 9, 8 };
            // 1. Obtener las calificaciones mayores que 8 y mostrar la cantidad
            // 2. Obtener el cuadrado de cada término

            /* Enfoque imperativo -- ¿Cómo hacerlo? (paso a paso)
             * ALGORITMO*/
            Console.WriteLine("ENFOQUE IMPERATIVO");

            // 1
            int cont = 0, suma = 0;
            foreach (var calificacion in calificaciones)
            {
                if (calificacion > 8)
                {
                    cont++;
                    //Console.WriteLine(calificacion);
                }
                // 2
                Console.WriteLine("El cuadrado de " + calificacion + " es: " + calificacion * calificacion);

                // 3
                suma += calificacion;
            }
            // 1
            Console.WriteLine("La cantidad de notas mayores que 8 es: " + cont);

            // 3
            Console.WriteLine("La suma de todos los términos es: " + suma);

            /* Enfoque declarativo
             * FUNCIONAL -- Linq ¿Qué hacer? (Especificación del problema)*/
            Console.WriteLine("\nENFOQUE DECLARATIVO");

            // 1
            var result = calificaciones.Where(calificacion => calificacion > 8);
            foreach (int calificacion in result)
                Console.WriteLine(calificacion);
            Console.WriteLine("La cantidad de notas mayores que 8 es: " + result.Count());
            
            // 2
            var cuadrado = calificaciones.Select(calificacion => calificacion * calificacion);
            foreach (int calificacion in cuadrado)
                Console.WriteLine("El cuadrado de " + Math.Sqrt(calificacion) + " es: " + calificacion);
            
            // 3
            int resultado = calificaciones.Aggregate((acum, cal) => acum + cal);
            Console.WriteLine("La suma de los términos es: " + resultado);

            Console.ReadKey();
        }
    }
}
