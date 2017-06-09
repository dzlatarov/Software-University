namespace _6.Rectangle_Position
{
    public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Right
        {
            get
            {
                return this.Width + this.Left;
            }
        }

        public int Bottom
        {
            get
            {
                return this.Height + this.Top;
            }
        }
    }
}
