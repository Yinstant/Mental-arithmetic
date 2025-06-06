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
            this.complexity = complexity;
            this.mode = mode;

            if (mode == 1)
            {
                SetAddition();
            }
            else if (mode == 2)
            {
                SetSubstraction();
            }
            else if (mode == 3)
            {
                SetMultiplication();
            }
            
            else if (mode == 4){
                SetDivision();
            }
        }

        private void SetAddition() {
            Random rand = new();

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
            res = num1 + num2;
        }

        private void SetSubstraction()
        {
            Random rand = new();

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

            if (num2 > num1)
            {
                Swap(ref num2, ref num1);
            }

            res = num1 - num2;
        }

        private void SetMultiplication()
        {
            Random rand = new();

            if (complexity == 1)
            {
                num1 = rand.Next(1, 10);
                num2 = rand.Next(1, 10);
            }
            else if (complexity == 2)
            {
                num1 = rand.Next(10, 100);
                num2 = rand.Next(1, 10);
            }
            else if (complexity == 3)
            {
                num1 = rand.Next(10, 100);
                num2 = rand.Next(10, 100);
            }

            res = num1 * num2;
        }

        private void SetDivision()
        {
            Random rand = new();

            if (complexity == 1)
            {
                num2 = rand.Next(1, 10);
                res = rand.Next(1, 10);
            }
            else if (complexity == 2)
            {
                num2 = rand.Next(10, 100);
                res = rand.Next(1, 10);

                if (rand.Next(1, 3) == 1) {
                    Swap(ref num2, ref res);
                }
            }
            else if (complexity == 3)
            {
                num2 = rand.Next(10, 100);
                res = rand.Next(10, 100);
            }

            num1 = num2 * res;
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

        private void Swap(ref int a, ref int b) {
            int c = b;
            b = a;
            a = c;
        }
    }
}
