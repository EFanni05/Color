using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color8
{
    internal class BlackOrWhite : Color
    {
        bool _black;

        public BlackOrWhite(bool black)
        {
            Black = black;
        }

        public bool Black { get => _black; set => _black = value; }


        public override int B()
        {
            return _black ? 0 : 255;
        }

        public override int G()
        {
            return _black ? 0 : 255;
        }

        public override int R()
        {
            return _black ? 0 : 255;
        }
    }
}
