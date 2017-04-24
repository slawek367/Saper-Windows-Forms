using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Saper
{
    public static class Input
    {
        public static void BombFieldClicked(int x, int y, Game game)
        {
            int xField = x / game.field.squarePixelSize;
            int yField = y / game.field.squarePixelSize;

            //Console.WriteLine("lol");
            //Console.WriteLine(xField + "   " + yField);

            if(!(yField >= game.field.yFields || xField >= game.field.xFields))
            {
                //field.bombBoard[xField, yField].visible = true;
                Console.WriteLine("Clicked: " + xField + " " + yField);
                game.DiscoverField(xField, yField);
                game.CheckWin();
            }
        }

        public static void BombFieldSetFlag(int x, int y, Game game)
        {
            int xField = x / game.field.squarePixelSize;
            int yField = y / game.field.squarePixelSize;

            if (!(yField >= game.field.yFields || xField >= game.field.xFields))
            {
                game.ChangeFlag(xField, yField);
            }
        }

        public static void MouseOnUnvisibleField(int x, int y, Game game)
        {
            int xField = x / game.field.squarePixelSize;
            int yField = y / game.field.squarePixelSize;

            //Console.WriteLine("lol");
            //Console.WriteLine(xField + "   " + yField);

            if (!(yField >= game.field.yFields || xField >= game.field.xFields))
            {
                game.mouseX = xField;
                game.mouseY = yField;
            }
        }
    }
}
