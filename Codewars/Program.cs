using System;

namespace Codewars
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("CodeWars!");
            var res = new Codewars();
            Console.WriteLine(res.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
        }
    }
}