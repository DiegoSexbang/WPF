using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Controladores;
using System.Data.SqlClient;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controladores.CProducto datoproducto = new Controladores.CProducto();
        private Boolean Estado=false;
        public MainWindow()
        {
            InitializeComponent();
            CargarCombo();
        }

        



        protected Boolean ValidarDatos(String CodProd, String NomProd)
        {
           
            Boolean validado = false;
            if (CodProd == "")
            {
               
                MessageBox.Show("Código de Producto Mal Ingresado");
                txtCodigo.Focus();
                validado = false;
            }
            else
                validado = true;
            
            if (NomProd == "")
            {
                MessageBox.Show("Nombre de Producto Mal Ingresado");
                txtProducto.Focus();
                validado = false;
            }
            else
                validado = true;
            
            return validado;
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            Boolean datosvalidados = false;
            datosvalidados = ValidarDatos(txtCodigo.Text, txtProducto.Text);
            if (datosvalidados == true)
            {
                if (Estado == false)
                {
                    try
                    {
                        datoproducto.Agregar(Convert.ToInt32(txtCodigo.Text), txtProducto.Text);
                        Estado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        datoproducto.Actualizar(Convert.ToInt32(txtCodigo.Text), txtProducto.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCodigo.Text != "")
                {
                    if (datoproducto.BuscarExistente(Convert.ToInt32(txtCodigo.Text)) == true)
                    {

                        if (MessageBox.Show("Confirma que Desea Eliminar este Registro", "Confirmacion de Eliminacion", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            datoproducto.Eliminar(Convert.ToInt32(txtCodigo.Text));
                            Limpiar_Formulario();
                            MessageBox.Show("**** Registro Eliminado ****");
                        }
                        else
                            MessageBox.Show("Se ha cancelado la eliminación del registro");

                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar_Formulario()
        {
            txtCodigo.IsEnabled= true;
            Estado = false;
            txtCodigo.Text = "";
            txtProducto.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void txtCodigo_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                try
                {
                    if (datoproducto.BuscarExistente(Convert.ToInt32(txtCodigo.Text)) == true)
                    {
                        CargarProducto();
                        Estado = true;
                    }
                    else
                        txtProducto.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void CargarProducto()
        {
            txtProducto.Text = datoproducto.NomProducto;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar_Formulario();
        }

        private void Listado_Click(object sender, RoutedEventArgs e)
        {
            ListadoProductos formlistado = new ListadoProductos();
            formlistado.Owner = this;
            formlistado.ShowDialog();
        }
        public void CargarCombo()
        {
            SqlDataReader dat;
            ComboBoxItem item= new ComboBoxItem();
            dat = datoproducto.RecuperarTabla();
            cmbProductos.ItemsSource = dat;
            cmbProductos.DisplayMemberPath = "PRODNOMBRE";
            cmbProductos.SelectedValuePath = "PRODCODIGO";
           /* while (dat.Read())
            {
                cmbProductos.Items.Add(dat.GetString(1));
              
            }*/
           
            
             
        }

        private void cmbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void cmbProductos_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(cmbProductos.SelectedValue));
        }
       
    }

}
