﻿using System;
using System.Collections.Generic;
using System.Collections;
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
using WpfApp1.View_model;
using WpfApp1.Model;
using System.Data;
using System.Data.Entity;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Page1Menu.xaml
    /// </summary>
    public partial class Page2Menu : Page
    {
        private Usuario_emp dd = new Usuario_emp();
        private Cliente_ord kk = new Cliente_ord();


        public Page2Menu()
        {
            InitializeComponent();
            this.refresh();
            tbCargo.ItemsSource = dd.listar_cargos();

        }

        public void refresh()
        {
            MyDataGrid.ItemsSource = PerfilUser.Listar();
            MyDataGridCliente.ItemsSource = PerfilClientes.ListarClientes();

        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            string id = (string)((Button)sender).CommandParameter;

            //MainWindow.staticmain.Content = new EditarUsuario(id);
            EditarUsuario ventanaEditar = new EditarUsuario(id);
            ventanaEditar.Show();
                
           
            
        }

        private void btnBorrar(object sender, RoutedEventArgs e)
        {

            string id = (string)((Button)sender).CommandParameter;


            if (dd.DeleteUser(id) && dd.DeleteEmpleado(id))
            {
                MessageBox.Show("Registro correctamente eliminado");
            }
            else
            {
                MessageBox.Show("No fue eliminado exitosamente");

            }
        }


        private void btnBorrarCliente(object sender, RoutedEventArgs e)
        {
            string id = (string)((Button)sender).CommandParameter;

            if (dd.DeleteUser(id) && dd.DeleteEmpleado(id))
            {
                MessageBox.Show("Registro correctamente eliminado");
            }
            else
            {
                MessageBox.Show("No fue eliminado exitosamente");

            }
            refresh();
        }

        private void EditarCliente(object sender, RoutedEventArgs e)
        {
            string nitCliente = (string)((Button)sender).CommandParameter;

            //MainWindow.staticmain.Content = new EditarUsuario(id);
            EditarCliente ventanaEditar = new EditarCliente(nitCliente);
            ventanaEditar.Show();

            refresh();

        }


        private void btCrearUsuario_Click(object sender, RoutedEventArgs e)
        {


            Empleado emp12 = new Empleado();
            Usuarios usuariop = new Usuarios();

            if (tbNombre.Text != "" && tbApellido.Text != "" && tbDireccion.Text != "" && tbCorreo.Text != ""
                && tbCI.Text != "" && tbCargo.Text != "" && tbNomUsuario.Text != "" && tbPassword.Password != "")
            {

                emp12.Nombre = tbNombre.Text;
                emp12.ApellidoPaterno = tbApellido.Text;
                emp12.Direccion = tbDireccion.Text;
                emp12.Correo = tbCorreo.Text;
                emp12.Ci = tbCI.Text;
                emp12.Cargo = new Cargo((int)tbCargo.SelectedValue);
                usuariop.NombreUser = tbNomUsuario.Text;
                usuariop.Contrasena = tbPassword.Password;
                usuariop.Emp2 = new Empleado(tbCI.Text);

                if (dd.CreateEmpleado(emp12))
                {
                    if (dd.CreateUser(usuariop))
                    {
                        MessageBox.Show("Guardado Exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("Error de registro");
                }
                refresh();
                tbNombre.Text = "";
                tbDireccion.Text = "";
                tbCI.Text = "";
                tbApellido.Text = "";
                tbPassword.Password = "";
                tbTelefono.Text = "";
                tbNomUsuario.Text = "";
                tbCargo.SelectedItem= null;
                tbCorreo.Text = "";
            }
            else
            {
                MessageBox.Show("Llene todos los campos vacios");

            }
        }


        //private void Button_Click_Delete(object sender, RoutedEventArgs e)
        //{
        //    using (var context = new puntoDeVentaDB_testEntities())
        //    {

        //        DataRowView row = (DataRowView)MyDataGrid.SelectedItems[0];
        //        string jh = row["Nombre"].ToString();
        //        var std = context.empleado.Find(context.cargoLaboral);

        //        var sd = context.usuario.First<usuario>();


        //        context.empleado.Remove(std);
        //        context.usuario.Remove(sd);
        //        context.SaveChanges();
        //    }
        //}





        //private void EditCliente(object sender, RoutedEventArgs e)
        //{
        //    EditarCliente ventanaEditarCliente = new EditarCliente(nitCliente);
        //    ventanaEditarCliente.Show();
        //}

        private void btnBorraClienter(object sender, RoutedEventArgs e)
        {
         

            string nitCliente = (string)((Button)sender).CommandParameter;

            if (kk.DeleteClient(nitCliente))
            {
                MessageBox.Show("Registro correctamente eliminado");
            }
            else
            {
                MessageBox.Show("No fue eliminado exitosamente");

            }
            refresh();



        }

        private void btbusquedaCliente_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
