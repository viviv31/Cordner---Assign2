﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Cordner___Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Question 1");
            //int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            //int target = 9;
            //int[] r = TargetRange(l1, target);
            // Write your code to print range r here
           
            // Console.WriteLine("Question 2");
            //string s = "University of South Florida";
            //string rs = StringReverse(s);
            //Console.WriteLine(rs);
           
            //Console.WriteLine("Question 3");
            //int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            //int sum = MinimumSum(l2);
            //Console.WriteLine(sum);
            
            //Console.WriteLine("Question 4");
            //string s2 = "daniel";
            //string sortedString = FreqSort(s2);
            //Console.WriteLine(sortedString);

            //Console.WriteLine("Question 5-Part 1");
            //int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = { 2, 2 };
            //int[] intersect1 = Intersect1(nums1, nums2);
            //Console.WriteLine("Part 1- Intersection of two arrays is: ");
            //DisplayArray(intersect1);
            //Console.WriteLine("\n");
            //Console.WriteLine("Question 5-Part 2");
            //int[] intersect2 = Intersect2(nums1, nums2);
            //Console.WriteLine("Part 2- Intersection of two arrays is: ");
            //DisplayArray(intersect2);
            //Console.WriteLine("\n");
           
            //Console.WriteLine("Question 6");
            //char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            //int k = 3;
            //Console.WriteLine(ContainsDuplicate(arr, k));
            
            //Console.WriteLine("Question 7");
            //int rodLength = 4;
            //int priceProduct = GoldRod(rodLength);
            //Console.WriteLine(priceProduct);
            
            //Console.WriteLine("Question 8");
            //string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            //string keyword = "hhllo";
            //Console.WriteLine(DictSearch(userDict, keyword));
            
            //Console.WriteLine("Question 8");
            //SolvePuzzle();
        }

        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return new int[] { };
        }

        public static string StringReverse(string s)
        {
            try
            {
                //write your code here
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public static int MinimumSum(int[] l2)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static string FreqSort(string s2)
        {
            SortedDictionary<char, string> dict = new SortedDictionary<char, string>();
            string outstring = String.Empty;
            Boolean multi = false;

            try
            {
                // put ea char into dictionary with value as frequency
                foreach (char c in s2)
                {
                    if (!dict.ContainsKey(c)) dict.Add(c, c.ToString());
                    else
                    {
                        dict[c] = dict[c] + c.ToString();
                        multi = true;
                    }  
                }

                if (multi == false) return outstring = "There ain't no double letters in your string";
                
                foreach (var item in dict.OrderByDescending(r => r.Value))
                {
                    outstring = outstring + item.Value;
                }

            }
            catch (Exception)
            {   //I feel like there should be somehting in here to handle specific exceptions
                // however, I couldn't generate any errors
                throw;
            }
            return outstring;
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            SortedDictionary<char,int> dict = new SortedDictionary<char, int>();
            Boolean foundit = false;

            try
            {
                for (int i = 0; i <= arr.Length; i++)
                { 
                    if(!dict.ContainsKey(arr[i]))
                    {
                        dict.Add(arr[i], 0);
                    }
                    else
                    {
                        dict[arr[i]] = i - dict[arr[i]];

                        if (dict[arr[i]] <= k)
                        {
                            foundit = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return foundit;
        }

        public static int GoldRod(int rodLength)
        {
            try
            {
                //Write Your Code Here

            }

            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }
        public static void SolvePuzzle()
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
            return;
        }
    }
}
