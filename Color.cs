using System;

namespace Color8
{
    internal abstract class Color : IEquatable<Color>
    {
        public abstract int R();
        public abstract int G();
        public abstract int B();

        public static char NumberToHex(int number)
        {
            if (number >= 0)
            {
                if (number >= 10)
                {
                    switch (number)
                    {
                        case 10: return 'A';
                        case 11: return 'B';
                        case 12: return 'C';
                        case 13: return 'D';
                        case 14: return 'E';
                        case 15: return 'F';
                        default: throw new Exception("The number is not correct");
                    }
                }
                else
                {
                    return Convert.ToChar(number);
                }
            }
            else 
            {
                throw new Exception("The number is not correct");
            }
        }

        public static int HexToNumber(char hex)
        {
            if (int.TryParse(hex.ToString(), out int number))
            {
                return number;
            }
            else 
            {
                switch (hex)
                {
                    case 'A': return 10;
                    case 'B': return 11;
                    case 'C': return 12;
                    case 'D': return 13;
                    case 'E': return 14;
                    case 'F': return 15;
                    default: throw new Exception("The input is not convertable");
                }
            }
        }

        public override string? ToString()
        {
            return $"#{NumberToHex(R() / 16)}{NumberToHex(R() % 16)}" +
                $"{NumberToHex(G() / 16)}{NumberToHex(G() % 16)}" +
                $"{NumberToHex(B() / 16)}{NumberToHex(B() % 16)}";
        }

        public bool Equals(Color? other)
        {
            if (R() == other.R() && G() == other.G() && B() == other.B())
            {
                return true;
            }
            return false;
        }
    }
}
