using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

using System.Windows.Forms;
using Application = System.Windows.Application;

namespace RectChangeColor
{
    /// <summary>
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void SetMainBackground(object sender, MouseButtonEventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            if (CD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Rectangle CurrentColor = e.Source as Rectangle;
                if (e.Source is Rectangle CurrentColor)
                {
                    if (CurrentColor.Name.Contains("Start"))
                    {
                        Application.Current.Resources["StartColorBackground"] = new SolidColorBrush(Color.FromArgb(CD.Color.A,
                                                                                                                   CD.Color.R,
                                                                                                                   CD.Color.G,
                                                                                                                   CD.Color.B));
                    }
                    else
                    {
                        Application.Current.Resources["EndColorBackground"] = new SolidColorBrush(Color.FromArgb(CD.Color.A,
                                                                                                                 CD.Color.R,
                                                                                                                 CD.Color.G,
                                                                                                                 CD.Color.B));
                    }
                }
            }

        }
    }
}
