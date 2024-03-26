using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_students_tigeeva
{
    public class Student
        {
            private string name;
            private double gpa;
            private int age;
            public string Name
        {
            get => name;
            set
            {
                if (value == "")
                    throw new NotNullString("Поле с именем не может быть пустым");
                else
                    name = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                    throw new NotNegativeDigit("Возраст не может быть отрицательным числом");
                else
                    age = value;
            }
        }
        public double GPA
        {
            get => gpa;
            set
            {
                if ((value < 0) || (value > 5))
                    throw new GPAException("Средний балл не может быть меньше нуля и больше 5");
                else
                    gpa = value;
            }
        }
    }
    }


