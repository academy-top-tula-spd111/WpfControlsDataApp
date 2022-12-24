using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WpfControlsDataApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }
        public bool Married { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age} Married: {Married}";
        }
    }
    public partial class MainWindow : Window
    {
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();

            List<string> itemsList = new List<string>() { "Один", "Два", "Три", "Четыре" };

            users = new List<User>()
            {
                new User() { Name = "Bob", Age = 23 },
                new User() { Name = "Tim", Age = 41 },
                new User() { Name = "Sam", Age = 19 },
                new User() { Name = "Joe", Age = 36 },
                new User() { Name = "Tom", Age = 29 },
                new User() { Name = "Ben", Age = 44 }
            };

            dataGrid.ItemsSource = users;

            //foreach (TreeViewItem item in tree.Items)
            //{
            //    item.Collapsed += TreeViewItem_Collapsed;
            //    item.Expanded += TreeViewItem_Expanded;
            //}


        }

        private void TreeViewItem_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Collapsed: " + (e.OriginalSource as TreeViewItem).Header.ToString());
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Expanded: " + (e.OriginalSource as TreeViewItem).Header.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string msg = "";
            //foreach (var item in users)
            //    msg += item.ToString() + "\n";
            //MessageBox.Show(msg);
        }
    }
}
