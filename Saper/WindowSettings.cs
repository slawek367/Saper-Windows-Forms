using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    abstract class WindowSettings
    {
        public void SetColor(ref Form1 obj)
        {
            obj.BackColor = System.Drawing.Color.Azure;
        }
    }
}
