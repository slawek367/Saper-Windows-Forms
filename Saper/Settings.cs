using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public class Settings
    {
        public int fieldXSize { get; set; }
        public int fieldYSize { get; set; }
        public int bombNumbers { get; set; }

        public Settings()
        {
            fieldXSize = 10;
            fieldYSize = 10;
            bombNumbers = 10;
        }

        public Settings(int fieldXSize, int fieldYSize, int bombNumbers)
        {
            this.fieldXSize = fieldXSize;
            this.fieldYSize = fieldYSize;
            this.bombNumbers = bombNumbers;
        }
    }
}
