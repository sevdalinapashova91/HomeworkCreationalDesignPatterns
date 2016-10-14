using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Coffee;
namespace FactoryPattern.Factories
{
    using FactoryPattern.Factories.Coffee.Enums;

    class CafeAtTheCorner : IAbstractCoffeeFactory
    {
        private const string milk = "Milk Balkan",
                             sugar = "Sugar",
                             chocolade = "Shocolad na prahche";

        public const string Name = "Kafeto na chichoto na ugula do rabota";
        

        public SpecialCoffee MakeLate()
        {
            var ingredians = new List<string>
            {
                milk, sugar
            };
            return new SpecialCoffee(CoffeeType.Late, CoffeeKind.NesCafe, Size.Small, Name, ingredians);

        }

        public SpecialCoffee MakeMochaccino()
        {
            var ingredians = new List<string>
            {
                milk,
                sugar,
                chocolade
            };
            return new SpecialCoffee(CoffeeType.Mochaccino, CoffeeKind.NesCafe, Size.Small, Name, ingredians);
        }

        public RegularCoffee MakeRegularCoffee()
        {            
            return new RegularCoffee(CoffeeType.Regular, CoffeeKind.NesCafe, Size.Small, Name);
        }
    }
}
