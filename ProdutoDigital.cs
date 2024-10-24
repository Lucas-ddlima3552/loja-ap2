public class ProdutoDigital : Produto
{
    public double TamanhoArquivo { get; set; }
    public string Formato { get; set; }
    public string Categoria { get; set; }
    public ProdutoDigital(string nome, decimal preco, string formato, double tamanhoArquivo):base(nome, preco)
    {
        if(tamanhoArquivo <= 0)
        {
            throw new ArgumentException("O arquivo deve possuir um valor positivo!");
        }

        Nome = nome;
        Preco = preco;
        Formato = formato;
        TamanhoArquivo = tamanhoArquivo;
        
    }
    

    public override decimal CalcularPrecoFinal()
    {
        decimal desconto = Preco * ValorDesconto / 100;
        return Preco - desconto;
    }


    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine($"Tamanho do Arquivo: {TamanhoArquivo} MB");
        Console.WriteLine($"Formato: {Formato}");
        Console.WriteLine("Compras de produtos digitais não possuem impostos ou custos de envio!");
    }
}