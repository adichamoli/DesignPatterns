using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl
{
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }
}
