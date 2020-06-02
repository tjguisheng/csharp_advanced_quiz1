using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private ObservableCollection<Student> studentsInBox = new ObservableCollection<Student>();
        private List<Student> students = new List<Student>();

        public Window4()
        {
            InitializeComponent();

            students.Add(new Student(1, "AA"));
            students.Add(new Student(2, "BB"));
            students.Add(new Student(3, "CC"));
            students.Add(new Student(4, "DD"));
            students.Add(new Student(5, "EE"));

            lstBox.ItemsSource = studentsInBox;
        }

        private void btlAdd_Click(object sender, RoutedEventArgs e)
        {
            int studentId = Convert.ToInt32(txtBox.Text);
            if (studentsInBox.Any(s => s.id == studentId))
            {
                MessageBox.Show("User is already in the list");
            }
            else
            {
                studentsInBox.Add(students.Find(s => s.id == studentId));
            }
        }
    }
}
