namespace FactoryPattern.Factories
{
    using FactoryPattern.Coffee;
    using FactoryPattern.Factories.Coffee.Enums;
    using System.Collections.Generic;

    public class CostaCafe : IAbstractCoffeeFactory
    {
        private const string milk = "MyDay milk",
            sugar = "Sugar syrop",
            spice = "cinemon",
            chocolade = "Chocolade syrop",
            additioning = "Marshmellows";                               

        public const string Name = "Costa Cafe";

        public SpecialCoffee MakeLate()
        {
            var ingredians = new List<string>
            {
                milk,
                sugar,
                spice
            };
            return new SpecialCoffee(CoffeeType.Late, CoffeeKind.Lavazza, Size.Normal, Name, ingredians);

        }

        public SpecialCoffee MakeMochaccino()
        {
            var ingredians = new List<string> { milk, sugar, chocolade, additioning };
            return new SpecialCoffee(CoffeeType.Mochaccino, CoffeeKind.Lavazza, Size.Normal, Name, ingredians);
        }

        public RegularCoffee MakeRegularCoffee()
        {
            return new RegularCoffee(CoffeeType.Regular, CoffeeKind.Lavazza, Size.Normal, Name);
        }
    }
}
