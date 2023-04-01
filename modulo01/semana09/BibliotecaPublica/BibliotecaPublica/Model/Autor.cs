namespace BibliotecaPublica.Model
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Nacionalidade { get; set; }

        public virtual ICollection<LivroAutor> Livros { get; set; }
    }
}
