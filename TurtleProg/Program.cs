using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleProg
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GraphicsWindow.Title = "Turtle eat";
            GraphicsWindow.Width = 800;
            GraphicsWindow.Height = 700;
         
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            var xx = 100;
            var yy = 200;
            Shapes.Move(eat, xx, yy);
            Random rand = new Random();

            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X <= (xx + 15) && Turtle.X > (xx - 10) && Turtle.Y <= (yy + 15) && Turtle.Y > (yy-10))
                {
                    xx = rand.Next(GraphicsWindow.Width);
                    yy = rand.Next(GraphicsWindow.Height);
                    Shapes.Move(eat, xx, yy);
                    Turtle.Speed++;

                }
            }
        }
        
        private static void GraphicsWindow_KeyDown()
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if(GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "R")
            {
                Turtle.X = 400;
                Turtle.Y = 400;
            }
        }
    }
}
