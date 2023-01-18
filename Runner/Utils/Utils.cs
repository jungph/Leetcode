using Models;
using System;
using System.Text;

namespace Utils
{
    public class OutputUtils
    {
        public OutputUtils()
        {

        }

        public static void Print(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("");
            } else if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            } else
            {
                for (int i = 0; i < arr.Length-1; ++i)
                {
                    Console.Write(arr[i] + ", ");
                }
                Console.Write(arr[arr.Length-1]);
            }
        }

        public static void Print(List<int> arr)
        {
            if (arr == null || arr.Count() == 0)
            {
                Console.WriteLine("");
            } else if (arr.Count() == 1)
            {
                Console.WriteLine(arr[0]);
            } else
            {
                for (int i = 0; i < arr.Count()-1; ++i)
                {
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine(arr[arr.Count()-1]);
            }
        }

        public static void Print(ListNode ans)
        {
            if (ans == null)
            {
                Console.WriteLine("");
            } else
            {
                var sb = new StringBuilder();

                do {
                    sb.Append(ans.val);
                    ans = ans.next;
                    if (ans != null)
                    {
                        sb.Append(", ");
                    }

                } while (ans != null);

                Console.WriteLine(sb);
            }
        }
    };
}