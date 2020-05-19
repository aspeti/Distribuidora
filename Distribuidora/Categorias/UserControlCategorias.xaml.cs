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

namespace Distribuidora.Categorias
{
    /// <summary>
    /// Interaction logic for UserControlCategorias.xaml
    /// </summary>
    public partial class UserControlCategorias : UserControl
    {
        public UserControlCategorias()
        {
            InitializeComponent();
        }

        private void btnAdministrar_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void cardAdmiCategorias_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Categorias.winAdmCategorias win = new winAdmCategorias();
            win.Show();
        }
    }
}
