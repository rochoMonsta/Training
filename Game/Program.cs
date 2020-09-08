using Game.Targets;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static Scene Scene = new Scene();
        static Levels Levels = new Levels();
        static Hero Hero = new Hero("H");
        static Asteroid asteroid = new Asteroid("*");
        static ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        static void Main(string[] args)
        {
            Levels.GenerateLevel1();
            Scene.Rendor(Levels.Frame);

            Hero.GetTargetCoordinates(Levels.Frame);

            asteroid.SpawnAsteroidAsync(Levels.Frame, false, Scene);
            GetKeyAsync();
            while (true)
            {
                //var keyInfo = Console.ReadKey();
                Hero.MoveTarget(keyInfo, Levels.Frame, Scene);
                keyInfo = new ConsoleKeyInfo();
                Thread.Sleep(100);
                Scene.Rendor(Levels.Frame);
            }
        }
        static async void GetKeyAsync() => await Task.Run(() => GetKey());
        static void GetKey()
        {
            while (true) { keyInfo = Console.ReadKey(); }
        }
    }
}
