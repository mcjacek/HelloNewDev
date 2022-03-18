using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNewDev.Question
{
    public class StackHeapQuestion : IQuestion
    {
        public void Run()
        {
            Example_1();
            Example_2();
        }

        private int Example_1()
        {
            int x = 3;
            int y = 4;
            y = x;

            y = 4;

            return x;
        }

        private int Example_2()
        {
            MyInt x = new MyInt();
            x.MyValue = 3;

            MyInt y = new MyInt();
            y = x;
            y.MyValue = 4;

            return x.MyValue;
        }
    }

    public class MyInt
    {
        public int MyValue;
    }
}
