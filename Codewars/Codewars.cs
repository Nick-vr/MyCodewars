using System;
using System.Linq;

namespace Codewars
{
    public class Codewars
    {
        public string Longest(string s1, string s2)
        {
            // Take 2 strings s1 and s2 including only letters from a to z.
            // Return a new sorted string, the longest possible,
            // distinct letters - each taken only once - coming from s1 or s2.

            var str = s1 + s2;
            var result = new string(str.OrderBy(x => x).Distinct().ToArray());
            return result;
        }

        public string HighAndLow(string numbers)
        {
            // You are given a string of space separated numbers, and have to return the highest and lowest number.

            // Split given array on space
            string[] splittedNums = numbers.Split(' ');

            // Convert string array to int array using LINQ, then order the array from highest number to lowest
            int[] myInts = splittedNums.Select(int.Parse).OrderByDescending(x => x).ToArray();

            string highestNum = Convert.ToString(myInts.First());
            string lowestNum = Convert.ToString(myInts.Last());

            string highAndLow = $"{highestNum} {lowestNum}";

            return highAndLow;
        }

        public string Tickets(int[] peopleInLine)
        {
            // There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.
            //Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
            // Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?
            // Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment. Otherwise return NO.
            var twentyfive = 0;
            var fifty = 0;
            var answer = "";

            Console.WriteLine("[{0}]", string.Join(", ", peopleInLine));

            foreach (var peoplesMoney in peopleInLine)
            {
                switch (peoplesMoney)
                {
                    case 25:
                        twentyfive++;
                        answer = "YES";
                        break;

                    case 50:
                        if (twentyfive > 0)
                        {
                            twentyfive--;
                            fifty++;
                            answer = "YES";
                        }
                        else
                        {
                            return "NO";
                        }
                        break;

                    case 100:
                        switch (twentyfive)
                        {
                            case > 0 when fifty > 0:
                                twentyfive--;
                                fifty--;
                                answer = "YES";
                                break;

                            case >= 3:
                                twentyfive -= 3;
                                answer = "YES";
                                break;

                            default:
                                return "NO";
                        }

                        break;
                }
            }
            return answer;
        }
    }
}