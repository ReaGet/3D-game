using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3D_game_in_console
{
    class Rectangle
    {
        private float x, y, width, height, rotation;

        public Rectangle() { }

        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

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

        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public float WIDTH
        {
            get { return width; }
            set { width = value; }
        }

        public float HEIGHT
        {
            get { return height; }
            set { height = value; }
        }


    }
}
