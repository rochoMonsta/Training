using System;

namespace testw
{
    class Timer
    {
        private int Hours { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }
        public Timer() { }
        public Timer(int Hours, int Minutes, int Seconds)
        {
            if (Hours >=0 && Hours < 24)
                this.Hours = Hours;
            else
                Console.WriteLine("Невiрно введений формат години!");

            if (Minutes >=0 && Minutes < 60)
                this.Minutes = Minutes;
            else
                Console.WriteLine("Невiрно введений формат хвилини!");

            if (Seconds >= 0 && Seconds < 60)
                this.Seconds = Seconds;
            else
                Console.WriteLine("Невiрно введений формат секунди!");
        }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
        //Передача конкретної години, хвилини, секунди для таймеру
        public void GetTimeForTimer(int Hours, int Minutes, int Seconds)
        {
            if (Hours >= 0 && Hours < 24)
                this.Hours = Hours;
            else
                Console.WriteLine("Невiрно введений формат години!");

            if (Minutes >= 0 && Minutes < 60)
                this.Minutes = Minutes;
            else
                Console.WriteLine("Невiрно введений формат хвилини!");

            if (Seconds >= 0 && Seconds < 60)
                this.Seconds = Seconds;
            else
                Console.WriteLine("Невiрно введений формат секунди!");
        }
        //Таймер
        public void WaitForAlarm()
        {
            while (true)
                if (CheckForPresentTimeIsUserTime())
                {
                    GetAlarm();
                    break;
                }

        }
        //Метод який виконує перевірку на задану годину
        private bool CheckForPresentTimeIsUserTime()
        {
            if (Hours == DateTime.Now.Hour && Minutes == DateTime.Now.Minute && Seconds == DateTime.Now.Second)
                return true;
            else
                return false;
        }
        //Метод який виконує симуляцію сигналу протягом 1 хвилини
        private void GetAlarm()
        {
            Console.WriteLine("Alarm! Alarm! Alarm! Alarm! Alarm! Alarm!");
            for (int i = 0; i < 120; ++i)
            {
                Console.Beep();
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
