using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ConceretFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProducA1();
        }

        public IAbstractProductB CreateProductB()
        {
           return new ProductB1();
        }
    }
}
