namespace FactoryPattern.Factories
{
    using FactoryPattern.Coffee;
    using FactoryPattern.Factories.Coffee.Enums;
    using System.Collections.Generic;

    public class StarBucks : IAbstractCoffeeFactory
    {
        private const string milk = "L.B Milk",
            sugar = "Sugar syrop",
            cream = "Cream foam",
            spice = "Cacao",
            chocolade = "Chocolade syrop";
        private static readonly string[] additionings = { "Cookie", "Chocolade Powder" };

        public const string Name = "Starbucks";

        public SpecialCoffee MakeLate()
        {
            var ingredians = new List<string>
            {
                milk,
                sugar,
                additionings[1],
                cream
            };

            return new SpecialCoffee(CoffeeType.Late, CoffeeKind.Bourbon, Size.Large, Name, ingredians);

        }

        public SpecialCoffee MakeMochaccino()
        {
            var ingredians = new List<string>
            {
                milk,
                sugar,
                spice,
                cream,
                additionings[1],
            };
            return new SpecialCoffee(CoffeeType.Mochaccino, CoffeeKind.Bourbon, Size.Large, Name, ingredians);
        }

        public RegularCoffee MakeRegularCoffee()
        {
            return new RegularCoffee(CoffeeType.Regular, CoffeeKind.Bourbon, Size.Large, Name);
        }
    }
}
