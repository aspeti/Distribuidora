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

namespace Distribuidora
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

        private void btnSalir_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCollapseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCollapseMenu.Visibility = Visibility.Hidden;
            btnOpenMenu.Visibility = Visibility.Visible;
            imgJogo.Visibility = Visibility.Hidden;
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCollapseMenu.Visibility = Visibility.Visible;
            btnOpenMenu.Visibility = Visibility.Hidden;
            imgJogo.Visibility = Visibility.Visible; 

        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null; 
            GridMain.Children.Clear(); //Limpia el grid principal de los user control
          
            switch(((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "itemHome":
                    usc = new UserControlHome();
                    break;

                case "itemCategoria":
                    usc = new Categorias.UserControlCategorias();
                    break;

            }
            if(usc!=null)
            {
                GridMain.Children.Add(usc);
            }

        }
    }
}
