using Ejemplo_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static void Main(string[] args)
        {
            int opcion;

            do {
                opcion = MostrarPantalla_SolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantalla_SolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantalla_MostrarListaOrdenada();
                        break;
                    default:
                        Console.WriteLine("Saliendo");
                        opcion = -1;
                        break;
                }

            } while (opcion!=-1);
            Console.ReadKey();
                

        }


        #region Metodos
        static int MostrarPantalla_SolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("\tSeleccione una opcion:\n");
            Console.WriteLine("1- Registrar las notas de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("Otro- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantalla_SolicitarAlumnos()
        {
            Console.Clear();
            for (int i=1;i<=3;i++) 
            {
                Console.WriteLine($" Ingrese el nro de libreta y el nombre del {i}º alumno");
                servicio.RegistrarNombreYNumeroLibreta(Convert.ToInt32(Console.ReadLine()),Console.ReadLine());
            } 

        }

        static void MostrarPantalla_MostrarListaOrdenada() 
        {
            Console.Clear();
            Console.WriteLine("\n Nro de libreta   Nombre de alumno\n");
            Console.WriteLine($" {servicio.NroLibreta0} \t\t{servicio.Nombre0}");
            Console.WriteLine($" {servicio.NroLibreta1} \t\t{servicio.Nombre1}");
            Console.WriteLine($" {servicio.NroLibreta2} \t\t{servicio.Nombre2}");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }


        #endregion

    }
}
