namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KElement ks = new KElement();

            /*     int[] nums = { 1, 1, 2, 2, 2, 3 };
                 int k = 2;
                 int[] result = ks.TopKElement(nums, k);
                 foreach (int i in result)
                 {
                     Console.WriteLine(i);
                 }*/

            int target = 8;
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            SlidingWindow sW = new SlidingWindow();
            int n = sW.MinSubArrary(target, nums);

            Console.WriteLine(n);


        }
    }
}
