using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace _3D_game_in_console
{
    class Draw
    {
        Bitmap img;
        Graphics g;
        string output;
        //    g.DrawArc(Pens.White, 0, 0, 10, 10, 0, 360);

        public Draw()
        {
            img = new Bitmap(79, 20);
            g = Graphics.FromImage(img);
            output = "";
        }

        public void clear() 
        {
            Console.Clear();
        }

        public void rect(Rectangle rect)
        {
            g.DrawRectangle(Pens.White, rect.X, rect.Y, rect.WIDTH, rect.HEIGHT);
        }
        public void rect(float x, float y, float width, float height)
        {
            g.DrawRectangle(Pens.White, x, y, width, height);
        }

        public void render()
        {
            output = "";
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
            g.Clear(Color.Transparent);
        }
    }
}