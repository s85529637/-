using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Permutations
    {
        public IList<IList<int>> permutations()
        {
            int[] nums = { 1, 2, 3 };

            IList<IList<int>> permutations = Permute(nums);
            return permutations;
        }


        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> currentPermutation = new List<int>();
            bool[] used = new bool[nums.Length];

            GeneratePermutations(nums, used, currentPermutation, result);

            return result;
        }

        private static void GeneratePermutations(int[] nums, bool[] used, List<int> currentPermutation, IList<IList<int>> result)
        {
            if (currentPermutation.Count == nums.Length)
            {
                result.Add(new List<int>(currentPermutation));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;

                used[i] = true;

                currentPermutation.Add(nums[i]);

                GeneratePermutations(nums, used, currentPermutation, result);

                used[i] = false;
                currentPermutation.RemoveAt(currentPermutation.Count - 1);
            }
        }

    }
}





