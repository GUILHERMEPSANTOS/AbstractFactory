using System;

namespace AbstractFactory
{
    public abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();
        public abstract Sofa CreateSofa();
    }
}
