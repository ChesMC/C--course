using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TortTrain
{
    class Program
    {
        //Write T
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size/3);
            Turtle.Turn(180);
            Turtle.Move(size*2/3);
        }
            static void Main(string[] args)
        {
            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;

            WriteT(60);
            Turtle.X = 260;
            Turtle.Y = 200;
            WriteT(40);
            Turtle.X = 320;
            Turtle.Y = 200;
            WriteT(70);
            Turtle.X = 380;
            Turtle.Y = 200;

        }
    }
}
