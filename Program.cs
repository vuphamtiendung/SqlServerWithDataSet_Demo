using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SqlServerWithDataSet_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSetClass data = new DataSetClass();
            data.DemoDataSet();
            ReadLine();
        }
    }
}
