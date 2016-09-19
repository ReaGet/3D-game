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
        static Rectangle rect;
        static int FPS = 30;

        public static Vector2D pos = new Vector2D();

        static void Main(string[] args)
        {
            rect = new Rectangle(0, 0, 10, 10);
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

        static float vx = 1,
                     vy = 1;
        static void Update()
        {
            rect.X += vx;
            rect.Y += vy;
            if (rect.X < 0 || rect.X + rect.WIDTH + 1 > 79)
                vx *= -1;
            if (rect.Y < 0 || rect.Y + rect.HEIGHT + 1> 20)
                vy *= -1;
        }

        static void Render()
        {
            draw.clear();
            draw.rect(rect);

            draw.render();
        }
    }
}
