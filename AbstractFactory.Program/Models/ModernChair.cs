using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Program.Models
{
    public class ModernChair : Chair
    {
        public override bool HasLegs()
        {
            return false;
        }
    }
}
