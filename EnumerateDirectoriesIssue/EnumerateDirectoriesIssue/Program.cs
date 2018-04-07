using System;
using System.IO;

namespace EnumerateDirectoriesIssue
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please pass a dirextory path");
                return;
            }

            var dir = args[0];

            Console.WriteLine("Dir Name : " + dir);

            Console.WriteLine("Directory exists : " + Directory.Exists(dir));

            if (Directory.Exists(dir))
            {
                Console.WriteLine("Below is the list of child directories found in this directory:");

                foreach (var subDir in Directory.EnumerateDirectories(dir))
                {
                    Console.WriteLine(subDir);
                }
            }
        }
    }
}
