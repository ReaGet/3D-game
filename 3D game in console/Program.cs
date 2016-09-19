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
        static Bitmap img = new Bitmap(30, 20);
        static Graphics g = Graphics.FromImage(img);
        static int FPS = 30;

        static void Main(string[] args)
        {
            g.DrawArc(Pens.White, 0, 0, 10, 10, 0, 360);
            Loop();
            
        }

        static void Loop() {
            while (true)
            {
                Update();
                Render();

                Thread.Sleep(1000 / FPS);
            }
        }

        static void Update() {
        
        }

        static void Render() {
            Console.Clear();
            string output = "";
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    var pixel = img.GetPixel(x, y);
                    if (pixel.A != 255)
                        output += " ";
                    else
                        output += "@";
                }
                output += "\n";
            }
            Console.Write(output);
        }
    }
}
