using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        //SimplePizzaFactory factory;

        //public PizzaStore(SimplePizzaFactory factory)
        //{
        //    this.factory = factory;
        //}

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            //factory will decide which pizza will be created
            //pizza = factory.createPizza(type);
            pizza = createPizza(type);
            return pizza;
        }

        abstract Pizza createPizza(string type);
    }
}
