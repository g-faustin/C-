using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_figure_ConsoleApp
{
    class Cercle
    {
        private Point point;
        private int centre;
        private int rayon;
        private const int PI = 14;

        public Cercle(Point point, int centre)
        {
            this.point = point;
            this.centre = centre;
        }

        public Cercle(int centre, int rayon)
        {
            this.centre = centre;
            this.rayon = rayon;
        }

        public int getPerimetre()
        {
            return 2 * PI * rayon;
        }

        public int getSurface()
        {
            return 2 * rayon * rayon;
        }

        public bool appartient(Point p)
        {
            return true;
        }

        public override string ToString()
        {
            return "Cercle("+point.X+","+point.Y+","+point.X+")";
        }
    }
}
