using DesignPatterns.FactoryMethod.Real.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Real
{
    internal class Order
    {
        public void Main() { 
            Pizzeria pizzeria = new ItalianPizzeria();
            pizzeria.OrderPizza("margherita");
        }
    }
}
