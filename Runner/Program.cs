using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solutions;
using Utils;
using Sort;

namespace Runner
{
    class Program
    {
        public static void Main(string[] Args)
        {
            var outputUtils = new OutputUtils();
            //var selectSort = new SelectionSort();
            /*
            ISolution sol;
            // update the solution object for testing new solutions
            sol = new AddTwoNumbers();
            sol.run();
            */

            List<int> items = new List<int>() {
                1,2,3,4,1,1,1,1,5,5,10,12,1,3
            };

            List<int> items2 = new List<int>() {
                1
            };

            List<int> items3 = new List<int>() {
                9,8,7,6,5,4,3,2,1
            };

            var sorted = MergeSort.Sort(items);
            OutputUtils.Print(sorted);

            var sorted2 = MergeSort.Sort(items2);
            OutputUtils.Print(sorted2);

            var sorted3 = MergeSort.Sort(items3);
            OutputUtils.Print(sorted3);
        }
    }
}