using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using PersonLibrary;

namespace PersonObject
{


    public partial class MainWindow : Window
    {

        private Person person = new Person() {Age = 11, LastName = "Last Name", FirstName = "First Name"};

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Grd.DataContext = person;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            person.Age = 22;
            person.LastName = "Last Name xxxx";
            person.FirstName = "First Name yyyyy";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("person.Age = " + person.Age.ToString() + " " + "person.LastName = " + person.LastName + " " +
                            "person.FirstName = " + person.FirstName);
        }
    }
}