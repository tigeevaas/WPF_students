using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_students_tigeeva
{
    public partial class MainWindow : Window
    {

        public ObservableCollection<Student> students = new ObservableCollection<Student>
        {
            new Student { Name = "Анастасия", Age = 19, GPA = 4.9 },
            new Student { Name = "Михаил", Age = 20, GPA = 4.8 },
            new Student { Name = "Иван", Age = 21, GPA = 4.7 },
        };
        public MainWindow()
        {
            InitializeComponent();
            studentsDataGrid.ItemsSource = students;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudent = new AddStudentWindow(this);
            addStudent.Show();
            //students.Add(new Student { Name = "nastya" });

        }





    }


}