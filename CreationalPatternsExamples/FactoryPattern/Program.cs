namespace FactoryPattern
{
    using FactoryPattern.Factories;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var starBucksCafe = new StarBucks();
            Console.WriteLine(starBucksCafe.MakeLate().ToString());
            Console.WriteLine(starBucksCafe.MakeMochaccino().ToString());
            Console.WriteLine(starBucksCafe.MakeRegularCoffee().ToString());

            var costaCafe = new CostaCafe();
            Console.WriteLine(costaCafe.MakeLate().ToString());
            Console.WriteLine(costaCafe.MakeMochaccino().ToString());
            Console.WriteLine(costaCafe.MakeRegularCoffee().ToString());

            var cornerCafe = new CafeAtTheCorner();
            Console.WriteLine(cornerCafe.MakeLate().ToString());
            Console.WriteLine(cornerCafe.MakeMochaccino().ToString());
            Console.WriteLine(cornerCafe.ToString());
        }
    }
}
