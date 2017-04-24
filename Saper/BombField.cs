using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public class BombField
    {
        public int number { get; set; }
        public bool visible { get; set; }
        public bool isFlag { get; set; }

        public int x;
        public int y;

        public BombField(int x, int y)
        {
            number = 0;
            visible = false;
            isFlag = false;
            this.x = x;
            this.y = y;
        }

        public void setNumber(int number)
        {
            this.number = number;
        }

        public void setVisible(bool visible)
        {
            this.visible = visible;
        }

        public int getNumber()
        {
            return number;
        }
    }
}
