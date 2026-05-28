using Ejemplo_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static void Main(string[] args)
        {
            int opcion;
            do 
            {
                opcion = MostrarPantalla_SolicitarOpcionMenu();

                switch (opcion) 
                {
                    case 1:
                        MostrarPantalla_SolicitarNumero();
                        break;
                    case 2:
                        MostrarPantalla_SolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantalla_MaximoYMinimo();
                        break;
                    case 4:
                        MostrarPantalla_CalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantalla_Cantidad();
                        break;
                    case 6:
                        Mostrar_IniciarVariables();
                        break;
                    case 0:
                        Console.WriteLine("\nSaliendo");
                        opcion = -1;
                        break;
                    default:
                        Console.WriteLine("\nOpcion no valida");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                }

            } while (opcion!=-1);

        }


        #region metodos

        static int MostrarPantalla_SolicitarOpcionMenu() 
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio.");
            Console.WriteLine("5- Mostrar cantidad de números ingresados.");
            Console.WriteLine("6- Reiniciar variables.");
            Console.WriteLine("0- SALIR");
            Console.WriteLine("\n Seleccione un opcion");
            return opcion = Convert.ToInt32(Console.ReadLine());
        }
        static void Mostrar_IniciarVariables() 
        {
            Console.Clear();
            Console.WriteLine("Reiniciando las variables\n");
            servicio = new Servicio();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantalla_SolicitarNumero() 
        {
            Console.Clear();
            Console.WriteLine("\nIngresar un numero");
            servicio.RegistrarValor(Convert.ToInt32(Console.ReadLine()));
        }
        static void MostrarPantalla_SolicitarVariosNumeros() 
        {
            Console.Clear();
            Console.WriteLine("\nCuantos numeros desea ingresar");
            int cn = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cn; i++) 
            {
                Console.WriteLine($"\nIngresar el {i+1}º numero");
                servicio.RegistrarValor(Convert.ToInt32(Console.ReadLine()));
            }
        }
        static void MostrarPantalla_MaximoYMinimo()
        {
            Console.Clear();
            if (servicio.Contador == 0)
            {
                Console.WriteLine("No se registro nada");
            }
            else
            {
                Console.WriteLine($"Numero maximo: {servicio.Maximo}");
                Console.WriteLine($"Numero minimo: {servicio.Minimo}");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        
        static void MostrarPantalla_CalcularYMostrarPromedio() 
        {
            Console.Clear();
            if (servicio.Contador > 0)
            {
                Console.WriteLine($"\nPromedio: {servicio.CalcularPromedio()}");
            }
            else 
            {
                Console.WriteLine("No se ha ingresado ningun numero");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantalla_Cantidad() 
        {
            Console.Clear();
            if (servicio.Contador > 0)
            {
                Console.WriteLine($"\nCantidad: {servicio.Contador}");
            }
            else
            {
                Console.WriteLine("No se ha ingresado ningun numero");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        #endregion
    }
}
