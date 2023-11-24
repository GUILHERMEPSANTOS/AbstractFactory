using AbstractFactory.Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Program.Factory
{
    public class ModernFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
           return new ModernChair();
        }

        public override Sofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
