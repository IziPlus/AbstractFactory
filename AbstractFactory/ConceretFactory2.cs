using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ConceretFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProducA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
