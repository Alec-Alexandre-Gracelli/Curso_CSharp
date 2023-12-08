using Construtores__palavra_this__sobrecarga__encapsulamento;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício para executar (1): ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Produto();
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }
    }

    static string Produto()
    {
        Produto produto = new Produto("TV", 500.00, 10);

        produto.SetNome("TV 4k"); 

        Console.WriteLine(produto.GetNome());
        return produto.GetNome();
    }
}
