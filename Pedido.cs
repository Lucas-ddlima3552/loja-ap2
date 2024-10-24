public class Pedido : ICarriavel
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; set; }
    public string Status { get; set; }
    public List<Produto> Produtos { get; set; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = "Em Processamento";
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} foi adicionado ao pedido.");
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
        Console.WriteLine($"Produto {produto.Nome} foi removido do carrinho.");
    }

    public decimal CalcularTotal()
{
    decimal total = 0;
    
    foreach (var produto in Produtos)
    {
        total += produto.CalcularPrecoFinal();
    }

    return total;
}
    public void FinalizarPedido()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Não é possível finalizar o pedido. Não há produtos no carrinho.");
            return;
        }

        Status = "Concluído";

        Console.WriteLine("Pedido finalizado com sucesso.");
        Console.WriteLine($"Total do pedido: {CalcularTotal():C}");
        Console.WriteLine($"Status do pedido: {Status}");
    }
}
