using System;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChristmasTree(30));
            Console.ReadLine();
        }
        public static string ChristmasTree(int height)
        {
            if (height == 0)
                return "";
            else
            {
                string tree = "";
                for (int i = 0; i < height; ++i)
                {
                    tree += string.Concat(new string(' ', height - i - 1),
                                         new string('*', i * 2 + 1),
                                         new string(' ', height - i - 1), "\n");
                }
                return tree.Remove(tree.Length - 1);
            }
        }
    }
}
