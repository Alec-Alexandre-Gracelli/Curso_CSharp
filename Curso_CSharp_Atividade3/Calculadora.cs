namespace Curso_CSharp_Atividade3
{
    internal class Calculadora
    {
        //Versão 2 com membros de instância

        //public double Pi = 3.14;
        //public double Circunferencia(double r)
        //public double Volume(double r)

        //Versão 3 com método estático
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
