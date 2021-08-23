using System;

namespace RegexPatternMakingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PinCode Check!");
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validatePinCode("442406"));

        }
    }
}
