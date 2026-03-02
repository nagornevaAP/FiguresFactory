using FiguresFactoryLab.Factories;
using System.Windows;
using System.Windows.Controls;
using FiguresFactoryLab.Models;

namespace FiguresFactoryLab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void colorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorCombo.SelectedItem == null) return;

            figuresPanel.Children.Clear();

            string color = (colorCombo.SelectedItem as ComboBoxItem)?.Content.ToString();

            CircleCreator circleC;
            SquareCreator squareC;
            TriangleCreator triangleC;

            switch (color)
            {
                case "Красный":
                    circleC = new RedCircleCreator();
                    squareC = new RedSquareCreator();
                    triangleC = new RedTriangleCreator();
                    break;
                case "Синий":
                    circleC = new BlueCircleCreator();
                    squareC = new BlueSquareCreator();
                    triangleC = new BlueTriangleCreator();
                    break;
                case "Зелёный":
                    circleC = new GreenCircleCreator();
                    squareC = new GreenSquareCreator();
                    triangleC = new GreenTriangleCreator();
                    break;
                default: return;
            }

            figuresPanel.Children.Add(circleC.CreateCircle().CreateUIElement());
            figuresPanel.Children.Add(squareC.CreateSquare().CreateUIElement());
            figuresPanel.Children.Add(triangleC.CreateTriangle().CreateUIElement());
        }
    }
}