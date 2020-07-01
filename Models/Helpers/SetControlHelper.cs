using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers
{
    public static class SetControlHelper
    {
        public static void SetControl(Control parent, Control child)
        {
            parent.Controls.Clear();
            child.Dock = DockStyle.Fill;
            parent.Controls.Add(child);
        }

        public static void Clear(this Control parent)
        {
            if (parent.Controls.Count > 0)
                parent.Controls.Clear();
        }
    }
}
