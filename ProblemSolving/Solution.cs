﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Solution
    {


        public static bool hasDuplicate(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Add(nums[i]);
            }
            if (numbers.Count == nums.Length)
                return false;
            else
                return true;
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }
            return result;

        }

        public static bool IsAnagram(string s, string t)
        {
            if (s == null || t == null) return false;
            if (s.Length != t.Length) return false;
            var s1 = s.ToCharArray();
            var t1 = t.ToCharArray();
            Array.Sort(s1);
            Array.Sort(t1);

            return s1.SequenceEqual(t1);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }


            }
            return new int[0];
        }

        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> Dictionary = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string Key = new string(chars);
                if (!Dictionary.ContainsKey(Key))
                {
                    Dictionary[Key] = new List<string>();
                }

                Dictionary[Key].Add(str);
            }
            return Dictionary.Values.ToList();
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> Dictionary = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (!Dictionary.ContainsKey(i))
                {
                    Dictionary[i] = 1;
                }
                else
                {
                    var x = Dictionary[i];
                    Dictionary[i] = x + 1;
                }
            }
            var topK = Dictionary.OrderByDescending(pair => pair.Value)
                             .Take(k)
                             .Select(pair => pair.Key)
                             .ToArray();

            return topK;
        }

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> matchingBrackets = new Dictionary<char, char>()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
            if (s.Length % 2 == 1) return false;
            foreach (char c in s)
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (matchingBrackets.ContainsKey(c))
                {
                    if (matchingBrackets[c] == stack.Peek())
                    {
                        stack.Pop();

                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }

        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var c in tokens)
            {
                if (int.TryParse(c, out var value))
                {
                    stack.Push(value);
                }
                else
                {
                    int y = stack.Pop();
                    int x = stack.Pop();
                    int z;

                    switch (c)
                    {
                        case "+": z = x + y; stack.Push(z); break;
                        case "-": z = x - y; stack.Push(z); break;
                        case "*": z = x * y; stack.Push(z); break;
                        case "/": z = x / y; stack.Push(z); break;
                        default: break;
                    }

                }

            }
            return stack.Pop();
        }

        public static int[] DailyTemperatures(int[] temperatures)
        {

           
            int[] result = new int[temperatures.Length];
            Stack<int> stack = new Stack<int>(); 

           for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count>0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prev = stack.Pop();
                    result[prev] = i - prev;
                }
                stack.Push(i);
            }

            return result;
        }

		public static bool IsPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s)) return true;
			int i = 0;
			int x = s.Length - 1;
			while (i < x)
			{
				while (i < x && !char.IsLetterOrDigit(s[i])) i++;
				while (i < x && !char.IsLetterOrDigit(s[x])) x--;
				if (char.ToLower(s[i]) != char.ToLower(s[x])) return false;
				i++; x--;
			}
			return true;

		}
	}
}
