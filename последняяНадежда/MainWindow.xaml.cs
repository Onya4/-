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
using DSirLib;

namespace последняяНадежда
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 cl1 = new Class1();
        private List<string> strings = new List<string>() { "A^B", "!A", "A and B or C" };
        public List<string> Strings { get { return strings; } set { strings = value;} }
        public MainWindow()
        {
            InitializeComponent();
            boxy.ItemsSource = Strings;
        }

        private void ent_Click(object sender, RoutedEventArgs e)
        {
            DateTime dttm = new DateTime();
            dttm = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            cl1.Ser(boxy.Text, dttm);
        }

        private void hist_Click(object sender, RoutedEventArgs e)
        {
            var hist = cl1.Des();
            list_hist.ItemsSource = hist;
        }
    }
}
