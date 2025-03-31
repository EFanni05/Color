using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color8
{
    internal class GrayScale : Color
    {
        double _scale;

        public GrayScale(double scale)
        {
            Scale = scale;
        }

        public double Scale { get => _scale; set => _scale = value; }

        public override int B()
        {
            return (int)Math.Round(Scale * 255);
        }

        public override int G()
        {
            return (int)Math.Round(Scale * 255);
        }

        public override int R()
        {
            return (int)Math.Round(Scale * 255);
        }
    }
}
