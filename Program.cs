        Loja loja = new Loja();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("");

        ProdutoFisico produtoFisico = new ProdutoFisico("Caneta", 1.99m, 0.5, 10, 21, 1, 10m, 2m, 100);
        loja.CadastrarProduto(produtoFisico);

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("");

        ProdutoDigital produtoDigital = new ProdutoDigital("Ebook programação", 29, "PDF", 76);
        loja.CadastrarProduto(produtoDigital);

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("");


        var cliente = new Cliente("João Silva", "123.456.789-00", "Rua Exemplo, 123", "joao@exemplo.com");
        loja.CadastrarCliente(cliente);

        var pedido = loja.CriarPedido(cliente);

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("");

        pedido.AdicionarProduto(produtoFisico);
        produtoFisico.ExibirInformacoes();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("");

        pedido.AdicionarProduto(produtoDigital);
        produtoDigital.ExibirInformacoes();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("");
        
        Console.WriteLine($"Total do pedido: {pedido.CalcularTotal():C}");
        pedido.FinalizarPedido();
        Console.WriteLine($"Status do pedido: {pedido.Status}");
        

        loja.ListarProdutos();
        loja.ListarClientes();
        loja.ConsultarProdutoPorCodigo("342655cd-ea15-479a-93d7-1bf315a36bf2");
        loja.ConsultarClientePorID("123.456.789-00");

