using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoluPoker
{
    class Notifier : INotifier
    {
        public void Notify(string title, string text)
        {
            MessageBox.Show(text, title);
        }
    }
}
