using System.Globalization;

namespace Curso_CSharp_Atividade4
{
    class Program
    {

        static void Main(string[] args)
        {
            //Versão 2 com membros de instância
            //Calculadora calc = new Calculadora();
            //double circ = calc.Circunferencia(raio);
            //double volume = Calculadora.Volume(raio);

            //Versão 3 com método estático
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi}");
        }
    }
}
