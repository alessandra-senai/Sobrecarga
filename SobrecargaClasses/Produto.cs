namespace SobrecargaClasses
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public double Quantidade { get; set; }

        public Produto()
        { }

        public Produto(int codigo)
        {
            Codigo = codigo;
        }

        public Produto(int codigo, string nome, string categoria, decimal preco, double quantidade)
        {
            Codigo = codigo;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}