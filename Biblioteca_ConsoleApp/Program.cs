namespace Biblioteca_ConsoleApp;

public static class Program
{
    public static void Main()
    {
        Libro Metafisica = new Libro("Metafisica", "Filosofia", 5, true);
        Libro Renacimiento = new Libro("Renacimiento", "Historia", 5, true);
        Libro Barroco = new Libro("Metafisica", "Música", 5, true);

        Libro[] listaLibros = { Metafisica, Renacimiento, Barroco };

        int opcion = 10;

        do
        {
            Console.WriteLine("--- BIBLIOTECA ---\n");
            Console.WriteLine("Elija una opción:\n");
            Console.WriteLine("1.Mostrar Libros");
            Console.WriteLine("0.Salir");

            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ingrese un número válido. Presione una tecla para continuar.");
            }

            if (opcion == 1)
            {
                Console.WriteLine("--- Lista de libros ---\n");

                for (int i = 0; i < listaLibros.Length; i++)
                {
                    listaLibros[i].MostrarTitulo();
                    opcion = 10;
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
        while (opcion != 0);
    }


}