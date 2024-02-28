using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere a altura do cilindro: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Insere o raio do cilindro: ");
            float r = float.Parse(Console.ReadLine());

            Console.WriteLine($"Volume do cilindro: { MathF.PI * MathF.Pow(r, 2) * a}");
        }
    }
}
