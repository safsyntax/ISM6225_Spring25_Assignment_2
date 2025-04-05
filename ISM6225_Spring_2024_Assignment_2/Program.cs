using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                List<int> missingnums = new List<int>();
                int n = nums.Length;
        
                for (int i = 0; i < n; i++)
                {
                    int index = Math.Abs(nums[i]) - 1;
                    if (nums[index] > 0)
                        nums[index] = -nums[index];
                }
        
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] > 0)
                        missingnums.Add(i + 1);
                }

                return missingnums;
                //Edge Cases
                    //if all numbers are there, return emptylist
                    //if nums is empty, return emptylist
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                int[] separated = new int[nums.Length];
                int even_index = 0;
                int odd_index = nums.Length - 1;
                
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                        separated[even_index++] = nums[i];
                    else
                        separated[odd_index--] = nums[i];
                }

                return separated;
                //Edge Cases
                    //if all even or all odd, return same array
                    //if one element, return same
                    //if array is emprty, return empty array
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                 Dictionary<int, int> map = new Dictionary<int, int>();
                
                for (int i = 0; i < nums.Length; i++)
                {
                    int a = target - nums[i];
                    if (map.ContainsKey(a))
                        return new int[] { map[a], i };
                    map[nums[i]] = i;
                }
                
                return new int[0];
                //Edge Cases
                    //empty or only 1; return empty since no pairs possible
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                Array.Sort(nums);
                int n = nums.Length;
                int max1 = nums[n-1] * nums[n-2] * nums[n-3];
                int max2 = nums[0] * nums[1] * nums[n-1];
                
                return Math.Max(max1, max2);
                //Edge caese
                    //max2 handles cases where 2 -ve can make a +ve
                    //max1 used if only 2 elements
                    //max1 used if all negative
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                if (decimalNumber == 0) return "0";
                
                string bin = "";
                int num = decimalNumber;
                while (num > 0)
                {
                    bin = (num % 2) + bin;
                    num /= 2;
                }
                
                return bin;
                //Edge Cases
                    //if 0; return 0
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                int l = 0, r = nums.Length - 1;
                
                while (l < r)
                {
                    int mid = l + (r - l) / 2;
                    if (nums[mid] > nums[r])
                        l = mid + 1;
                    else
                        r = mid;
                }
                
                return nums[l];
                //Edge Cases
                    //1 element; return element
                    //2+ elements; return min
                    //all same; return first
                    //in order; return first
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                if (x < 0) return false;
                if (x == 0) return true;
                
                string s_num = x.ToString();
                int l = 0, r = s_num.Length - 1;
                
                while (l < r)
                {
                    if (s_num[l++] != s_num[r--])
                        return false;
                }
                return true;
                //Edge Cases
                    //0; true
                    //-ve; false
                    //1 digit; true
                    //not palindrome ; false
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                if (n == 0) return 0;
                if (n == 1) return 1;
                
                int last = 0, num = 1;
                for (int i = 2; i <= n; i++)
                {
                    int next = last + num;
                    last = num;
                    num = next;
                }

                return num;
                //Edge Cases
                    //n=0; 0
                    //n=1; 1
                    //negatives; not necessary given the constraint 0<=n<=30
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}