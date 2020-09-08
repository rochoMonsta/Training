using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Targets
{
    class Hero : Target
    {
        #region Constructors
        public Hero() { }
        public Hero(string TargetSymbol) : base(TargetSymbol) { }
        public Hero(string TargetSymbol, int TargetCoordinateX, int TargetCoordinateY) 
                  : base(TargetSymbol, TargetCoordinateX, TargetCoordinateY) { }
        #endregion
        #region Methods
        public void HeroShot(List<string[]> frame, Scene scene)
        {
            var bullet = new Bullet("^", this.TargetCoordinateX, this.TargetCoordinateY - 1, frame);
            bullet.MoveBulletAsync(frame, scene);
        }
        #endregion
    }
}
