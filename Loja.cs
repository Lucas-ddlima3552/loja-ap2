using System;
using System.Collections.Generic;

public class Loja
{

    private List<Produto> Produtos { get; set; }
    private List<Cliente> Clientes { get; set; }
    private List<Pedido> Pedidos { get; set; }

    public Loja()
    {
        Produtos = new List<Produto>();
        Clientes = new List<Cliente>();
        Pedidos = new List<Pedido>();
    }


    public void CadastrarProduto(Produto produto)
    {
        if (produto == null)
        {
            Console.WriteLine("Produto não pode ser nulo.");
            return;
        }


        foreach (var i in Produtos)
        {
            if (i.Nome == produto.Nome)
            {
                Console.WriteLine($"O produto {produto.Nome} já está cadastrado.");
                return;
            }
        }

        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso.");
    }

    public Produto ConsultarProdutoPorCodigo(string codigo)
    {
        foreach (var produto in Produtos)
        {
            if (produto.Codigo.ToString() == codigo)
            {
                return produto;
            }
        }

        return null;
    }

    public void ListarProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Não há produtos cadastrados.");
            return;
        }

        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco:C}");
        }
    }


    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente == null)
        {
            Console.WriteLine("Cliente não pode ser nulo.");
            return;
        }

        foreach (var i in Clientes)
        {
            if (i.IdentificadorCliente == cliente.IdentificadorCliente)
            {
                Console.WriteLine($"O cliente {cliente.NomeDoCliente} já está cadastrado.");
                return;
            }
        }

        Clientes.Add(cliente);
        Console.WriteLine($"Cliente {cliente.NomeDoCliente} cadastrado com sucesso.");
    }

    public Cliente ConsultarClientePorID(string numeroIdentificacao)
    {
        foreach (var cliente in Clientes)
        {
            if (cliente.IdentificadorCliente == numeroIdentificacao)
            {
                return cliente; 
            }
        }

        return null; 
    }

    public void ListarClientes()
    {
        if (Clientes.Count == 0)
        {
            Console.WriteLine("Não há clientes cadastrados.");
            return;
        }

        foreach (var cliente in Clientes)
        {
            Console.WriteLine($"Cliente: {cliente.NomeDoCliente}, CPF: {cliente.IdentificadorCliente}");
        }
    }


    public Pedido CriarPedido(Cliente cliente)
    {
        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            return null;
        }

        bool clienteEncontrado = false;
        foreach (var i in Clientes)
        {
            if (i.IdentificadorCliente == cliente.IdentificadorCliente)
            {
                clienteEncontrado = true;
                break;
            }
        }

        if (!clienteEncontrado)
        {
            Console.WriteLine("Cliente não encontrado.");
            return null;
        }

        Pedido novoPedido = new Pedido(cliente);
        Pedidos.Add(novoPedido);
        Console.WriteLine($"Pedido criado para o cliente {cliente.NomeDoCliente}.");
        return novoPedido;
    }

    public void FinalizarPedido(Pedido pedido)
    {
        if (pedido == null)
        {
            Console.WriteLine("Pedido não encontrado.");
            return;
        }

        pedido.FinalizarPedido(); 
        Console.WriteLine("Pedido finalizado com sucesso.");
    }

    public void ListarPedidos()
    {
        if (Pedidos.Count == 0)
        {
            Console.WriteLine("Não há pedidos realizados.");
            return;
        }

        foreach (var pedido in Pedidos)
        {
            Console.WriteLine($"Pedido para {pedido.Cliente.NomeDoCliente}, Status: {pedido.Status}, Data: {pedido.DataPedido}");
        }
    }
}
