using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
using static System.Net.Mime.MediaTypeNames;

namespace WPF_students_tigeeva
{
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
            InitializeComponent();
        }


        private void Button_open_click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int age = int.Parse(textBoxAge.Text);
                double gpa = double.Parse(textBoxGPA.Text);
                //MessageBox.Show("test");
                MainWindow mainWindow = new MainWindow();
                _mainWindow.students.Add(new Student { Name = name, Age = age, GPA = gpa });
                this.Hide();

            }
            catch (FormatException ex)
            {
                MessageBoxResult result;
                string messageBoxText = $"Неправильно введены данные - {ex.Message}";
                string caption = "Ошибка ввода данных";
                MessageBoxButton button = MessageBoxButton.OKCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                //MessageBox.Show($"возникло исключение {ex.Message}", icon);

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            catch (NotNullString ex)
            {
                MessageBoxResult result;
                string messageBoxText = $"Неправильно введены данные - {ex.Message}";
                string caption = "Ошибка ввода данных";
                MessageBoxButton button = MessageBoxButton.OKCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                //MessageBox.Show($"возникло исключение {ex.Message}", icon);

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            catch (NotNegativeDigit ex)
            {
                MessageBoxResult result;
                string messageBoxText = $"Неправильно введены данные - {ex.Message}";
                string caption = "Ошибка ввода данных";
                MessageBoxButton button = MessageBoxButton.OKCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                //MessageBox.Show($"возникло исключение {ex.Message}", icon);

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            catch (GPAException ex)
            {
                MessageBoxResult result;
                string messageBoxText = $"Неправильно введены данные - {ex.Message}";
                string caption = "Ошибка ввода данных";
                MessageBoxButton button = MessageBoxButton.OKCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                //MessageBox.Show($"возникло исключение {ex.Message}", icon);

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }


        }

        private MainWindow _mainWindow;
        public AddStudentWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

    }
}
