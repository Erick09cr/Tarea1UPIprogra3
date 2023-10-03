using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1UPIprogra3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int opcion = 0;
            do  //primero ejecuta y luego evalua
            {
                Console.Clear();
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio1(); break;//Console.WriteLine("Marco opcion 1"); Console.ReadLine(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 4);


        }

        // 1 camisa sin descuento
        // 2 a 5 camisas con 15% descuento
        // mas de 5 camisas con 20%
        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad;

            Console.WriteLine("Digite el precio: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");
            }
            else

            if (cantidad > 1 && cantidad <= 5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.15f)) * cantidad)} con descuento de 15%");
            }
            else

            if (cantidad > 5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.20f)) * cantidad)} con descuento de 20%");
            }

            Console.ReadLine();


        }
        public static void Ejercicio2()
        {

            int carnet;
            string nombre;
            double quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3;

           
            Console.WriteLine("Ingrese el carnet del estudiante:");
            carnet = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del estudiante:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la calificación del Quiz 1:");
            quiz1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Quiz 2:");
            quiz2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Quiz 3:");
            quiz3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación de la Tarea 1:");
            tarea1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación de la Tarea 2:");
            tarea2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación de la Tarea 3:");
            tarea3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Examen 1:");
            examen1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Examen 2:");
            examen2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Examen 3:");
            examen3 = Convert.ToDouble(Console.ReadLine());

            
            double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
            double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.30;
            double porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 0.45;

            
            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            
            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices);
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas);
            Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes);
            Console.WriteLine("Promedio Final: " + promedioFinal);
            Console.WriteLine("Condición: " + condicion);

            Console.ReadLine();
        }




        public static void Ejercicio3()
        {

            
            Console.Write("Ingrese la cantidad de artículos que desea comprar: ");
            int cantidadArticulos = Convert.ToInt32(Console.ReadLine());

            double precioPorArticulo;

            if (cantidadArticulos <= 10)
            {

                precioPorArticulo = 20.0;

            }
            else
            {

                precioPorArticulo = 15.0;

            }

           
            double total = cantidadArticulos * precioPorArticulo;

            
            Console.WriteLine($"Precio por artículo: ${precioPorArticulo}");
            Console.WriteLine($"Total a pagar: ${total}");

            Console.ReadLine();

        }
    }
    
}
