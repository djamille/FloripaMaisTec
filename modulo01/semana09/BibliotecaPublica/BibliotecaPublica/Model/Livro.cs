namespace BibliotecaPublica.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string ISSN { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Editora { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<LivroAutor> Autores { get; set; }
    }
}
