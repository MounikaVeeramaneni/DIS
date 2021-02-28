using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 2;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>
        /// <param name="nums">Input</param>
        /// <param name="n">ShuffleNumber</param>
        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                /*
                * From the above explanation, it is understood that
                * The expected output array should have xn and yn objects shuffled alternatively             
                * Created a new List object lintArrNewNums<int> with size 2n to handle the output
                */
                if (n > 0 && nums.Length == 2 * n)
                {
                    List<int> lintArrNewNums = new List<int>(2 * n);
                    int j = 0; int k = 0;
                    for (int i = 0; i < (2 * n); i++)
                    {
                        //If it is even index adding the xn values of nums[k] by incrementing k
                        //This gives only the first n values in nums
                        if (i % 2 == 0)
                        {
                            lintArrNewNums.Insert(i, nums[k]);
                            k++;
                        }
                        //If it is odd index adding the yn values of nums[n+j] by incrementing j 
                        //This gives only last n values in nums[]
                        else
                        {
                            lintArrNewNums.Insert(i, nums[n + j]);
                            j++;
                        }
                    }
                    //Appending the list elements with comma seperation to display the output
                    Console.WriteLine(string.Join(",", lintArrNewNums));
                }
                else
                {
                    Console.WriteLine("Provided invalid input");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>
        /// <param name="ar2">Input</param>
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                if (ar2 != null)
                {
                    /*
                    * From the above explanation, it is understood that
                    * All the zeroes in the input should be moved the end of the array          
                    * Introduced a new index k and moved non zero values of the array to the new index of the same array.
                    */
                    int k = 0;
                    for (int i = 0; i < ar2.Length; i++)
                    {
                        //check if the value is a non zero element and move it to the start of the array.
                        if (ar2[i] != 0)
                        {
                            ar2[k++] = ar2[i];
                        }
                    }
                    //Assigning Zeroes till ar2.Length for the same array ar2
                    while (k < ar2.Length)
                        ar2[k++] = 0;
                    Console.WriteLine(string.Join(",", ar2));
                }
                else
                {
                    Console.WriteLine("Provided invalid array");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>
        /// <param name="nums">Input</param>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                /*
                 * The number of Cool pairs is same as sum of incremental count of each element
                 * Created a dictionary to hold the element as key and Count of each element as its value
                 * Everytime a number/element is repeated add the existing dictionary value of the element to result
                 * In the next step increment the dictionary value
                 */
                if (nums == null || nums.Length < 1)
                    Console.WriteLine("0");
                else
                {
                    int lintresult = 0;
                    Dictionary<int, int> lDictCount = new Dictionary<int, int>();
                    //Repeat the loop for all the input nums
                    foreach (int x in nums)
                    {
                        // Add Value 1 to each new element
                        if (!lDictCount.ContainsKey(x))
                        {
                            lDictCount.Add(x, 1);
                        }
                        //Increment the value correpsonding to x in the dictionary by 1 after adding it to the result
                        else
                        {
                            lintresult += lDictCount[x];
                            lDictCount[x]++;
                        }
                    }
                    Console.WriteLine(lintresult);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        /// <param name="target">Sum</param>
        /// <param name="nums">Input</param>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                if (nums != null && target > 0)
                {
                    /*
                    *Get the complement of each element of the array
                    *Create a dictionary to store the elements of the input array as Keys and corresponding indices as values
                    */
                    Dictionary<int, int> lobjDictTwoSum = new Dictionary<int, int>();
                    for (int i = 0; i < nums.Length; i++)
                    {
                        // Calculate the difference of the target and current number
                        // If it already exists in the dictionary keys, return the output
                        // as the value corresponding to the lintDifference key and the current index
                        int lintDifference = target - nums[i];
                        if (lobjDictTwoSum.ContainsKey(lintDifference))
                        {
                            Console.WriteLine(lobjDictTwoSum[lintDifference] + "," + i);
                            break;
                        }
                        // If the Dictionary doesnt contain the complement value, add the current element and its index
                        lobjDictTwoSum.Add(nums[i], i);

                    }
                }
                else
                {
                    Console.WriteLine("Provided invalid input");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        /// <param name="s">Input String</param>
        /// <param name="indices">Indices</param>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                if (s != null && indices != null && s.Length == indices.Length)
                {
                    // Need to arrange the string s according to the indices
                    // Created a dictionary to hold the letters as keys and indices as values 
                    Dictionary<Char, int> lDictOutput = new Dictionary<char, int>();
                    string lstrOutput = string.Empty;
                    int k = 0;
                    //for each value in the indices, add the corresponding string value and index to Dictionary
                    foreach (var i in indices)
                    {
                        lDictOutput.Add(s[k], i);
                        k++;
                    }
                    //Sort the values of the dictionary and add the keys of it in the same order to the output
                    foreach (KeyValuePair<char, int> x in lDictOutput.OrderBy(j => j.Value))
                    {
                        lstrOutput += x.Key;
                    }
                    Console.WriteLine(lstrOutput);
                }

                else
                {
                    Console.WriteLine("Provided invalid input");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        /// <param name="s1">Input String 1</param>
        /// <param name="S2">Input String 2</param>
        /// <returns> The boolean value if it is isomorphic or not</returns> 
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                // If the length of the strings doesnt match, not an isomorhic
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                // Created a dictionary to store the unique mappings compared from both the strings
                // Adding the Characters from String S1 as keys and from String 2 as values              
                Dictionary<Char, Char> lDictIsomorphic = new Dictionary<char, char>();
                for (int i = 0; i < s1.Length; i++)
                {
                    // If the dictionary doesnt have a character from String S1 in the keys,
                    // Check if its corresponding String S2 of same index is already present in the dictionary
                    // If yes, return false as the value is already mapped to some other key but not the current one
                    if (!lDictIsomorphic.ContainsKey(s1[i]))
                    {
                        if (lDictIsomorphic.ContainsValue(s2[i]))
                        {
                            return false;
                        }
                        // if both key and value are not present in the dictionary store the mapping
                        else
                        {
                            lDictIsomorphic.Add(s1[i], s2[i]);
                        }
                    }
                    // If the dictionary already has a character from String S1 in the keys,
                    // Check if its corresponding values is same as character from String S2 of same index
                    else
                    {
                        if (lDictIsomorphic[s1[i]] != s2[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        /// <param name="items">Input int two dimensional array</param>
        private static void HighFive(int[,] items)
        {
            try
            {
                /*
                * Created a dictionary to hold the id and all the corresponding scores in a list
                * If the dict doesnt have the current id as key, create a new List 
                * Add the current score to the above List and add the new key and thIS list to the dictionary
                * Create a dictionary to store the elements of the input array as Keys and corresponding indices as values
                */
                if (items.Length >= 1 && items.Length <= 1000 && items.GetLength(1) == 2)
                {
                    Dictionary<int, List<int>> lDictItems = new Dictionary<int, List<int>>();
                    Dictionary<int, int> lDictOutput = new Dictionary<int, int>();

                    for (int i = 0; i < items.GetLength(0); i++)
                    {
                        if (items[i, 0] >= 1 && items[i, 0] <= 1000 && items[i, 1] >= 0 && items[i, 1] <= 100)
                        {
                            // If the dict already has the current id as the key
                            // Get the current value corresponding to the key - which is an existing list of scores
                            // Append the current value to this list
                            if (lDictItems.ContainsKey(items[i, 0]))
                            {
                                List<int> llistItems = lDictItems[items[i, 0]];
                                llistItems.Add(items[i, 1]);
                                lDictItems[items[i, 0]] = llistItems;
                            }
                            else
                            {
                                List<int> llistItems = new List<int>();
                                llistItems.Add(items[i, 1]);
                                lDictItems.Add(items[i, 0], llistItems);

                            }
                        }
                        else
                        {
                            Console.WriteLine("Provided invalid input- Scores or IDs are not in the given range");
                        }
                    }
                    // Get the top 5 Scores by querying on the dictionary Values corresponding to each ID
                    // Get the sum and calculate the average
                    // Add the ID and corresponding top 5 average to the new dictionary to display the output
                    foreach (KeyValuePair<int, List<int>> x in lDictItems)
                    {
                        var top5 = x.Value.OrderByDescending(j => j).Take(5).Sum();
                        lDictOutput.Add(x.Key, top5 / 5);
                    }
                    Console.WriteLine(string.Join(",", lDictOutput));

                }
                else
                {
                    Console.WriteLine("Provided invalid input");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                /*
                * Created a new hashset to hold the already calculated numbers
                * Calculate the last digit using %10 and retrive the remaining number
                * using /10 till all the digits are covered, Add the digits to llistAllDigits
                * Calculate the sum of squares of each digit
                * Loop till the number is not equal to 1 
                */

                HashSet<int> lobjTestedNumbers = new HashSet<int>();
                while (n != 1)
                {
                    if (n > 1 && n <= (Math.Pow(2, 31) - 1))
                    {
                        int lintNewNumber = 0;
                        List<int> llistAllDigits = new List<int>();
                        while (n > 0)
                        {
                            llistAllDigits.Add(n % 10);
                            n = n / 10;
                        }

                        foreach (int i in llistAllDigits)
                        {
                            lintNewNumber = lintNewNumber + i * i;
                        }
                        // Adding every new calculated number to the lobjTestedNumbers
                        // check if the lintNewNumber is already in the list
                        // Return false if it is already in the list/checked
                        if (lobjTestedNumbers.Contains(lintNewNumber))
                        {
                            return false;
                        }
                        lobjTestedNumbers.Add(lintNewNumber);
                        n = lintNewNumber;
                    }
                    else
                    {
                        Console.WriteLine("Provided invalid input");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                /*
                 * Instantiated the Buying Price to first element, Selling price to any negative numebr
                 * Check if the next element is less than Buying Price, 
                 * if yes set this element as Buying Price, reset the selling price to zero
                 * check if next element is greater than selling price, 
                 * if yes set this element as new Selling Price, repeat this till all the prices
                 */
                int lintProfit = 0;
                int lintMaxProfit = 0;

                if (prices == null || prices.Length <= 1)
                    return lintProfit;
                int lintBuyingPrice = prices[0];
                int lintSellingPrice = -1; // price will not be negative

                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] <= lintBuyingPrice)
                    {
                        lintBuyingPrice = prices[i];
                        lintSellingPrice = 0;
                    }
                    else if (prices[i] >= lintSellingPrice)
                    {
                        lintSellingPrice = prices[i];
                        //calculate profit only after getting the selling price to avoid situations like [2,4,1]
                        lintProfit = lintSellingPrice - lintBuyingPrice;
                        //Get the Max profit everytime we calculate the selling price
                        lintMaxProfit = Math.Max(lintProfit, lintMaxProfit);
                    }
                }
                return lintMaxProfit;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                /*
                 * If steps is 1, there is only one way
                 * Creating a new one dimensional array to store the unique ways for each number of steps
                 * Instantiating the value lintUniqueWays[2] to 2
                 * Calculate the current element by summing up the previous 2 elements
                 * Repeat this till we have the steps asked for in the parameter
                 */
                int lintCount;
                if (steps == 1)
                {
                    lintCount = 1;
                }
                int[] lintUniqueWays = new int[steps + 1];
                lintUniqueWays[1] = 1;
                lintUniqueWays[2] = 2;
                for (int i = 3; i <= steps; i++)
                {
                    lintUniqueWays[i] = lintUniqueWays[i - 1] + lintUniqueWays[i - 2];
                }
                // Return the required unique ways correpsonding to index = steps
                lintCount = lintUniqueWays[steps];
                Console.WriteLine(lintCount);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}