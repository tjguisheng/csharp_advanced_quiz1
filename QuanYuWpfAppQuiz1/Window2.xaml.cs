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

namespace QuanYuWpfAppQuiz1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void cldSelect_Click(object sender, RoutedEventArgs e)
        {
            string selectedDateTime = cldForm1.SelectedDate.Value.ToString();
            Window2Popup popup = new Window2Popup();
            popup.textSelectedDate.Text = selectedDateTime;
            popup.Show();
        }
    }
}
