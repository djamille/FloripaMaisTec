namespace BibliotecaPublica.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public int Codigo_Categoria { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
