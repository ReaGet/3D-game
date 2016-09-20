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
            Point[] points = { new Point((int)rect.X, (int)rect.Y),
                               new Point((int)(rect.X + rect.WIDTH), (int)rect.Y),
                               new Point((int)(rect.X + rect.WIDTH), (int)(rect.Y + rect.HEIGHT)),
                               new Point((int)(rect.X), (int)(rect.Y + rect.HEIGHT)) };
            

            line(points[0], points[1]);
            line(points[1], points[2]);
            line(points[2], points[3]);
            line(points[3], points[0]);

            /*line(rect.X, rect.Y, rect.X + rect.WIDTH, rect.Y);
            line(rect.X + rect.WIDTH, rect.Y, rect.X + rect.WIDTH, rect.Y + rect.HEIGHT);
            line(rect.X + rect.WIDTH, rect.Y + rect.HEIGHT, rect.X, rect.Y + rect.HEIGHT);
            line(rect.X, rect.Y + rect.HEIGHT, rect.X, rect.Y);*/
        }
        public void rect(float x, float y, float width, float height)
        {
            //g.DrawRectangle(Pens.White, x, y, width, height);
            line(x, y, x + width, y);
            line(x + width, y, x + width, y + height);
            line(x + width, y + height, x, y + height);
            line(x, y + height, x, y);
        }

        public void line(Point p1, Point p2)
        {
            g.DrawLine(Pens.White, p1, p2);
        }

        public void line(float x1, float y1, float x2, float y2)
        {
            g.DrawLine(Pens.White, new Point((int)x1, (int)y1), new Point((int)x2, (int)y2));
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