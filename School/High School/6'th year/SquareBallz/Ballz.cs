using System;
using System.Collections.Generic;
using System.Drawing;

namespace Balletjes
{
    internal class Ballz
    {
        public Point Location;
        public readonly int Size;
        private readonly Brush _br;
        public int GoX;
        public int GoY;
        public int id;

        public static int lastId;
        public static List<Ballz> All;
        public static Action collisionDetected;

        public Ballz(Point location, Color color, int size)
        {
            this.Location = location;
            this.Size = size;
            this._br = new SolidBrush(color);
            this.id = Ballz.lastId++;

            // We need to manually set the dynamic seed to get more "true" randomness.
            Random rn = new Random(DateTime.Now.Millisecond + size);

            do
            {
                this.GoX = rn.Next(-1, 2);
                this.GoY = rn.Next(-1, 2);
            } while (this.GoX == 0 || this.GoY == 0);
        }

        public void Draw()
            => GraphicsHandler.graphic.FillRectangle(this._br, this.Location.X, this.Location.Y, this.Size, this.Size);

        public void PerformStep()
        {
            this.Location.X += this.GoX;
            this.Location.Y += this.GoY;

            if (this.Location.Y <= GraphicsHandler.panel.Location.Y ||
                this.Location.Y + this.Size >= GraphicsHandler.panel.Location.Y + GraphicsHandler.panel.Height)
                this.GoY = -this.GoY;
            if (this.Location.X <= GraphicsHandler.panel.Location.X ||
                this.Location.X + this.Size >= GraphicsHandler.panel.Location.X + GraphicsHandler.panel.Width)
                this.GoX = -this.GoX;

            this.HandleCollision();
        }

        private void HandleCollision()
        {
            Rectangle current = this.Rectangle();
            Ballz[] selected = new Ballz[Ballz.All.Count];
            Ballz.All.CopyTo(selected);

            foreach (Ballz circle in selected)
            {
                if (circle.id != this.id && current.IntersectsWith(circle.Rectangle()))
                {
                    // Prevent inside looping
                    // if (!(circle.GoX != this.GoX && circle.GoY != this.GoY)) continue;;

                    // Manually handle all cases... yes I know this is probably the worst way to handle this!
                    this.GoX = -this.GoX;
                    this.GoY = -this.GoY;

                    Console.WriteLine(@"collision detected");
                    Console.WriteLine($@"Circle: {circle.Location.X}-{circle.Location.Y}");
                    Console.WriteLine($@"Circle: {circle.GoX}-{circle.GoY}");
                    Console.WriteLine($@"Current: {this.Location.X}-{this.Location.Y}");
                    Console.WriteLine($@"Current: {this.GoX}-{this.GoY}");
                    Console.WriteLine(@"------------------");

                    if (Ballz.lastId >= 300) continue;
                    Ballz.collisionDetected();
                }
            }
        }

        public Rectangle Rectangle() => new Rectangle(this.Location, new Size(this.Size, this.Size));
    }
}