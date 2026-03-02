
using System.Windows;
using System.Windows.Media;

namespace FiguresFactoryLab.Models
{
    public abstract class Figure
    {
        public Color Color { get; set; }

        public abstract UIElement CreateUIElement(double size = 80);
    }
}
