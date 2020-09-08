using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.Targets
{
    class Bullet : Target
    {
        #region Constructors
        public Bullet() { }
        public Bullet(string TargetSymbol) : base(TargetSymbol) { }
        public Bullet(string TargetSymbol, int TargetCoordinateX, int TargetCoordinateY, List<string[]> frame)
                    : base(TargetSymbol, TargetCoordinateX, TargetCoordinateY) 
        {
            frame[this.TargetCoordinateY][this.TargetCoordinateX] = this.TargetSymbol;
        }
        #endregion

        #region Methods
        public async Task MoveBulletAsync(List<string[]> frame, Scene scene)
        {
            await Task.Run(() => MoveBullet(frame, scene));
        }
        private void MoveBullet(List<string[]> frame, Scene scene)
        {
            string emptyCell = " ";
            while (frame[this.TargetCoordinateY - 1][this.TargetCoordinateX] == emptyCell && this.TargetCoordinateY - 1 >= 0)
            {
                frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
                frame[this.TargetCoordinateY - 1][this.TargetCoordinateX] = this.TargetSymbol;

                this.TargetCoordinateY -= 1;
                Thread.Sleep(100);
                //scene.Rendor(frame);
            }
            frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
            //scene.Rendor(frame);
        }
        #endregion
    }
}
