public class ProdutoFisico : Produto
{
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }
    public string Categoria { get; set; }
    public int QuantidadeDisponivel { get; set; }


    public double Peso
    {
        get { return _peso; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("O peso deve ser um valor positivo.");
            _peso = value;
        }
    }

    private double _peso;

    public struct propDimensoes{
    
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }

    public void Dimensoes(double altura, double largura, double profundidade)
    {
        Altura = altura;
        Largura = largura;
        Profundidade = profundidade;
    }  

    public double altura
    {
        get { return altura; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("A altura deve ser um valor positivo.");
            altura = value;
        }
    }


    public double largura
    {
        get { return largura; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("A largura deve ser um valor positivo.");
            largura = value;
        }
    }


    public double profundidade
    {
        get { return profundidade; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("A profundidade deve ser um valor positivo.");
            profundidade = value;
        }
    }
    

        public double CalcularVolume()
        {
            return Altura * Largura * Profundidade;
        }
    
}


    public ProdutoFisico(string nome, decimal preco, double peso, double altura, double largura, double profundidade, decimal taxaImposto, decimal valorPorKilo, int quantidadeDisponivel)
        : base(nome, preco)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
        Largura = largura;
        Profundidade = profundidade;
        TaxaImposto = taxaImposto;
        ValorPorKilo = valorPorKilo;
        QuantidadeDisponivel = quantidadeDisponivel;
    }
    public void ReduzirEstoque(int quantidade)
    {
        if (QuantidadeDisponivel >= quantidade)
        {
            QuantidadeDisponivel -= quantidade;
        }
        else
        {
            Console.WriteLine($"Estoque insuficiente para o produto: {Nome}");
        }
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal valorImposto = Preco * (TaxaImposto / 100);
        decimal custoEnvio = (decimal)Peso * ValorPorKilo;

        return Preco + valorImposto + custoEnvio - ValorDesconto;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço base: {Preco:C}");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Dimensões: {Altura} cm x {Largura} cm x {Profundidade} cm");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Preço com tributos: {CalcularPrecoFinal()}");
        Console.WriteLine($"Quantidade Disponível: {QuantidadeDisponivel}");
    }

    
}

