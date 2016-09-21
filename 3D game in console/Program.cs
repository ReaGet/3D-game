using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace _3D_game_in_console
{
    class Program
    {
        static Draw draw = new Draw();
        static Rectangle rect2;
        static int FPS = 30;

        public static Vector2D pos = new Vector2D();

        static void Main(string[] args)
        {
            rect2 = new Rectangle(7, 5, 10, 10);
            Loop();   
        }

        static void Loop()
        {
            while (true)
            {
                Update();
                Render();

                Thread.Sleep(1000 / FPS);
            }
        }

        static void Update()
        {

        }

        static void Render()
        {
            draw.clear();
            rect2.Rotation += 0.1f;
            draw.rect(rect2);

            draw.render();
        }
    }
}
