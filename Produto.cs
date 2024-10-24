public abstract class Produto
{
    public string Nome { get; set; }
    public Guid Codigo { get; set; }
    public decimal Preco { get; set; }
    public decimal TaxaImposto { get; set; }
    public decimal ValorPorKilo {get; set; } 
    public decimal ValorDesconto { get; set; } 

    protected Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
        Codigo = Guid.NewGuid();

    }

    public abstract decimal CalcularPrecoFinal();
    public abstract void ExibirInformacoes();

}