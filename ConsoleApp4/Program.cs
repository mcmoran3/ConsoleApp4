using System;
using System.Collections.Generic;
using System.Linq;

namespace DIS_Assignmnet1_Fall_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the string:");
            string s = Console.ReadLine();
            bool pos = HalvesAreAlike(s);
            if (pos)
            {
                Console.WriteLine("Both Halfs of the string are alike");
            }
            else
            {
                Console.WriteLine("Both Halfs of the string are not alike");
            }

            Console.WriteLine();

            //Question 2:
            Console.WriteLine(" Q2 : Enter the string to check for pangram:");
            string s1 = Console.ReadLine();
            bool flag = CheckIfPangram(s1);
            if (flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }
            Console.WriteLine();

            //Question 3:
            int[,] arr = new int[,] { { 1, 2, 3 }, { 3, 2, 1 } };
            int Wealth = MaximumWealth(arr);
            Console.WriteLine("Q3:");
            Console.WriteLine("Richest person has a wealth of {0}", Wealth);


            //Question 4:
            string jewels = "aA";    
            string stones = "aAAbbbb";
            Console.WriteLine("Q4:");
            int num = NumJewelsInStones(jewels, stones);
            Console.WriteLine("the number of stones you have that are also jewels are {0}:", num);

            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String word2 = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(word2, indices);
            Console.WriteLine("The Final string after rotation is " + rotated_string);


            //Quesiton 6:
            Console.WriteLine("Q6: Enter the sentence to convert:");
            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };
            int[] target = CreateTargetArray(nums, index);
            Console.WriteLine("Target array  for the Given array's is:");
            for (int i = 0; i < target.Length; i++)
            {
                Console.Write(target[i] + "\t");
            }
            Console.WriteLine();

        }

        /* 
        <summary>
        You are given a string s of even length. Split this string into two halves of equal lengths, and let a be the first half and b be the second half.
        Two strings are alike if they have the same number of vowels ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'). Notice that s contains uppercase and lowercase letters.
        Return true if a and b are alike. Otherwise, return false

        Example 1:
        Input: s = "book"
        Output: true
        Explanation: a = "bo" and b = "ok". a has 1 vowel and b has 1 vowel. Therefore, they are alike.
        </summary>
        */
        private static bool HalvesAreAlike(string s)
        {
            try
            {
                // write your code here
               // string x = Console.ReadLine(); // setting variable equal to user input string
                                               //    bool pos = HalvesAreAlike(s);
              //  Console.WriteLine("Testquestion1");
                string firsthalf = s.Substring(0, s.Length / 2); //splitting the string in a first half 
                string lasthalf = s.Substring(s.Length / 2, s.Length / 2);// splitting the string into a second half
                int firsttotal = 0; // setting default value for each half of the string
                int lasttotal = 0;

                if (firsttotal == lasttotal)
                    // searching for vowel in both new strings 
                    for (int i = 0; i < firsthalf.Length; i++) // this is searching the first half string for lower and upper case vowels to count
                    {
                    if (firsthalf[i] == 'a' || firsthalf[i] == 'e' || firsthalf[i] == 'i' || firsthalf[i] == 'o' || firsthalf[i] == 'u'
                        || firsthalf[i] == 'A' || firsthalf[i] == 'E' || firsthalf[i] == 'I' || firsthalf[i] == 'O' || firsthalf[i] == 'U')
                    {
                        firsttotal++;// adding/maintaining the counts for the first total as string is searched for vowels 
                    }

                }
            ;
                for (int i = 0; i < lasthalf.Length; i++) // this is searching the second half string for lower and upper case vowels to count
                {
                    if (lasthalf[i] == 'a' || lasthalf[i] == 'e' || lasthalf[i] == 'i' || lasthalf[i] == 'o' || lasthalf[i] == 'u'
                        || lasthalf[i] == 'A' || lasthalf[i] == 'E' || lasthalf[i] == 'I' || lasthalf[i] == 'O' || lasthalf[i] == 'U')
                    {
                        lasttotal++;// adding/maintaining the counts for the last total as string is searched for vowels 
                    }
                 
                }





                if (firsttotal == lasttotal)
                    return true; // return true to the boolean if the total counts match each other - passes this boolean value as output of this private method
                else return false;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
 <summary>
A pangram is a sentence where every letter of the English alphabet appears at least once.
Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.
Example 1:
Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
Output: true
Explanation: sentence contains at least one of every letter of the English alphabet.
</summary>
</returns> true/false </returns>
Note: Use of String function (Contains) and hasmap is not allowed, think of other ways how you could the numbers be represented
*/
        private static bool CheckIfPangram(string s)
        {
            try
            {
                string alphabetsearch = "abcdefghijklmnopqrstuvwxyz"; // defining the string of alphabet letters
                int alphacount = 0;// setting default value for the coun
            //    string s1 = Console.ReadLine();
                // bool flag = CheckIfPangram(s1);

                foreach (char c in alphabetsearch) // gets each character in the alpha defined variable 
                {
                    foreach (char l in s) //searches string of user input
                    {
                        if (c == l)// if character matched then enters the count maintaining code
                        {
                            alphacount++; // maintaining a count for the found/ matched characters
                            break;
                        }
                    }
                }


                if (alphacount == 26) // if there are 26 found characters then pass true to as boolean output 
                {
                    return true;
                }
                else
                {
                    return false; //  Console.WriteLine("No, the given string is not a pangram"); prints this if not 26 on the count 
                }
              

               // return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
        You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the ith customer has in the jth bank. Return the wealth that the richest customer has.
       A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.

       Example 1:
       Input: accounts = [[1,2,3],[3,2,1]]
       Output: 6
       Explanation:
       1st customer has wealth = 1 + 2 + 3 = 6
       2nd customer has wealth = 3 + 2 + 1 = 6
       Both customers are considered the richest with a wealth of 6 each, so return 6.
       </summary>
        */
        private static int MaximumWealth(int[,] accounts)
        {
            try
            {
                int[,] arr = new int[,] { { 1, 2, 3 }, { 3, 2, 1 } };
                //int Wealth = MaximumWealth(arr).Max();
                int rows;

                int sumRow;
                int maxsumrow = 0; // set maxrum row to 0
                rows = arr.GetLength(0); // gets the length of array row
                int cols = arr.GetLength(1);// gets length of column row
                

                for (int i = 0; i < rows; i++) // for loop runs until there is a null element in order to stop loop- uses rows variable 
                {
                    sumRow = 0; // setting sumrow to 0
                    for (int j = 0; j < cols; j++)  // for loop runs until there is a null element in order to stop loop uses column variable
                    {
                        sumRow = sumRow + arr[i, j]; // sets the sumrow equal to the row sum of the indices - there are two int output



                    }
                    maxsumrow = Math.Max(maxsumrow, sumRow); // since there are two outputs, get the max and then return the max since we want the richest
                   // return sumRow;
                }
                //  return sumRow;
                return maxsumrow; // passing the int value as output to the private method

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
 <summary>
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have.
Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
Letters are case sensitive, so "a" is considered a different type of stone from "A".
 
Example 1:
Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
Example 2:
Input: jewels = "z", stones = "ZZ"
Output: 0
 
Constraints:
•	1 <= jewels.length, stones.length <= 50
•	jewels and stones consist of only English letters.
•	All the characters of jewels are unique.
</summary>
 */
        private static int NumJewelsInStones(string jewels, string stones)
        {
            try
            {
                // write your code here.
                int num = 0;
                foreach (char c in stones) // looking at all characters in stone variables
                {
                    foreach (char l in jewels)// searching the jewels string to find matches in characters 
                    {
                        if (c == l) // if characters match, keep counting and keep record of the count 
                        {
                            num++;
                            break; // breaks the loop
                        }
                    }
                }

                return num; // returing the integer as output to the private method
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message); 
                throw;
            }

        }



        /*

        <summary>
        Given a string s and an integer array indices of the same length.
        The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: s = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string s, int[] indices)
        {
            try
            {
                // write your code here.
                if (String.IsNullOrEmpty(s)) // checks to make sure there is a string -- if empty it returns blank space
                    return "";

                char[] x = new char[s.Length]; // sets num of characters to the length of the string
                for (int i = 0; i < indices.Length; i++) // as long as I is less than the indices length, continue to loop// increment by 1 after loop iteration
                {
                    x[indices[i]] = s[i]; // uses new character indices to move the original character position  to thier new indices
                   // return "null";
                }

               
                return string.Join("", x); // passing the string to the private method// Using join with blankspace will not alter the string that is passed as output 
              //  return "null";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
        <summary>
Given two arrays of integers nums and index. Your task is to create target array under the following rules:
•	Initially target array is empty.
•	From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
•	Repeat the previous step until there are no elements to read in nums and index.
Return the target array.
It is guaranteed that the insertion operations will be valid.
 
Example 1:
Input: nums = [0,1,2,3,4], index = [0,1,2,2,1]
Output: [0,4,1,3,2]


Explanation:
nums       index     target
0            0        [0]
1            1        [0,1]
2            2        [0,1,2]
3            2        [0,1,3,2]
4            1        [0,4,1,3,2]
*/
        private static int[] CreateTargetArray(int[] nums, int[] index)
        {
            try
            {
              //  int[] target = { };
                IList<int> list = new List<int>(); // creates a list of the int for the target array
                for (int i = 0; i < nums.Length; i++) // for loop runs until there is a null element in order to stop loop uses num length value .continue to loop// increment by 1 after loop iteration
                {
                    list.Insert(index[i], nums[i]);// inserts the new indexes and nums variables into the new list variable
                }
                int[] target = new int[list.Count];// counts elements in the new list and setting the target variable equal to that. 

                for (int i = 0; i < list.Count; i++)// for loop runs until there is a null element in order to stop loop uses list count .continue to loop// increment by 1 after loop iteration
                {
                    target[i] = list[i]; //sets the target variable to the expected indices
                 //   Console.Write(target[i] + "\t");
                }

                return target;// passing target to the output of the private method.
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
