using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color8
{
    internal class TextColor : RGBColor
    {
        string _name;

        public TextColor(string name)
        {
            if (name[0] == '#')
            {
                HexNameToRGB(name);
                Name = name;
            }
            else
            {
                Name = name;
                NameToRGB(name);
            }
        }

        private void HexNameToRGB(string name)
        {
            Red = HexToNumber(name[1]) * 16 + HexToNumber(name[2]); 
            Green = HexToNumber(name[3]) * 16 + HexToNumber(name[4]);
            Blue = HexToNumber(name[5]) * 16 + HexToNumber(name[6]);
        }

        private void NameToRGB(string name)
        {
            switch (name.ToLower())
            {
                case "black":
                    Red = 0;
                    Blue = 0;
                    Green = 0;
                    break;
                case "white":
                    Red = 255;
                    Green = 255;
                    Blue = 255;
                    break;
                case "blue":
                    Red = 0;
                    Green = 0;
                    Blue = 255;
                    break;
                case "green":
                    Red = 0;
                    Green = 255;
                    Blue = 0;
                    break;
                case "red":
                    Red = 255;
                    Green = 0;
                    Blue = 0;
                    break;
                case "cyan":
                    Red = 0;
                    Green = 255;
                    Blue = 255;
                    break;
                case "magenta":
                    Red = 255;
                    Green = 0;
                    Blue = 255;
                    break;
                case "yellow":
                    Red = 255;
                    Green = 255;
                    Blue = 0;
                    break;
                default:
                    throw new Exception("Sadly this color is not implemented");
            }
        }

        public string Name { get => _name; set => _name = value; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
