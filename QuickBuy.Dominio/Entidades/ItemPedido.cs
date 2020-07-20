namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("No fue identificado cuál es la referencia del producto");

            if (Quantidade == 0)
                AdicionarCritica("La cantidad no fue informada");
        }
    }
}
