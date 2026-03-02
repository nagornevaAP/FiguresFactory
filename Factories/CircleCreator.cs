
using System.Windows.Media;
using FiguresFactoryLab.Models;

namespace FiguresFactoryLab.Factories
{
    public abstract class CircleCreator
    {
        public abstract Circle CreateCircle();
    }

    public class RedCircleCreator : CircleCreator
    {
        public override Circle CreateCircle()
        {
            return new Circle { Color = Colors.Red };
        }
    }

    public class BlueCircleCreator : CircleCreator
    {
        public override Circle CreateCircle()
        {
            return new Circle { Color = Colors.Blue };
        }
    }

    public class GreenCircleCreator : CircleCreator
    {
        public override Circle CreateCircle()
        {
            return new Circle { Color = Colors.Green };
        }
    }
}
