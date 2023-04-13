namespace Models
{
    public class Book
    {
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $">>> DADOS DO LIVRO <<<\nID: {ID}\nTítulo: {Title}\nAutor: {Author}\n";
        }
    }
}