using System.Globalization;

namespace Curso_CSharp_Atividade3
{
    //Versão 1
    // métodos na própria classe do programa
    // ...Nota: dentro de um método estático você não pode chamar membros de instância da mesma classe.

    class Program
    {
        static void Main(string[] args)
        {
            //Versão 1
            // métodos na própria classe do programa
            // ...Nota: dentro de um método estático você não pode chamar membros de instância da mesma classe.

            //static double Pi = 3.14;

            //static void Main(string[] args)
            //{
            //    Console.Write("Entre o valor do raio: ");
            //    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    double circ = Circunferencia(raio);
            //    double volume = Volume(raio);

            //    Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            //    Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            //    Console.WriteLine($"Valor de PI: {Pi}");
            //}

            //static double Circunferencia(double r)
            //{
            //    return 2.0 * Pi * r;
            //}

            //static double Volume(double r)
            //{
            //    return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
            //}


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