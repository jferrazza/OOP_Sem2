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

namespace ToDo
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

        private void btnTask_Click(object sender, RoutedEventArgs e)
        {
            lstTask.Items.Add(txTask.Text);

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            lstTask.Items.Remove(lstTask.SelectedItem);
        }

        private void txTask_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txTask_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void txTask_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int n1 = r.Next((int)100);
            int n2 = r.Next((int)100);
            txTask.Margin = new Thickness(n1, n2, n1 + txTask.Width, n2 + txTask.Height);

        }
    }
}
