using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Scene
    {
        public void Rendor(List<string[]> frame)
        {
            Console.Clear();

            for (int counter = 0; counter < frame.Count; ++counter)
                Console.WriteLine(String.Join("", frame[counter]));
        }
    }
}
