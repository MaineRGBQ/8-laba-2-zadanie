using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp40
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            scaleSlider.ValueChanged += ScaleSlider_ValueChanged;
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (pulseEllipse != null)
            {
                double newValue = e.NewValue;
                pulseEllipse.Width = 200 * newValue;
                pulseEllipse.Height = 200 * newValue;
            }
        }
    }
}