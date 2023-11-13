using Construtores__palavra_this__sobrecarga__encapsulamento;
using System.Globalization;

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

        static void Produto()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Produto produto = new Produto(nome, preco);

            Produto produto1 = new Produto();

            Produto produto2 = new Produto 
            { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 20 
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}
