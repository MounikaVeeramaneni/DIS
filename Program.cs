using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            int n = Convert.ToInt32(Console.ReadLine());
            printTriangle(n);
            Console.WriteLine();
            //Question 2:
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            printPellSeries(n2);
            Console.WriteLine();
            //Question 3:
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            bool flag = squareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }
            //Question 4:
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = diffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);
            //Question 5:
            List<string> emails = new List<string>();
            emails.Add("dis.email + bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + ans5);
            //Quesiton 6:
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                       { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);
        }

        /// <summary>
        ///Print a pattern with n rows given n as input
        ///n – number of rows for the pattern, integer (int)
        ///This method prints a triangle pattern.
        ///For example n = 5 will display the output as:
        ///      *
        ///     ***
        ///    *****
        ///   *******
        ///  *********
        ///returns      : N/A
        ///return type  : void
        /// </summary>
        /// <param name="n"></param>
        private static void printTriangle(int n)
        {
            try
            {
                /*
                 * In the above example of n=5, 
                 * for the first row we have 4 spaces, 1 star
                 * for the second row it is 3 spaces, 2 stars
                 * for the third row it is 2 spaces, 3 stars and so on.             
                 */
                if (n >= 0)
                {
                    int lintCount = n - 1;
                    int i, j;
                    // For loop to handle the the number of rows to be reflected.
                    for (j = 1; j <= n; j++)
                    {
                        /*for loop to handle the spaces present in each row.
                         * (here it is 1 till n-1 for the row1
                         * 1 till n-2 for the row2
                         * 1 till n-3 for the row3
                         * which is handled using  lintCount--; for each iteration of rows)
                         */
                        for (i = 1; i <= lintCount; i++)
                        {
                            Console.Write(" ");
                        }
                        lintCount--;
                        /*for loop to handle the * present in each row.
                        * (here it is 1 till 2n-1 for the row1
                        * 1 till 2n-1 for the row2
                        * 1 till 2n-1 for the row3
                        * which is handled using  i <= 2 * j - 1; for each iteration of rows)
                        */
                        for (i = 1; i <= 2 * j - 1; i++)
                        {
                            Console.Write("*");
                        }
                        //Adding a newline to seperate each row
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Provided invalid number of rows");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>
        /// In mathematics, the Pell numbers are an infinite sequence of integers.
        /// The sequence of Pell numbers starts with 0 and 1, and then each Pell number is the sum of twice of the previous Pell number and
        /// the Pell number before that.:thus, 70 is the companion to 29, and 70 = 2 × 29 + 12 = 58 + 12. The first few terms of the sequence are :
        /// 0, 1, 2, 5, 12, 29, 70, 169, 408, 985, 2378, 5741, 13860,...
        /// Write a method that prints first n numbers of the Pell series
        /// Returns : N/A
        /// Return type: void
        /// </para>
        /// </summary>
        /// <param name="n2"></param>
        private static void printPellSeries(int n2)
        {
            try
            {
                /*
                 * If a and b are the last two corresponding digits,
                 * the next digit of the Pell series is 2b+a           
                 */
                if (n2 >= 0)
                {
                    int i, a = 1, b = 0, c = 0;
                    //Printing the first digit 0
                    Console.Write(c);
                    //Adding a space seperation between each number of the pell series
                    Console.Write(" ");
                    for (i = 1; i < n2; i++)
                    {
                        c = 2 * b + a;
                        Console.Write(c);
                        // Assigning a and b to the next set of digits to find the nth pell number
                        a = b;
                        b = c;
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.WriteLine("Provided invalid number of series");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        ///Given a non-negative integer c, decide whether there're two integers a and b such that a^2 + b^2 = c.
        ///For example:
        ///Input: C = 5 will return the output: true (1*1 + 2*2 = 5)
        ///Input: C = 3 will return the output : false
        ///Input: C = 4 will return the output: true
        ///Input: C = 1 will return the output : true
        ///Note: You cannot use inbuilt Math Class functions.
        /// </summary>
        /// <param name="n3"></param>
        /// <returns>True or False</returns>
        private static bool squareSums(int n3)
        {
            try
            {
                /*
                 * In the above example of C = 5, 3, 4, 1  
                 * Sum of Squares is only possible for 5, 4 and 1
                 * as (1*1 + 2*2 = 5, 2*2 + 0*0 = 4 and 1*1 + 0*0 = 1)
                 * which shows that a and b could be any value ranging from o till SquareRoot of n
                 * Created two for loops to iterate i and j values within 0 and i*i <= n / j*j <=n3)
                 */
                for (long i = 0; i * i <= n3; i++)
                    for (long j = 0; j * j <= n3; j++)
                        //Validate if there are any combination of i and j pairs so that i*i+j*j ==n3
                        if (i * i + j * j == n3)
                        {
                            return true;
                        }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Given an array of integers and an integer n, you need to find the number of unique
        /// n-diff pairs in the array.Here a n-diff pair is defined as an integer pair (i, j),
        ///where i and j are both numbers in the array and their absolute difference is n.
        ///Example 1:
        ///Input: [3, 1, 4, 1, 5], k = 2
        ///Output: 2
        ///Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
        ///Although we have two 1s in the input, we should only return the number of unique  
        ///pairs.
        ///Example 2:
        ///Input:[1, 2, 3, 4, 5], k = 1
        ///Output: 4
        ///Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and
        ///(4, 5).
        ///Example 3:
        ///Input: [1, 3, 1, 5, 4], k = 0
        ///Output: 1
        ///Explanation: There is one 0-diff pair in the array, (1, 1).
        ///Note : The pairs(i, j) and(j, i) count as same.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns>Number of pairs in the array with the given number as difference</returns>
        private static int diffPairs(int[] nums, int k)
        {
            try
            {
                /*
                 * Given examples show that there shouldnt be any duplicate pairs
                 * Initialized a HashSet lobjUniquePair to handle the duplicates
                 * Sorted the array so that (nums[j] + "," + nums[i]) is constructed as such nums[j] is always greater than nums[i]
                 */
                HashSet<string> lobjUniquePair = new HashSet<string>();
                Array.Sort(nums);
                {
                    for (int i = 0; i < nums.Length; i++)
                        for (int j = i + 1; j < nums.Length; j++)
                            //validate the difference with param k
                            if (nums[j] - nums[i] == k)
                            {
                                //concatenated n[i], n[j] with a comma seperation and added to the hashset to handle unique values
                                lobjUniquePair.Add(nums[j] + "," + nums[i]);
                            }
                }
                //returning the count of UniquePairs determined
                return lobjUniquePair.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }
        }
        /// <summary>
        /// An Email has two parts, local name and domain name.
        /// Eg: rocky @usf.edu – local name : rocky, domain name : usf.edu
        /// Besides lowercase letters, these emails may contain '.'s or '+'s.
        /// If you add periods ('.') between some characters in the local name part of an email address, mail
        /// sent there will be forwarded to the same address without dots in the local name.
        /// For example, "bulls.z@usf.com" and "bullsz@leetcode.com" forward to the same email address. (Note that this rule does not apply for domain names.)
        /// If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows
        /// certain emails to be filtered, for example ro.cky+bulls @usf.com will be forwarded to rocky @email.com. (Again, this rule does not apply for domain names.)
        /// It is possible to use both of these rules at the same time.
        /// Given a list of emails, we send one email to each address in the list.Return, how many different addresses actually receive mails?
        /// Eg:
        /// Input: ["dis.email+bull@usf.com","dis.e.mail+bob.cathy@usf.com","disemail+david@us.f.com"]
        /// Output: 2
        /// Explanation: "disemail@usf.com" and "disemail@us.f.com" actually receive mails
        /// </summary>
        /// <param name="emails"></param>
        /// <returns>The number of unique emails in the given list</returns>
        private static int UniqueEmails(List<string> emails)
        {
            try
            {
                /*
                * From the above explanation, it is understood that
                * 1. Local name should ignore "."
                * 2. If Local name has "+", everything after the first plus is to be ignored
                * 3. Both of the above rules doesnt apply for Domain name
                * Created a new hashset object lobjUniqueEmails to handle the Unique email addresses
                */
                HashSet<String> lobjUniqueEmails = new HashSet<String>();
                foreach (String email in emails)
                {
                    //Removing the spaces if any provided in the input 
                    String lstrEmail = email.Replace(" ", "");
                    //Fetching the index of "@" to seperate the local name and domain name
                    int i = lstrEmail.IndexOf('@');
                    String lstrLocalName = lstrEmail.Substring(0, i);
                    String lstrDomainName = lstrEmail.Substring(i);
                    //If Local name contains "+", terminate the later part of the string from plus sign
                    if (lstrLocalName.Contains('+'))
                    {
                        lstrLocalName = lstrLocalName.Substring(0, lstrLocalName.IndexOf('+'));
                    }
                    //Remove the "." present in the local name
                    lstrLocalName = lstrLocalName.Replace(".", "");
                    //Concatenate local and domain names and added it to the HashSet object to provide unique email addresses
                    lobjUniqueEmails.Add(lstrLocalName + lstrDomainName);

                }
                //Return the count of unique email addresses
                return lobjUniqueEmails.Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        /// <summary>
        /// You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going
        /// from cityAi to cityBi.Return the destination city, that is, the city without any path outgoing to another city.
        /// It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        /// Example 1:
        /// Input: paths = [["London", "New York"], ["New York","Tampa"], ["Delhi","London"]]
        /// Output: "Tampa"
        /// Explanation: Starting at "Delhi" city you will reach "Tampa" city which is the destination city.Your trip
        /// consist of: "Delhi" -> "London" -> "New York" -> "Tampa".
        /// Input: paths = [["B","C"],["D","B"],["C","A"]]
        /// Output: "A"
        /// Explanation: All possible trips are:
        /// "D" -> "B" -> "C" -> "A".
        /// "B" -> "C" -> "A".
        /// "C" -> "A".
        /// "A".
        /// Clearly the destination city is "A".
        /// </summary>
        /// <param name="paths"></param>
        /// <returns>The destination city string</returns>
        private static string DestCity(string[,] paths)
        {
            try
            {
                /*
                * From the above explanation, it is understood that
                * The second element(destination)[suppose y(y1, y2, y3)] in each path object of the array is 
                * to be compared with the first element[suppose x(x1, x2, x3)] of each path object
                * to determine if it is the final destination.
                * Created a HashSet lobjDestination to store y value for which there is no x 
                */
                HashSet<object> lobjDestination = new HashSet<object>();
                for (int i = 0; i <= paths.GetLength(1); i++)
                {
                    // Adding all destination elements (y1, y2, y3) to HashSet
                    lobjDestination.Add(paths.GetValue(i, 1));
                }

                for (int i = 0; i <= paths.GetLength(1); i++)
                {
                    // Removing destination (y) values for which y= any of start city(x1, x2, x3)
                    lobjDestination.Remove(paths.GetValue(i, 0));
                }
                // As it is mentioned, the graph of paths forms a line without any loop,
                // there will be one destination city which is returned as output
                string lstrDestination = Convert.ToString(lobjDestination.FirstOrDefault());
                return lstrDestination;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


