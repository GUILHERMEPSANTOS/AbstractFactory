using AbstractFactory;


namespace AbstractFactory.Program.Models
{
    public class VictorianChair : Chair
    {
        public override bool HasLegs()
        {
            return true;
        }
    }
}
