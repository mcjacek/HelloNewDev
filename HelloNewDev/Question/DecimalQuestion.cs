using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNewDev.Question
{
    public class DecimalQuestion : IQuestion
    {
        public void Run()
        {
            Double();
            Decimal();
        }

        private void Double()
        {
            double number = 0.1;
            double result_1 = 10 * number;
            double result_2 = 0;

            foreach(int index in Enumerable.Range(0, 10))
            {
                result_2 += number;
            }

            var isEqual = result_1 == result_2;
         }

        private void Decimal()
        {
            decimal number = 0.1m;
            decimal result_1 = 10 * number;
            decimal result_2 = 0;

            foreach (int index in Enumerable.Range(0, 10))
            {
                result_2 += number;
            }

            var isEqual = result_1 == result_2;
        }
    }
}
