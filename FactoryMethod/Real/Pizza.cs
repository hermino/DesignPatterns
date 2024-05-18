using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Real
{
    internal abstract class Pizza: IPizza
    {
        public List<string> ingredients;
        public Pizza(List<string> ingredients)
        {
            this.ingredients = ingredients;
        }

        public abstract void AddInBox();
        public abstract void Cooking();
        public abstract void Cutting();
        public abstract void Delivery();
        public abstract void Prepare();
    }
}
