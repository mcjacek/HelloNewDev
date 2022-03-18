using HelloNewDev.Question;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HelloNewDev
{
    class Program
    {
        static void Main(string[] args)
        {
            var question = new FIXQuestion();
            question.Run();

        }
    }
}
