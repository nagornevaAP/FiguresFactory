using FiguresFactoryLab.Models;


namespace FiguresFactoryLab.Factories
{
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }
}
