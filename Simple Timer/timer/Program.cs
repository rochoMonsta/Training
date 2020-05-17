using System;
using System.Linq;

namespace testw
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();

            Console.Write("Введiть годину в форматi (година:хвилина:секунда): ");
            var UserTimerTime = Console.ReadLine().Split(':').Select(item => Int32.Parse(item)).ToArray();

            timer.GetTimeForTimer(UserTimerTime[0], UserTimerTime[1], UserTimerTime[2]);

            timer.WaitForAlarm();

            Console.ReadLine();
        }
    }
}
