using System;

namespace Look_and_say_sequence_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LookAndSaySequence("22", 10));
            Console.WriteLine(LookAndSaySequence("1", 3));
            Console.WriteLine(LookAndSaySequence("1", 5));
            Console.ReadLine();
        }
        public static string LookAndSaySequence(string firstElement, long n)
        {
            int counter = 1;
            while (counter != n)
            {
                if (firstElement.Length == 1)
                {
                    firstElement = "1" + firstElement;
                    counter++;
                }
                else
                {
                    int lenth = 1, i;
                    string result = "";
                    for (i = 0; i < firstElement.Length - 1; ++i)
                    {
                        if (firstElement[i + 1] == firstElement[i])
                            lenth++;
                        else
                        {
                            result += lenth.ToString() + firstElement[i];
                            lenth = 1;
                        }
                    }
                    result += lenth.ToString() + firstElement[i];
                    firstElement = result;
                    counter++;
                }
            }
            return firstElement;
        }
    }
}
