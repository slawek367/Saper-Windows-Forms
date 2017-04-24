using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public class Field
    {
        public int xFields { get; set; }
        public int yFields { get; set; }
        public int squarePixelSize { get; set; }

        public BombField[,] bombBoard { get; set; }
        public int bombNumber { get; }
        public int visibleFields { get; set; }
        public int flagNumber {get; set;}

        public bool firstDiscover { get; set; }

        public Field(int xFields, int yFields, int squarePixelSize, int bombNumber)
        {
            this.xFields = xFields;
            this.yFields = yFields;
            this.squarePixelSize = squarePixelSize;
            this.bombNumber = bombNumber;
            this.visibleFields = 0;
            this.flagNumber = 0;
            this.firstDiscover = false;

            bombBoard = new BombField[xFields, yFields];

            
            for (int i = 0; i < xFields; i++)
            {
                for (int c = 0; c < yFields; c++)
                {
                    bombBoard[i, c] = new BombField(i,c);
                }
            }

            //GenerateBombs();
        }

        public void GenerateBombs(int firstBombX, int firstBombY)
        {
            Random rnd = new Random();
            int x;
            int y;

            
            for (int i = 0; i < bombNumber; i++)
            {
                do
                {
                    x = rnd.Next(this.xFields);
                    y = rnd.Next(this.yFields);
                } while (bombBoard[x, y].getNumber() == 9 || !((Math.Abs(firstBombX-x)) > 1 || (Math.Abs(firstBombY - y)) > 1) || (x==1&&y==1) || (x == 0 && y == 1) || (x == 1 && y == 0));

                for (int w = -1; w < 2; w++)
                {
                    for (int k = -1; k < 2; k++)
                    {
                        if (!(x + w < 0 || x + w >= this.xFields || y + k < 0 || y + k >= this.yFields || (x + w == 0 && y + k == 0) || (bombBoard[x + w, y + k].getNumber() == 9)))
                        {
                            bombBoard[x + w, y + k].setNumber(bombBoard[x + w, y + k].getNumber() + 1);
                        }
                    }
                }

                bombBoard[x, y].setNumber(9);

                Console.WriteLine(x + " " + y);
            }
            
        }

        public void AllFieldsVisible()
        {
            foreach (var item in bombBoard)
            {
                item.visible = true;
                item.isFlag = false;
            }
        }
    }
}
