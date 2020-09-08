using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.Targets
{
    class Asteroid : Target
    {
        public Asteroid() { }
        public Asteroid(string TargetSymbol) : base (TargetSymbol) { }
        public Asteroid(string TargetSymbol, int TargetCoordinateX, int TargetCoordinateY)
                      : base(TargetSymbol, TargetCoordinateX, TargetCoordinateY) { }
        public async void SpawnAsteroidAsync(List<string[]> frame, bool isGameOver, Scene scene)
        {
            await Task.Run(() => SpawnAsteroid(frame, isGameOver, scene));
        }
        private void SpawnAsteroid(List<string[]> frame, bool isGameOver, Scene scene)
        {
            Random random = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            while (!isGameOver)
            {
                var coordinateX = random.Next(1, 24);
                var asteroid = new Asteroid("*", coordinateX, 1);
                asteroid.MoveAsteroidAsync(frame, scene);

                Thread.Sleep(1500);
            }
        }
        private async void MoveAsteroidAsync(List<string[]> frame, Scene scene)
        {
            await Task.Run(() => MoveAsteroid(frame, scene));
        }
        private void MoveAsteroid(List<string[]> frame, Scene scene)
        {
            string emptyCell = " ";
            while (frame[this.TargetCoordinateY + 1][this.TargetCoordinateX] == emptyCell && this.TargetCoordinateY + 1 <= 24)
            {
                frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
                frame[this.TargetCoordinateY + 1][this.TargetCoordinateX] = this.TargetSymbol;

                this.TargetCoordinateY += 1;
                Thread.Sleep(100);
                //scene.Rendor(frame);
            }
            frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
            //scene.Rendor(frame);
        }
    }
}
