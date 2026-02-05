using System.Collections.Generic;

namespace Biblioteca_ConsoleApp;

public  class Program
{
    public static void Main()
    {
        Libro Metafisica = new Libro("Metafisica", "Filosofia", 1, true);
        Libro Renacimiento = new Libro("Renacimiento", "Historia", 2, true);
        Libro Barroco = new Libro("Metafisica", "Música", 3, true);

        LinkedList<Libro> listaLibros = new LinkedList<Libro>();

        listaLibros.AddLast(Metafisica);
        listaLibros.AddLast(Renacimiento);
        listaLibros.AddLast(Barroco);

        int opcion = 10;

        do
        {
            Console.WriteLine("--- BIBLIOTECA ---\n");
            Console.WriteLine("Elija una opción:\n");
            Console.WriteLine("1.Mostrar Libros\n");
            Console.WriteLine("2.Agregar Libro\n");
            Console.WriteLine("3.Eliminar Libro\n");
            Console.WriteLine("0.Salir");

            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ingrese un número válido. Presione una tecla para continuar.");
            }

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("--- Lista de libros ---\n");

                    foreach (Libro n in listaLibros)
                    {
                        n.MostrarTitulo();
                    }
                    break;
                case 2:
                    Console.Write("Ingrese el título del libro: \n");
                    string nombreIngresado = Console.ReadLine();

                    Console.Write("Ingrese el género del libro: \n");
                    string generoIngresado = Console.ReadLine();

                    Console.Write("Ingrese el índice del libro: \n");
                    int indiceIngresado = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Indique si el libro está disponible (si / no): \n");
                    string disponibleString = Console.ReadLine();

                    bool disponibleBool = false;

                    if (disponibleString == "si")
                    {
                        disponibleBool = true;
                    }

                    Libro libroIngresado = new Libro(nombreIngresado, generoIngresado, indiceIngresado, disponibleBool);

                    listaLibros.AddLast(libroIngresado);
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    break;


            }

            

            Console.ReadKey();
            Console.Clear();
        }
        while (opcion != 0);
    }
}