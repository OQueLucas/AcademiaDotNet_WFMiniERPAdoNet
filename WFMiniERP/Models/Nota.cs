namespace WFMiniERP.Models
{
    internal class Nota
    {
        public int ID { get; set; }
        public DateTime? DataCompra { get; set; }
        public Cliente cliente { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
