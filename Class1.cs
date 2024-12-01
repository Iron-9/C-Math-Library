using System;

namespace MathLibrary
{
    public class Math
    {
        /* I didn't understand C# classes, so I decided to make a library to learn them.
         * There are definitely some mistakes here and there, but this was put together with essentially duct tape and dreams.
         * Anyways, if you're reading this, I hope you enjoy my spaghetti vomit.
         */

        // Pi To a Ridiculously Exact Degree
        public const double Pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799627495673518857527248912279381830119491298336733624406566430860213;
        //First like 150 numbers of E
        public const double E = 2.718281828459045235360287471352662497757247093699959574966967627724076630353547594571382178525166427427466391932003059921817413596629043572900334295260;

        // Exponent Method
        public float Pow(float x, float y)
        {
            float res = 1;
            for (int i = 0; i < y; i++)
            {
                res *= x;
            }
            return res;
        }

        // Rounding Method
        public float Round(float x)
        {
            float res;
            int y = (int)x;
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
        //Rounding Method That Always rounds AWAY from ZERO (not up or down, works better in my monkey brain d:
        public float RoundUp(float x)
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
        //Opposite of RoundUp, Rounds closer to zero
        public float RoundDown(float x)
        {
            int y = Convert.ToInt32(x);
            float res = y;
            return res;
        }
        //Simple Check for if a num is below 0
        public bool IsNegative(float x)
        {
            return x < 0;
        }
        //Simple Check for if a num is 0 or higher (ik 0 isnt technically positive but its my code so)
        public bool IsPositive(float x)
        {
            return x >= 0;
        }
        //Returns the factorial of a factorial (takes int as i was too lazy to make it work with decimals)
        public float Factorial(int x)
        {
            if (x == 0 || x < 0)
            {
                throw new ArgumentException("Factorial cannot be negative");
            }
            float res = 1;
            for (int i = 1; i <= x; i++)
            {
                res *= i;
            }
            return res;
        }
        // Returns the Absoloute value of a float
        public float Abs(float x)
        {
            Math obj = new Math();
            if (obj.IsNegative(x))
            {
                return x * -1;
            }
            else
            {
                return x;
            }
        }
        //Returns the square root of a float
        public float Sqrt(float x, float tolerance = 1e-10f)
        {
            if (x < 0)
            {
                throw new ArgumentException("Number cannot be negative");
            }
            else if (x == 0)
            {
                return 0;
            }
            float res = 1;
            float i = x / 2;

            while (true)
            {
                res = 0.5f * (i + x / i);
                if (Math.Abs(x - i) < tolerance)
                {
                    break;
                }
                i = res;
            }
            return res;
        }
        //Check for if a number is prime
        public bool IsPrime(int x)
        {
            if (x == 0 || x == 1)
            {
                return false;
            }
            for (int i = 2; i <= Sqrt(x); i++)
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
            }
            else
            {
                throw new ArgumentException("Nerd Detected: Disposing of Hard Drive.");
            }
        }
        //Finds the average of an array
        public float Mean(float[] x)
        {
            if (x == null || x.Length == 0)
            {
                throw new ArgumentException("The array must not be null/empty");
            }
            float res = 1;
            foreach (float f in x)
            {
                res += f;
            }
            return res / x.Length;
        }
        //Finds the lowest num in array
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
        //Finds the highest num in array
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
        //check for if num is even or not
        public bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        //check for if num is odd or not
        public bool IsOdd(int x)
        {
            return x % 2 != 0;
        }
        //Calculates areas for Rectangles, Triangles, Trapezoids and Circles respectively
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
            return Math.PI * Math.Pow((x / 2), 2);
        }
        //Calculates the volume of Rectangles, Piramids and Spheres respectively
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
            return (4 / 3) * Math.PI * Math.Pow((x / 2), 3);
        }
    }
}
