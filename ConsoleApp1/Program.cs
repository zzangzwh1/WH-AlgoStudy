namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KElement ks = new KElement();

            int[] nums = { 1, 1, 2, 2, 2, 3 };
            int k = 1;
          int[] result=  ks.TopKElement(nums, k);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
             Console.WriteLine("Hello, World!");
        }
    }
}
