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

namespace Visual_CSharp
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringbuilder = new StringBuilder(textBox_main.Text);
            stringbuilder.Replace("kat", "katje");
            stringbuilder.Replace("hond", "hondje");
            stringbuilder.Replace("muis", "muisje");
            stringbuilder.Replace("de ", "het ");
            textBox_Copy.Text = stringbuilder.ToString();

        }
    }
}
