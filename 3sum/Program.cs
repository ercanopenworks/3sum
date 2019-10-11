using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3sum
{
    class Program
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var results = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum < 0)
                    {
                        j++;
                    }
                    else if (sum > 0)
                    {
                        k--;
                    }
                    else
                    {
                        results.Add(new int[] { nums[i], nums[j], nums[k] });
                        do
                        {
                            j++;
                        } while (j < nums.Length && nums[j] == nums[j - 1]);
                        do
                        {
                            k--;
                        } while (k >= 0 && nums[k] == nums[k + 1]);
                    }
                }
            }
            return results;
        }
    
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };

            IList<IList<int>> results = new List<IList<int>>();

            results = ThreeSum(nums);
        }
    }
}
