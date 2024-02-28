using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte bite = sbyte.MaxValue;
            short shorty = short.MaxValue;
            int inty = int.MaxValue;
            long longudo = long.MaxValue;

            byte bity = byte.MaxValue;
            ushort shortx = ushort.MaxValue;
            uint unity = uint.MaxValue;
            ulong longface = ulong.MaxValue;

            float floaty = float.MaxValue;
            double cheese = double.MaxValue;
            decimal dec = decimal.MaxValue;

            Console.WriteLine("These are MaxValues: ");
            Console.WriteLine($"This is sbyte: {bite}");
            Console.WriteLine($"This is short: {shorty}");
            Console.WriteLine($"This is int: {inty}");
            Console.WriteLine($"This is long: {longudo}");

            Console.WriteLine($"This is byte: {bity}");
            Console.WriteLine($"This is ushort: {shortx}");
            Console.WriteLine($"This is uint: {unity}");
            Console.WriteLine($"This is ulong: {longface}");

            Console.WriteLine($"This is float: {floaty}");
            Console.WriteLine($"This is double: {cheese}");
            Console.WriteLine($"This is decimal: {dec}");

            sbyte bite2 = sbyte.MinValue;
            short shorty2 = short.MinValue;
            int inty2 = int.MinValue;
            long longudo2 = long.MinValue;

            byte bity2 = byte.MinValue;
            ushort shortx2 = ushort.MinValue;
            uint unity2 = uint.MinValue;
            ulong longface2 = ulong.MinValue;

            float floaty2 = float.MinValue;
            double cheese2 = double.MinValue;
            decimal dec2 = decimal.MinValue;

            Console.WriteLine("\n These are MinValues: ");
            Console.WriteLine($"This is sbyte: {bite2}");
            Console.WriteLine($"This is short: {shorty2}");
            Console.WriteLine($"This is int: {inty2}");
            Console.WriteLine($"This is long: {longudo2}");

            Console.WriteLine($"This is byte: {bity2}");
            Console.WriteLine($"This is ushort: {shortx2}");
            Console.WriteLine($"This is uint: {unity2}");
            Console.WriteLine($"This is ulong: {longface2}");

            Console.WriteLine($"This is float: {floaty2}");
            Console.WriteLine($"This is double: {cheese2}");
            Console.WriteLine($"This is decimal: {dec2}");


            double x = double. NegativeInfinity;
            double y = double. PositiveInfinity;
            float z = float .NaN;

            Console.WriteLine("Special values: ");
            Console.WriteLine($"{x}");
            Console.WriteLine($"{y}");
            Console.WriteLine($"{z}");
        }
    }
}
