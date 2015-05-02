using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11_part_2
{
    public interface IFactory
    {
        IProductA CreatProductA();
        IProductB CreatProductB();
    }

    public interface IProductA
    {
    }

    public interface IProductB
    {
    }

    class ProductA1 : IProductA
    {
    }

    class ProductA2 : IProductA
    {
    }

    class ProductB1 : IProductB
    {
    }

    class ProductB2 : IProductB
    {
    }

    class Factory1 : IFactory
    {
        public IProductA CreatProductA()
        {
            return new ProductA1();
        }

        public IProductB CreatProductB()
        {
            return new ProductB1();
        }
    }

    class Factory2 : IFactory
    {
        public IProductA CreatProductA()
        {
            return new ProductA2();
        }

        public IProductB CreatProductB()
        {
            return new ProductB2();
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
        }
        private IProductA _productA;
        private IProductB _productB;

        public Client(IFactory factory)
        {
            _productA = factory.CreatProductA();
            _productB = factory.CreatProductB();
        }
    }
}
