using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SodnomovVM.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SodnomovVM.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int xx = 10;
            int yy = 9;
            int zz = 8;
            int rezz = DataService.Calc(xx, yy, zz);
            Console.WriteLine($"Значения выражения (10+9+8)*5 = {rezz}");
            Console.ReadLine();
            

        }
    }
}
