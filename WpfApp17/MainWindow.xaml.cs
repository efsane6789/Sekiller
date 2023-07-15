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

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Image image = (Image)button.Content;


            ImageViewer viewer = new ImageViewer(image.Source);
            viewer.Show();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    public partial class ImageViewer : Window
    {
        public ImageViewer(ImageSource imageSource)
        {
            //InitializeComponent();
            Image image = new Image();
            image.Source = imageSource;
            image.Stretch=System.Windows.Media.Stretch.Uniform;

            image.Width = 500;
            image.Height = 500;
            image.Margin=new Thickness(10);
            Grid grid = new Grid();
            grid.Children.Add(image);

        }
    }
}
