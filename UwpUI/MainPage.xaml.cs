using LibraryUWP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Employees employees = new Employees();// från XAML connection x:Binda //skapad classen här


        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)//lägga till
        { 
            try    //add 
            {
                employees.Add(new EmployeeModel(tbFirstName.Text, tbLastName.Text, cmbDepartment.SelectedItem.ToString()));
            }
            catch {  }
            finally      // 0 ställe
            {
                tbFirstName.Text = "";
                tbLastName.Text = "";
                cmbDepartment.SelectedIndex = -1; // -1 indicate no items selected
            }
        }

        private void btnDeleteEmployee_Click(object sender, RoutedEventArgs e)
        // inga paramentr= vem jag tabort i XAML(de bind)= ItemsSource="{x:Bind employees}"
        {
            try
            {           

            var button = sender as Button;  //tala om -sender object är knapp

            var employee = (EmployeeModel)button.DataContext;  
            //hämta DataContext= object for knappen, när knappen {Bind} till den object
            //hämta DataContext och lägga in variable

            employees.RemoveAt(employees.IndexOf(employee));/*/ ta bort--söka i List genom Index
                                                             * / *  0-rferere         0, 1,2,3,-index i Lista
                                                                 *  1-kkvkfkfkk
                                                                 *  2-skdkjkwej   */

            }
            catch { }
        }






    }
}
