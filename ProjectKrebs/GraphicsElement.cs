using System;
using System.Drawing;

namespace ProjectKrebs
{
    class GraphicsElement
    {
        string Graphics;
        public static int[] LaneYOffset = { 0, 100, 200, 300, 400 };//Vrv ce biti promenjeno
        double Distance;
        public GraphicsElement(string Graphics,double Distance)
        {
            this.Graphics = Graphics;
            this.Distance = Distance;
        }
        public bool OnScreen
        {
            get { return Distance > 0; }
        }
        public void Move(double x)
        {
            Distance -= x;
        }
        public void Draw(Graphics e)
        {
            throw new NotImplementedException();
        }
    }
}
