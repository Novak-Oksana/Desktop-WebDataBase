using DataBaseApi;
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

namespace WpfPerson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TableModel tableModel = new TableModel();

        public MainWindow()
        {
            InitializeComponent();
            tableModel.SetDataBase(SQLSwitch.SelectedItem.ToString());
        }

        private Person GetPerson()
        {
            int id = Int32.Parse(tb_id.Text);
            string fn = tb_firstname.Text;
            string ln = tb_lastname.Text;
            int age = Int32.Parse(tb_age.Text);
            return new Person(id, fn, ln, age);
        }

        private void btnread_Click(object sender, RoutedEventArgs e)
        {
            dataGridBD.ItemsSource = tableModel.Read();
            dataGridBD.Items.Refresh();
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            tableModel.Update(GetPerson());
            dataGridBD.ItemsSource = tableModel.Read();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tb_id.Text);
            tableModel.Delete(id);
            dataGridBD.ItemsSource = tableModel.Read();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            tableModel.Create(GetPerson());
            dataGridBD.ItemsSource = tableModel.Read();
        }

        private void SelectServer(object sender, SelectionChangedEventArgs e)
        {
            tableModel.SetDataBase(SQLSwitch.SelectedItem.ToString());
            dataGridBD.ItemsSource = null;
        }

    }
}
