using FiguresFactoryLab.Factories;

using System.Windows;
using System.Windows.Controls;

namespace FiguresFactoryLab
{
    public partial class MainWindow : Window
    {
        private IFigureFactory _currentFactory;

        public MainWindow()
        {
            InitializeComponent();
            colorCombo.SelectedIndex = 0; 
        }

        private void colorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorCombo.SelectedItem == null) return;

            string colorName = (colorCombo.SelectedItem as ComboBoxItem)?.Content.ToString();

            // СТАРЫЙ switch — работает в C# 7.3
            switch (colorName)
            {
                case "Красный":
                    _currentFactory = new RedFactory();
                    break;
                case "Синий":
                    _currentFactory = new BlueFactory();
                    break;
                case "Зелёный":
                    _currentFactory = new GreenFactory();
                    break;
                default:
                    _currentFactory = null;
                    return;
            }

            if (_currentFactory == null) return;

            figuresPanel.Children.Clear();

            figuresPanel.Children.Add(_currentFactory.CreateCircle().CreateUIElement());
            figuresPanel.Children.Add(_currentFactory.CreateSquare().CreateUIElement());
            figuresPanel.Children.Add(_currentFactory.CreateTriangle().CreateUIElement());
        }
    }
}