using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_students_tigeeva
{
    public class NotNegativeDigit : Exception
    {
        public NotNegativeDigit(string message)
        : base(message) { }
    }
}
