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

namespace Interfaces
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

        private void BerekenOuderdom(IOuderdom ouderdom)
        {
            MessageBox.Show("Ouderdom: " + ouderdom.Ouderdom, ouderdom.Naam, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnPersoon_Click(object sender, RoutedEventArgs e)
        {
            Persoon eenPersoon = new Persoon("Levi", "Vertenten", 2002);
            BerekenOuderdom(eenPersoon);
        }

        private void btnBoom_Click(object sender, RoutedEventArgs e)
        {
            Boom eenBoom = new Boom(2010);
            BerekenOuderdom(eenBoom);
        }
    }
}
