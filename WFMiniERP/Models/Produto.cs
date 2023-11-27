namespace WFMiniERP.Models
{
    internal class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Fornecedor fornecedor { get; set; }
    }
}
