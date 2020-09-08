using Game.Targets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Target
    {
        #region Fields
        public string TargetSymbol { get; set; }
        public int TargetCoordinateX { get; set; }
        public int TargetCoordinateY { get; set; }
        #endregion

        #region Constructors
        public Target() { }
        public Target(string TargetSymbol)
        {
            if (String.IsNullOrWhiteSpace(TargetSymbol))
                throw new ArgumentNullException($"Uncorrect symbol: {nameof(TargetSymbol)}");

            this.TargetSymbol = TargetSymbol;
        }

        public Target(string TargetSymbol, int TargetCoordinateX, int TargetCoordinateY) : this (TargetSymbol)
        {
            if (TargetCoordinateX < 0 || TargetCoordinateX > 24)
                throw new ArgumentException($"This coordinate not included in the level area: {nameof(TargetCoordinateX)}");

            if (TargetCoordinateY < 0 || TargetCoordinateY > 24)
                throw new ArgumentException($"This coordinate not included in the level area: {nameof(TargetCoordinateY)}");

            this.TargetCoordinateX = TargetCoordinateX;
            this.TargetCoordinateY = TargetCoordinateY;
        }
        #endregion

        #region Methods
        public void GetTargetCoordinates(List<string[]> frame)
        {
            for (int counter = 0; counter < frame.Count - 1; ++counter)
            {
                var hash = new HashSet<string>(frame[counter]);
                if (hash.Contains(TargetSymbol))
                {
                    TargetCoordinateX = Array.IndexOf(frame[counter], TargetSymbol);
                    TargetCoordinateY = counter;
                }
            }
        }
        public void MoveTarget(ConsoleKeyInfo buttonPressed, List<string[]> frame, Scene scene)
        {
            string emptyCell = " ";
            switch (buttonPressed.Key)
            {
                case ConsoleKey.UpArrow: 
                    MoveTargetUp(frame, emptyCell); break;
                case ConsoleKey.DownArrow:
                    MoveTargetDown(frame, emptyCell); break;
                case ConsoleKey.LeftArrow:
                    MoveTargetLeft(frame, emptyCell); break;
                case ConsoleKey.RightArrow:
                    MoveTargetRight(frame, emptyCell); break;
                case ConsoleKey.Spacebar:
                    if (this is Hero)
                    {
                        var heroCopy = this as Hero;
                        heroCopy.HeroShot(frame, scene);
                    };
                    break;
            }
            //scene.Rendor(frame);
        }
        #region Moving the target by coordinates
        /// <summary>
        /// This method moves our target upwards under certain conditions
        /// </summary>
        /// <param name="frame" - level field></param>
        /// <param name="emptyCell" - empty cell></param>
        private void MoveTargetUp(List<string[]> frame, string emptyCell)
        {
            if (this.TargetCoordinateY - 1 >= 0 && frame[this.TargetCoordinateY - 1][this.TargetCoordinateX] == emptyCell)
            {
                frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
                frame[this.TargetCoordinateY - 1][this.TargetCoordinateX] = this.TargetSymbol;

                this.TargetCoordinateY -= 1;
            }
        }
        /// <summary>
        /// This method moves our target down under certain conditions
        /// </summary>
        /// <param name="frame" - level field></param>
        /// <param name="emptyCell" - empty cell></param>
        private void MoveTargetDown(List<string[]> frame, string emptyCell)
        {
            if (this.TargetCoordinateY + 1 <= 24 && frame[this.TargetCoordinateY + 1][this.TargetCoordinateX] == emptyCell)
            {
                frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
                frame[this.TargetCoordinateY + 1][this.TargetCoordinateX] = this.TargetSymbol;

                this.TargetCoordinateY += 1;
            }
        }
        /// <summary>
        /// This method moves our target left under certain conditions
        /// </summary>
        /// <param name="frame" - level field></param>
        /// <param name="emptyCell" - empty cell></param>
        private void MoveTargetLeft(List<string[]> frame, string emptyCell)
        {
            if (this.TargetCoordinateX - 1 >= 0 && frame[this.TargetCoordinateY][this.TargetCoordinateX - 1] == emptyCell)
            {
                frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
                frame[this.TargetCoordinateY][this.TargetCoordinateX - 1] = this.TargetSymbol;

                this.TargetCoordinateX -= 1;
            }
        }
        /// <summary>
        /// This method moves our target right under certain conditions
        /// </summary>
        /// <param name="frame" - level field></param>
        /// <param name="emptyCell" - empty cell></param>
        private void MoveTargetRight(List<string[]> frame, string emptyCell)
        {
            if (this.TargetCoordinateX + 1 <= 24 && frame[this.TargetCoordinateY][this.TargetCoordinateX + 1] == emptyCell)
            {
                frame[this.TargetCoordinateY][this.TargetCoordinateX] = emptyCell;
                frame[this.TargetCoordinateY][this.TargetCoordinateX + 1] = this.TargetSymbol;

                this.TargetCoordinateX += 1;
            }
        }
        #endregion
        #endregion
    }
}
