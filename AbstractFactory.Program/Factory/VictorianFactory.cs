using AbstractFactory.Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Program.Factory
{
    public class VictorianFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();
        }

        public override Sofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
