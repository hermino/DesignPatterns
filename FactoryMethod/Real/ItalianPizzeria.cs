using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Real
{
    internal class ItalianPizzeria : Pizzeria
    {
        protected override IPizza CreatePizza(string type)
        {
            throw new NotImplementedException();
        }
    }
}
