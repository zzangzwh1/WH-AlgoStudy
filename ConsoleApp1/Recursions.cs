using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Recursions
    {
        /// <summary>
        /// You are given an integer N. Print numbers from 1 to N without the help of loops.

        //        Examples:
        //
        //Input: N = 5
        //Output: 1 2 3 4 5
        //Explanation: We have to print numbers from 1 to 5.
        //
        //Input: N = 10
        //Output: 1 2 3 4 5 6 7 8 9 10
        //Explanation: We have to print numbers from 1 to 10.
        /// </summary>
        /// <param name="n"></param>
        public void PrintNumber(int n )
        {
            if (n  >1)
            {
                Console.WriteLine(n);
                PrintNumber(n - 1);
            }
            return;
          
        }
        /// <summary>
        /// Sort the Queue using Recursion
        //         Last Updated : 05 Jan, 2023
        // Given a queue and the task is to sort it using recursion without using any loop.We can only use the following functions of queue: 
        // 
        // empty(q) : Tests whether the queue is empty or not.
        // push(q): Adds a new element to the queue.
        //     pop(q): Removes front element from the queue.
        // size(q): Returns the number of elements in a queue.
        // front(q): Returns the value of the front element without removing it.
        /// </summary>
        /// <param name="arr"></param>
        public void SortTheQue(int[] arr)
        {
            Queue<int> queue = new Queue<int>(arr);
            
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }

        }
    }
}
