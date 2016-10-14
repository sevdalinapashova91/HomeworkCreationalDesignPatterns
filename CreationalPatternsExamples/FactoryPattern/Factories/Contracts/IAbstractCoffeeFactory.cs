namespace FactoryPattern.Factories
{
    using FactoryPattern.Coffee;

    public interface IAbstractCoffeeFactory
    {
        SpecialCoffee MakeLate();
        SpecialCoffee MakeMochaccino();
        RegularCoffee MakeRegularCoffee();
    }
}
