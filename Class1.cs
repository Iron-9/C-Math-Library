using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace MathLibrary
{
    public class Math
    {
        /*I didnt understand C# classes so i decided to make a library to learn them
         * There are definately some mistakes here and there but this was put together with essentially duct tape and dreams
         * Anyways, if youre reading this i hope you enjoy my spaghetti vomit
         */

        //Pi To a Ridiculously exact degree
        public const double pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799627495673518857527248912279381830119491298336733624406566430860213;
        public const double e = 2.718281828459045235360287471352662497757247093699959574966967627724076630353547594571382178525166427427466391932003059921817413596629043572900334295260;
        //Exponent Method
        public float pow(float x, float y)
        {
            float res = 1;
            for (int i = 0; i < y; i++)
            {
                res *= x;
            }
            return res;
        }
        //Rounding Method
        public float round(float x)
        {
            float res;
            int y = Convert.ToInt32(x);
            if (x < 0)
            {
                if (x - y >= 0.5)
                {
                    res = y + 1;
                }
                else if (y - x < 0.5)
                {
                    res = y;
                }
                else
                {
                    throw new ArgumentException("ERROR");
                }
                return res;
            }
            else
            {
                if (x + y <= -0.5)
                {
                    res = y - 1;
                }
                else if (y + x >= -0.5)
                {
                    res = y;
                }
                else
                {
                    throw new ArgumentException("ERROR");
                }
                return res;
            }
        }
        public float roundup(float x)
        {
            float res = 1;
            int y = Convert.ToInt32(x);
            if (x < 0)
            {
                res = y + 1;
                return res;
            }
            else
            {
                res = y - 1;
                return res;
            }
        }
        public float rounddown(float x)
        {
            int y = Convert.ToInt32(x);
            float res = y;
            return res;
        }
        public bool isnegative(float x)
        {
            return x < 0;
        }
        public bool ispositive(float x)
        {
            return x >= 0;
        }
        public float basicfactorial(float x)
        {
            if (x == 0 || x < 0)
            {
                throw new ArgumentException("Factorial cannot be negaative");
            }
            float res = 1;
            for (int i = 1; i <= x; i++)
            {
                res *= i;
            }
            return res;
        }
        public float abs(float x)
        {
            Math Obj = new Math();
            if (Obj.isnegative(x)) {
                return x * -1;
            } else
            {
                return x;
            }
        }
        public float sqrt(float x, float tolerance = 1e-10f)
        {
            if (x <  0)
            {
                throw new ArgumentException("Number cannot be negative");
            } else if (x == 0)
            {
                return 0;
            }
            float res = 1;
            float i = x / 2;

            while (true)
            {
                res = 0.5f * (i + x / i);
                if (Math.abs(x - i) < tolerance)
                {
                    break;
                }
                i = res;
            }
            return res;

        }
        public bool isprime(int x)
        {   
            if (x == 0 || x == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }  
            return true;
        }
        public string EasterEgg(float x)
        {
            if (x == 8)
            {
                return "Hello there. \n General Kenobi!";
            } else
            {
                throw new ArgumentException("Nerd Detected: Disposing of Hard Drive.");
            }

        }
        public float Mean(float[] x)
        {
            if (x == null ||  x.Length == 0)
            {
                throw new ArgumentException("The Array must not be null/empty");
            }
            float res = 1;
            foreach (float f in x)
            {
                res += f;
            }
            return res / x.Length;
        }
        public float Lowest(float[] x)
        {
            if (x == null || x.Length == 0)
            {
                throw new ArgumentException("The array must not be null/empty");
            }
            float res = x[0];
            foreach (float f in x)
            {
                if (f < res)
                {
                    res = f;
                }
            }
            return res;
        }
        public float Highest(float[] x)
        {
            if (x == null || x.Length == 0)
            {
                throw new ArgumentException("The array must not be null/empty");
            }
            float res = x[0];
            foreach (float f in x)
            {
                if (f > res)
                {
                    res = f;
                }   
            }
            return res;
        }
        public bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        public bool IsOdd(int x)
        {
            return x % 2 != 0;
        }
        public float RectArea(float x, float y)
        {
            return x * y;
        }
        public float TriArea(float x, float y)
        {
            return (x * y) / 2;
        }
        public float TrapArea(float x, float y, float z)
        {
            return (x + y) / 2 + z;
        }
        public double CirArea(float x)
        {
            return Math.pi * Math.pow((x / 2), 2);
        }
        public float RectVol(float x, float y, float z)
        {
            return x * y * z;
        }
        public float PirVol(float x, float y, float z)
        {
            return (x * y * z) / 3;
        }
        public float SphVol(float x)
        {
            return (4 / 3) * Math.pi * Math.pow((x / 2), 3);
        }
    }
}
