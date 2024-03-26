using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_students_tigeeva
{
    public class GPAException: Exception
    {
        public GPAException(string message)
        : base(message) { }
    }
}
