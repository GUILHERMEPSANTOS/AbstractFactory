using AbstractFactory;
using AbstractFactory.Program.Factory;

Console.WriteLine("what do you prefer victorian(v) or modern(m) ?");
char input = Console.ReadKey().KeyChar;


FurnitureFactory factory;
switch (input)
{
    case 'v':
        factory = new VictorianFactory();
        break;

    case 'm':
        factory = new ModernFactory();
        break;

    default:
        throw new NotImplementedException();

}

var sofa = factory.CreateSofa();
var chair = factory.CreateChair();

Console.WriteLine("sofa: " + sofa.GetType().Name);
Console.WriteLine("chair: " + chair.GetType().Name);

Console.ReadKey();