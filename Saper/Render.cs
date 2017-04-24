using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace Saper
{
    public static class Render
    {
        public static void setPanelSize(int squarePixelSize, int xFields, int yFields, PictureBox picture)
        {
            picture.Size = new Size(squarePixelSize * xFields+1, squarePixelSize * yFields+1);
        }

        public static void Table(Field field, Graphics e, Pen Pen)
        {
            for (int i = 1; i <= field.xFields; i++)
            {
                e.DrawLine(Pen, field.yFields * field.squarePixelSize / field.xFields * i, 0, field.yFields * field.squarePixelSize / field.xFields * i, field.xFields * field.squarePixelSize);
            }

            for (int i = 1; i <= field.yFields; i++)
            {
                e.DrawLine(Pen, 0, field.xFields * field.squarePixelSize / field.yFields * i, field.yFields * field.squarePixelSize, field.xFields * field.squarePixelSize / field.yFields * i);
            }
        }

        public static void Square(Field field, int xPos, int yPos, Graphics e, Pen Pen, bool fill, bool mouseOnUnvisibleField)
        {

            Rectangle rectangle = new Rectangle(xPos * field.squarePixelSize, yPos * field.squarePixelSize, field.squarePixelSize, field.squarePixelSize);

            if (field.bombBoard[xPos, yPos].isFlag==true && mouseOnUnvisibleField == true)
            {
                e.FillRectangle(Brushes.Red, rectangle);
            }
            else if (field.bombBoard[xPos, yPos].isFlag == true && mouseOnUnvisibleField == false)
            {
                e.FillRectangle(Brushes.IndianRed, rectangle);
            }
            else if (fill==true && mouseOnUnvisibleField==true)
            {
                e.FillRectangle(Brushes.LightGray, rectangle);
            }
            else if(fill == true)
            {
                if (field.bombBoard[xPos, yPos].number == 9 && field.xFields * field.yFields - field.visibleFields == field.bombNumber) //win
                    e.FillRectangle(Brushes.LightGreen, rectangle);
                else if (field.bombBoard[xPos, yPos].number==9) //lost
                    e.FillRectangle(Brushes.Red, rectangle);
                else
                    e.FillRectangle(Brushes.AliceBlue, rectangle);
            }
                

            e.DrawRectangle(Pen, rectangle);
        }

        public static void Letter(Field field, int xPos, int yPos, Graphics e, string text)
        {
            Font drawFont = new Font("Arial", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            if (text == "9")
            {
                text = "*";
            }
            else if (text == "0")
                return;
            // Draw string to screen.
            e.DrawString(text, drawFont, drawBrush, xPos* field.squarePixelSize+3, yPos* field.squarePixelSize + 1);
            return;
        }

        public static void AllBombFields(Field field, Graphics e, Pen Pen, int mouseX, int mouseY)
        {
            foreach (var item in field.bombBoard)
            {
                if(item.visible == true)
                {
                    Square(field, item.x, item.y, e, Pen, true, false);
                    Letter(field, item.x, item.y, e, Convert.ToString(item.number));
                }
                if (item.visible == false && item.isFlag==true)
                {
                    Square(field, item.x, item.y, e, Pen, true, false);
                    Letter(field, item.x, item.y, e, "B");
                }
                else
                {
                    Square(field, item.x, item.y, e, Pen, false, false);
                }

            }

            if (mouseX >= 0 && mouseY >= 0)  
            {
                if(field.bombBoard[mouseX, mouseY].visible == false && field.bombBoard[mouseX, mouseY].isFlag == true) //if mouse is over unvisible field change color
                {
                    Square(field, mouseX, mouseY, e, Pen, true, true);
                    Letter(field, mouseX, mouseY, e, "B");
                }
                else if(field.bombBoard[mouseX, mouseY].visible == false)
                {
                    Square(field, mouseX, mouseY, e, Pen, true, true);
                }
            }
        }
    }
}
