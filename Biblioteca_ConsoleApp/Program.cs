using System;
using System.Linq;

namespace Biblioteca;

public static class Program
{
    public static void Main()
    {
        Libro Metafisica = new Libro("Metafísica", "Filosofía", 5, true);

        Metafisica.mostrarInfo();
    }

    // Clase
    public class Libro
    {
        // Atributos
        private string titulo;
        private string categoria;
        private int indice;
        private bool disponible;

        // Metodos
        public void mostrarInfo()
        {
            Console.WriteLine("Titulo: " + titulo);
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine("Indice: " + indice);

            if (disponible)
            {
                Console.WriteLine("Está disponible");
            }
            else
            {
                Console.WriteLine("No está disponible");
            }
        }

        // Constructor
        public Libro(string elTitulo, string laCategoria, int elIndice, bool estadoDisponible)
        {
            titulo = elTitulo;
            categoria = laCategoria;
            indice = elIndice;
            disponible = estadoDisponible;
        }

    }
}