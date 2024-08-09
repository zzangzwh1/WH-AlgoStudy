using System.Data.SqlTypes;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlidingWindow window = new SlidingWindow();
            int[] windoArr = { 100, 200, 300, 400, 700, 800, 1000, 200, 100, 50 };
            int n = 2;
            int findMaxNumofSubArr = window.FindMaxSubArr(windoArr, 2);
            Console.WriteLine($"MAX SUB ARRAY :{findMaxNumofSubArr}");

            int[] findSubArr = { 1, 4, 0, 0, 3, 10, 5 };
            int sum = 7;

            window.FindIndexOfSumArr(findSubArr, sum);


            Console.ReadLine();


        }
       
    }
}
