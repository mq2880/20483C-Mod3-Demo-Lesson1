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
struct Coffee
{
    public string Name { get; set; }
    public string Bean { get; set; }
    public string CountryOfOrigin { get; set; }
    public int Strength { get; set; }
}
namespace EventsAndXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Coffee coffee1 = new Coffee();
            coffee1.Name = "Fourth Coffee Quencher";
            coffee1.CountryOfOrigin = "Indonesia";
            coffee1.Strength = 3;

            Console.WriteLine("Name: {0}", coffee1.Name);
            Console.WriteLine("Country of Origin: {0}", coffee1.CountryOfOrigin);
            Console.WriteLine("Strength: {0}", coffee1.Strength);
        }

        private void btnGetTime_Click(object sender, RoutedEventArgs e)
        {
            lblShowTime.Content = DateTime.Now.ToLongTimeString();
        }
    }
}
