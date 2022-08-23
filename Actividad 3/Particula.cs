using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    public class Particula
    {
        Point pos;
        Vertice v;
        public Particula(Point p,Vertice ver)
        {
            pos = p;
            v = ver;
        }
        public Particula()
        {
            
        }
        public Point getPoint()
        {
            return pos;
        }
        public Vertice getVertice()
        {
            return v;
        }
        public void setPoint(Point p)
        {
            pos=p;
        }
        public void setVertice(Vertice ver)
        {
            v = ver;
        }


    }
}
