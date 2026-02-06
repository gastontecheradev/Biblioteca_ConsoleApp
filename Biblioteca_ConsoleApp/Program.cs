using System;
using System.Collections.Generic;

namespace Biblioteca_ConsoleApp;

public  class Program
{
    public static void Main()
    {
        Libro Metafisica = new Libro("Metafisica", "Filosofia", 1);
        Libro Renacimiento = new Libro("Renacimiento", "Historia", 2);
        Libro Barroco = new Libro("Barroco", "Música", 3);

        List<Libro> listaLibros = new List<Libro>();

        listaLibros.Add(Metafisica);
        listaLibros.Add(Renacimiento);
        listaLibros.Add(Barroco);

        int opcion = 10;

        while (opcion != 0)
        {
            Console.WriteLine("--- BIBLIOTECA ---\n");
            Console.WriteLine("Elija una opción:\n");
            Console.WriteLine("1.Mostrar Libros\n");
            Console.WriteLine("2.Agregar Libro\n");
            Console.WriteLine("3.Eliminar Libro\n");
            Console.WriteLine("0.Salir\n");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido. Presione una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("--- Lista de libros ---\n");

                    if (listaLibros.Count == 0)
                    {
                        Console.WriteLine("La lista de libros está vacia.");
                    }
                    else
                    {
                        foreach (Libro libro in listaLibros)
                        {
                            libro.MostrarTitulo();
                        }
                    }
                        

                    Console.WriteLine("\nPresione una tecla para continuar.");
                    break;

                case 2:
                    Console.Clear();
                    Console.Write("Ingrese el título del libro: ");
                    string titulo = Console.ReadLine();

                    Console.Write("\nIngrese el género del libro: ");
                    string categoria = Console.ReadLine();

                    Console.Write("\nIngrese el índice del libro: ");

                    if(!int.TryParse(Console.ReadLine(), out int indice) || indice <= 0)
                    {
                        Console.WriteLine("\nIngrese un número válido mayor que cero");
                        Console.ReadKey();
                        break;
                    }

                    if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(categoria))
                    {
                        Console.WriteLine("\nTítulo y categoria no pueden estar vacios");
                        Console.ReadKey();
                        break;
                    }

                    Libro libroIngresado = new Libro(titulo, categoria, indice);
                    listaLibros.Add(libroIngresado);

                    Console.WriteLine("\nLibro agregado correctamente.");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.Write("Ingrese el nombre del libro a borrar: ");
                    string borrarLibro = Console.ReadLine();

                    for (int i = listaLibros.Count -1; i >= 0; i--)
                    {
                        if (string.Equals(listaLibros[i].Titulo, borrarLibro, StringComparison.OrdinalIgnoreCase))
                        {
                            listaLibros.RemoveAt(i);
                        }
                    }
                    Console.WriteLine("\nPresione una tecla para continuar.");
                    break;

                default:
                    Console.WriteLine("Elija una opción válida");
                    Console.ReadKey();
                    break;
            }


            Console.ReadKey();
            Console.Clear();
        }
    }
}