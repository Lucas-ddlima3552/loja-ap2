using System.Security.Cryptography.X509Certificates;

public class Cliente
{
    public string NomeDoCliente { get; set; }
    public string IdentificadorCliente { get; set; }
    public string Endereco { get; set; }
    public string ContatoCliente { get; set; }
    public Cliente(string nome, string identificadorCliente, string endereco, string contatoCliente)
{
    if (string.IsNullOrWhiteSpace(nome))
    {
        throw new ArgumentException("Preencha o campo com seu nome completo.");
    }
    
    if (string.IsNullOrWhiteSpace(identificadorCliente)) 
    {
        throw new ArgumentException("Preencha com seu CPF.");
    }

    NomeDoCliente = nome;
    IdentificadorCliente = identificadorCliente;
    Endereco = endereco;
    ContatoCliente = contatoCliente;
}
        public string InformacoesCliente()
        {
            return $"Nome: {NomeDoCliente}\n" +
            $"CPF: {IdentificadorCliente}\n" +
            $"Telefone ou E-mail: {ContatoCliente}\n" +
            $"Endereço: {Endereco}";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine(InformacoesCliente());
        }
    }
