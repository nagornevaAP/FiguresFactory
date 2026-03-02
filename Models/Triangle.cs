
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FiguresFactoryLab.Models
{
    public class Triangle : Figure
    {
        public override UIElement CreateUIElement(double size = 80)
        {
            var polygon = new Polygon
            {
                Points = new PointCollection
            {
                new Point(size / 2, 0),
                new Point(0, size),
                new Point(size, size)
            },
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(10),
                Width = size,
                Height = size,
                Stretch = Stretch.Fill
            };
            return polygon;
        }
    }
}
