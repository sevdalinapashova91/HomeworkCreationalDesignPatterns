using FactoryPattern.Factories.Coffee.Enums;

namespace FactoryPattern.Factories.Coffee.Contracts
{
    public interface ICoffee
    {
        Size Size { get; set; }
        CoffeeType Type { get; set; }
        CoffeeKind Kind { get; set; }
        string Name { get; }
        string ToString();         
    }
}
