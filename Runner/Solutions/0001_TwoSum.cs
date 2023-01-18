using Utils;

namespace Solutions
{
    public class TwoSumSolution : ISolution
    {
        public TwoSumSolution()
        {
            Console.WriteLine("Init " + this.GetType().Name);
        }

        public int[] TwoSum(int[] nums, int target) 
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count(); ++i)
            {
                if (dict.ContainsKey(target - nums[i])) {
                    return new int[] {dict[target-nums[i]], i};
                }
                dict[nums[i]] = i;
            }
            return new int[] {};
        }

        public void run()
        {
            // Input
            var inputArr = new int[] {1,2,3};
            var target = 5;

            // Ans
            var ans = this.TwoSum(inputArr, target);
            
            // Print
            OutputUtils.Print(ans);
        }
    }
}
