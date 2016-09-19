using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3D_game_in_console
{
    class Vector2D
    {
        private float x, y;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public Vector2D() {
            x = y = 0f;
        }

        public Vector2D(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public void set(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public void add(Vector2D vec)
        {
            this.x += vec.X;
            this.y += vec.Y;
        }

        public float length 
        {
            get
            {
                double length = this.x * this.x + this.y * this.y;
                return (float)Math.Sqrt(length);
            }
        }

        public void normalize()
        {
            double sum = this.x * this.x + this.y * this.y;
            double length = Math.Sqrt(sum);
            if (length != 0)
            {
                this.x = this.x / (float)length;
                this.y = this.y / (float)length;
            }
        }

    }
}
