using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
   
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Solution s= new Solution();
        List<int> integerList = new List<int>();
            string[] nums = Console.ReadLine().Split(' '); 
            int[] n = Array.ConvertAll(nums, int.Parse);
            string[] integers = Console.ReadLine().Split(' ');
            int[] nIntegers = Array.ConvertAll(integers,int.Parse);
            for (int i = 0; i < nIntegers.Length; i++)
                integerList.Add(nIntegers[i]);
            List<string> output = new List<string>();

                for (int i = 0; i < n[1]; i++)
                {
                    string[] queries = Console.ReadLine().Split(' ');
                    int[] query = Array.ConvertAll(queries, int.Parse);
                    s.RunQuery(query, n[0], ref integerList, ref output);
                }

                foreach (string a in output)
                {
                    Console.WriteLine(a);
                    
                }
           
        
    }
    
    public void RunQuery(int[] arr, int n, ref List<int>numbers, ref List<string> output)
        {
            Solution s= new Solution();
            if (arr[0] == 1)
                s.Query1(arr, n, ref numbers, ref output);
            else if (arr[0] == 2)
                s.Query2(arr, ref numbers);
        }
        public void Query1(int[] arr, int n, ref List<int>numbers, ref List<string>output)
        {
            
            int k = arr[1];
            int count = 0;
            int value = 0;
            for (int i = 0; i < n; i++)
                if (numbers.ElementAt(i)== 0)
                {
                    count++;
                    if (count==k)
                    {
                        
                        value = i;
                        break;
                    }

                }
            if (count != k)
                output.Add("NO");
            else
                output.Add(value.ToString());
        }
        public void Query2(int[] arr, ref List<int>numbers)
        {
           
            int k = arr[1];
            int x = arr[2];
            numbers[k] = x;

        }

}
