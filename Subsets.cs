using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Subsets
    {
        public IList<IList<int>> subsets()
        {
            int[] nums = { 1, 2, 3 };
            IList<IList<int>> qq = aa(nums);
            return qq;
        }
        
        public static IList<IList<int>> aa(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> currentSubset = new List<int>();

            GenerateSubsets(nums, 0, currentSubset, result);

            return result;
        }

        private static void GenerateSubsets(int[] nums, int index, List<int> currentSubset, IList<IList<int>> result)
        {
            result.Add(new List<int>(currentSubset));

            for (int i = index; i < nums.Length; i++)
            {
                currentSubset.Add(nums[i]);
                GenerateSubsets(nums, i+1, currentSubset, result);
                currentSubset.RemoveAt(currentSubset.Count - 1);
            }
        }
    }

}
