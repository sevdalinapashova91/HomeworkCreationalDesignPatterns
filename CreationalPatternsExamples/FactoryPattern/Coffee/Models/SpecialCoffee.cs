namespace FactoryPattern.Coffee
{
    using FactoryPattern.Factories.Coffee.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SpecialCoffee : RegularCoffee
    {
        private IEnumerable<string> specialIngrediants;
        public IEnumerable<string> SpecialIngrediants
        {
            get { return this.specialIngrediants; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(Resources.ExceptionResource.IngredientsNullException);
                }
                this.specialIngrediants = value;
            }
        }

        public SpecialCoffee(CoffeeType type, CoffeeKind kind, Size size,string madeBy, IEnumerable<string> specialIngrediants) : 
            base(type, kind, size, madeBy)
        {
            this.SpecialIngrediants = specialIngrediants;
        }

        public override string ToString()
        {
            StringBuilder ingredients = new StringBuilder();
            ingredients.AppendLine(this.Name);
            ingredients.AppendLine(base.ToString());
            ingredients.AppendLine(string.Join(",", this.SpecialIngrediants));
            return ingredients.ToString();
        }
    }
}
