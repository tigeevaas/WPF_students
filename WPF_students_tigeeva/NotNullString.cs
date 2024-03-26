using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_students_tigeeva
{
    public class NotNullString: Exception
    {
        public NotNullString(string message)
        : base(message) { }
    }
}
