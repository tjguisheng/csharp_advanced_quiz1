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

namespace QuanYuWpfAppQuiz1
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

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"fist name: {txtFName.Text}  lastname: {txtLName.Text} \n phone number: {txtPhone.Text}");
        }
    }
}
