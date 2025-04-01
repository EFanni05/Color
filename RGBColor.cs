using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color8
{
    internal class RGBColor : Color
    {
        int _red;
        int _green;
        int _blue;

        public RGBColor()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public RGBColor(Color color)
        {
            Red = color.R();
            Green = color.G();
            Blue = color.B();
        }

        public RGBColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Red { get => _red; set => _red = value; }
        public int Green { get => _green; set => _green = value; }
        public int Blue { get => _blue; set => _blue = value; }

        public override int R()
        {
            if (Red >= 0 && Red <= 255)
            {
                return Red;
            }
            else
            {
                throw new Exception("Red value is not correct");
            }
        }
        public override int G()
        {
            if (Green >= 0 && Green <= 255)
            {
                return Green;
            }
            else
            {
                throw new Exception("Green value is not correct");
            }
        }
        public override int B()
        {
            if (Blue >= 0 && Blue <= 255)
            {
                return Blue;
            }
            else
            {
                throw new Exception("Blue value is not correct");
            }
        }
    }
}
