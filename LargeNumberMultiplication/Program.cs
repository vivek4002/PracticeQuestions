using System;

namespace LargeNumberMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiplier= new LargeMultiplier();
            Console.WriteLine(multiplier.multiply("654154154151454545415415454","63516561563156316545145146514654"));
        }
    }
}
