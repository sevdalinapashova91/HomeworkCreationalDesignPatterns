namespace FactoryPattern.Coffee
{
    using FactoryPattern.Factories.Coffee.Contracts;
    using FactoryPattern.Factories.Coffee.Enums;

    public class RegularCoffee : ICoffee
    {
        private string madeBy;
        public CoffeeKind Kind { get; set; }
        public Size Size { get; set; }
        public CoffeeType Type { get; set; }

        public string Name
        {
            get
            {
               return string.Format(Resources.CoffeeeResources.MadeBy, this.Type.ToString(), this.madeBy);
            }
        }
       
      
        public RegularCoffee(CoffeeType type, CoffeeKind kind, Size size, string madeBy)
        {
            this.Type = type;
            this.Kind = kind;
            this.Size = size;
            this.madeBy = madeBy;
        }

        public override string ToString()
        {
            return this.Kind.ToString() + " " + this.Size.ToString();
        }
    }
}
