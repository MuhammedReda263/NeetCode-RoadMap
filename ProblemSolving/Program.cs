namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = {1,6,1,5};
            //Console.WriteLine(Solution.hasDuplicate(arr)); 
            //int[] arr2 = Solution.RunningSum(arr);
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine(i);
            //}
            //string s1 = "ahmed";
            //string s2 = "amedh";
            //Console.WriteLine(Solution.IsAnagram(s1,s2));
            //int[] nums = [4,5,6]; int target = 10;

            //int [] arr =Solution.TwoSum(nums, target);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            string[] input = { "act", "pots", "tops", "cat", "stop", "hat" };
            var result =Solution.GroupAnagrams(input);

            foreach (var group in result)
            {
                Console.WriteLine($"[{string.Join(", ", group)}]");
            }


        }
    }
}
