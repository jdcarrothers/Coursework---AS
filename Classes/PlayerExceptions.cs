using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_0._0.Classes
{
    public class PlayerExceptions : Exception
    {
        public PlayerExceptions(string message) : base(message)
        {
            MessageBox.Show(message);
        }
    }
}
