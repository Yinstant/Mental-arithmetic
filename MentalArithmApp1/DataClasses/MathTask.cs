using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public class MathTask
    {
        int complexity;
        int mode;

        int num1, num2;
        int res;

        public MathTask(int complexity, int mode) {
            Random rand = new();
            this.complexity = complexity;
            this.mode = mode;
            if (mode == 1)
            {
                if (complexity == 1)
                {
                    num1 = rand.Next(1, 100);
                    num2 = rand.Next(1, 100);
                }
                else if (complexity == 2)
                {
                    num1 = rand.Next(100, 1000);
                    num2 = rand.Next(100, 1000);
                }
                else if (complexity == 3) {
                    num1 = rand.Next(1000, 10000);
                    num2 = rand.Next(1000, 10000);
                }
                res = num1 + num2;
            }
            else if (mode == 2)
            {
                if (complexity == 1)
                {
                    num1 = rand.Next(1, 100);
                    num2 = rand.Next(1, 100);
                }
                else if (complexity == 2)
                {
                    num1 = rand.Next(100, 1000);
                    num2 = rand.Next(100, 1000);
                }
                else if (complexity == 3)
                {
                    num1 = rand.Next(1000, 10000);
                    num2 = rand.Next(1000, 10000);
                }

                if (num2 > num1) {
                    int n = num2;
                    num2 = num1;
                    num1 = n;
                }

                res = num1 - num2;
            }
            else if (mode == 3)
            {
                if (complexity == 1)
                {
                    num1 = rand.Next(1, 10);
                    num2 = rand.Next(1, 10);
                }
                else if (complexity == 2)
                {
                    num1 = rand.Next(10, 100);
                    num2 = rand.Next(10, 100);
                }
                else if (complexity == 3)
                {
                    num1 = rand.Next(100, 1000);
                    num2 = rand.Next(100, 1000);
                }

                res = num1 * num2;
            }
            
            else if (mode == 4){
                if (complexity == 1)
                {
                    num2 = rand.Next(1, 10);
                    res = rand.Next(1, 10);
                }
                else if (complexity == 2)
                {
                    num2 = rand.Next(10, 100);
                    res = rand.Next(10, 100);
                }
                else if (complexity == 3)
                {
                    num2 = rand.Next(100, 1000);
                    res = rand.Next(100, 1000);
                }

                num1 = num2 * res;
            }
        }

        public override string ToString()
        {
            char ch = ' ';

            switch (mode) {
                case 1:
                    ch = '+';
                    break;
                case 2:
                    ch = '-';
                    break;
                case 3:
                    ch = 'x';
                    break;
                case 4:
                    ch = '/';
                    break;
            }

            return $"{num1} {ch} {num2} = ?";
        }

        public bool IsRight(int attempt) {
            return (attempt == res);
        }
    }
}
