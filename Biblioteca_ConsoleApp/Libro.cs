namespace Biblioteca_ConsoleApp
{
    public class Libro : ILibro
    {
        // Atributos
        private string titulo;
        private string categoria;
        private int indice;
        private bool disponible;

        // Metodos
        public void MostrarInfo()
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

        public void MostrarTitulo()
        {
            Console.WriteLine(titulo);
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

    interface ILibro
    {
        void MostrarInfo();
    }
}
