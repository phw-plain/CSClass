using System;

namespace CSClass
{
    internal class Box
    {
        private int width;
        public int height;
        public Box(int w, int h)
        {
            this.setWidth(w);
            this.setHeight(h);
        }

        public int foo { get; set; }

        public int Area
        {
            get { return this.width * this.height; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        /* public int getWidth()
         {
             return width;
         }*/

        public int getHeight()
        {
            return height;
        }
        public void setWidth(int w)
        {
            if (w > 0)
            {
                this.width = w;
            }
            else
            {
                Console.WriteLine("Box의 가로는 양수여야 합니다.");
            }
        }
        public void setHeight(int h)
        {
            if (h > 0)
            {
                this.height = h;
            }
            else
            {
                Console.WriteLine("Box의 세로는 양수여야 합니다.");
            }
        }

        internal int getArea()
        {
            return this.width * this.height;
        }
    }
}