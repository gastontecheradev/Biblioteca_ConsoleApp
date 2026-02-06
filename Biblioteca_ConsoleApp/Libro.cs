namespace Biblioteca_ConsoleApp
{
    public class Libro : ILibro
    {
        // Atributos
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public int Indice { get; set; }

        // Metodos
        public void MostrarInfo()
        {
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("Categoria: " + Categoria);
            Console.WriteLine("Indice: " + Indice);
        }

        public void MostrarTitulo()
        {
            Console.WriteLine(Titulo);
        }

        // Constructores
        public Libro()
        {
        }

        public Libro(string elTitulo, string laCategoria, int elIndice/*, bool estadoDisponible*/)
        {
            Titulo = elTitulo;
            Categoria = laCategoria;
            Indice = elIndice;
            //Disponible = estadoDisponible;
        }
    }

    interface ILibro
    {
        void MostrarInfo();
    }
}
