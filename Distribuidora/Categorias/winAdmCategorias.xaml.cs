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
using System.Windows.Shapes;
using COMMON;
using BRL;
using System.Data;

namespace Distribuidora.Categorias
{
    /// <summary>
    /// Interaction logic for winAdmCategorias.xaml
    /// </summary>
    public partial class winAdmCategorias : Window
    {
        byte option = 0;
        Categoria cat;
        CategoriaBRL brl;


        public winAdmCategorias()
        {
            InitializeComponent();
        }

        void Habilitar(byte option)
        {
            btnGuardar.IsEnabled =   true;
            btnCancelar.IsEnabled =  true;
            txtCategoria.IsEnabled = true;

            btnInsertar.IsEnabled =  false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled =  false;

            

            this.option = option;
        }

        void DesHabilitar()
        {
            txtCategoria.Text = "";

            btnGuardar.IsEnabled =   false;
            btnCancelar.IsEnabled =  false;
            txtCategoria.IsEnabled = false;

            btnInsertar.IsEnabled =  true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled =  true;         
            
        }

        void LlenarDataGrid()
        {
            try
            {
                brl = new CategoriaBRL();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = brl.select().DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Hidden;


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            Habilitar(1);
            txtCategoria.Text = "";
            txtCategoria.Focus();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            Habilitar(2);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(dgvDatos.SelectedItem!= null && cat!= null)
            {
                if (MessageBox.Show("Esta realmente seguro de eliminar el registro?","Eliminar", MessageBoxButton.YesNo,MessageBoxImage.Question)== MessageBoxResult.Yes)
                {
                    brl = new CategoriaBRL(cat);
                    brl.delete();
                    LlenarDataGrid();
                    DesHabilitar();
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DesHabilitar();

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch(option)
            {
                case 1: //Insertar
                    //Creamos el Objeto
                    try
                    {
                        cat = new Categoria(txtCategoria.Text, 1);
                        brl = new CategoriaBRL(cat);
                        brl.insert();
                        MessageBox.Show("Categoria creada con extio..");
                        DesHabilitar();
                        LlenarDataGrid(); 

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }             
                    break;  
                case 2: // Modificar
                    try
                    {
                        cat.NombreCategoria = txtCategoria.Text;
                        brl = new CategoriaBRL(cat);
                        brl.update();
                        MessageBox.Show("Categoria actualizada con extio..");
                        DesHabilitar();
                        LlenarDataGrid();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;                    
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LlenarDataGrid();
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.SelectedItem !=null && dgvDatos.Items.Count>0)
            {                
                try
                {
                    DataRowView dataRow = (DataRowView)dgvDatos.SelectedItem; //lo que se ah seleccionado lo convertimos en una fila
                    byte id = byte.Parse(dataRow.Row.ItemArray[0].ToString());
                    brl = new CategoriaBRL();
                    cat = brl.Get(id);

                    if (cat != null)
                    {
                        txtCategoria.Text = cat.NombreCategoria;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*
        private void btnModificar_Click_1(object sender, RoutedEventArgs e)
        {

        }*/
    }
}
 