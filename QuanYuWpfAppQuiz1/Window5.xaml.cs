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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
             
        }

        int count = 0;
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if(count%2==0)
            {
                btnAdd.Background = Brushes.Red;
                var subEven = new TreeViewItem();
                subEven.Header = count;
                trEven.Items.Add(subEven);
            }
            else
            {
                btnAdd.Background = Brushes.Blue;
                var subOdd = new TreeViewItem();
                subOdd.Header = count;
                trOdd.Items.Add(subOdd);
            }
        }
    }
}
