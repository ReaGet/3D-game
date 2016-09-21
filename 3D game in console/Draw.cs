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

            float cx = rect.X + rect.WIDTH / 2,
                  cy = rect.Y + rect.HEIGHT / 2;
            double angle = rect.Rotation;
            /*
            // UL
            points[0].X = (int)((points[0].X - cx) * Math.Cos(angle) - (points[0].Y - cy) * Math.Sin(angle) + cx);
            points[0].Y = (int)((points[0].Y - cy) * Math.Cos(angle) + (points[0].X - cx) * Math.Sin(angle) + cy);
            // UR
            points[1].X = (int)((points[1].X - cx) * Math.Cos(angle) - (points[1].Y - cy) * Math.Sin(angle) + cx);
            points[1].Y = (int)((points[1].Y - cy) * Math.Cos(angle) + (points[1].X - cx) * Math.Sin(angle) + cy);
            // BL
            points[2].X = (int)((points[2].X - cx) * Math.Cos(angle) - (points[2].Y - cy) * Math.Sin(angle) + cx);
            points[2].Y = (int)((points[2].Y - cy) * Math.Cos(angle) + (points[2].X - cx) * Math.Sin(angle) + cy);
            // BR
            points[3].X = (int)((points[3].X - cx) * Math.Cos(angle) - (points[3].Y - cy) * Math.Sin(angle) + cx);
            points[3].Y = (int)((points[3].Y - cy) * Math.Cos(angle) + (points[3].X - cx) * Math.Sin(angle) + cy);
            */

            // UL
            points[0].X = (int)((points[0].X - cx) * Math.Cos(angle) - (points[0].Y - cy) * Math.Sin(angle) + cx);
            points[0].Y = (int)((points[0].Y - cy) * Math.Cos(angle) + (points[0].X - cx) * Math.Sin(angle) + cy);
            // UR
            points[1].X = (int)((points[1].X - cx) * Math.Cos(angle) - (points[1].Y - cy) * Math.Sin(angle) + cx);
            points[1].Y = (int)((points[1].Y - cy) * Math.Cos(angle) + (points[1].X - cx) * Math.Sin(angle) + cy);
            // BL
            points[2].X = (int)((points[2].X - cx) * Math.Cos(angle) - (points[2].Y - cy) * Math.Sin(angle) + cx);
            points[2].Y = (int)((points[2].Y - cy) * Math.Cos(angle) + (points[2].X - cx) * Math.Sin(angle) + cy);
            // BR
            points[3].X = (int)((points[3].X - cx) * Math.Cos(angle) - (points[3].Y - cy) * Math.Sin(angle) + cx);
            points[3].Y = (int)((points[3].Y - cy) * Math.Cos(angle) + (points[3].X - cx) * Math.Sin(angle) + cy);

            line(points[0], points[1]);
            line(points[1], points[2]);
            line(points[2], points[3]);
            line(points[3], points[0]);
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