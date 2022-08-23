using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    public class Grafo
    {
        List<Vertice> lv;
        Bitmap imgGrafo;
        public Grafo(List<Point> lp, Bitmap img)
        {
            lv = new List<Vertice>();
            int cont = 0;
            imgGrafo = img;
            foreach (Point p in lp)
            {
                cont++;
                Vertice v = new Vertice(p, cont);
                lv.Add(v);
            }

            foreach (Vertice origen in lv)
            {
                foreach (Vertice destino in lv)
                {
                    if (origen != destino)
                    {
                        int x2 = existeA2(origen, destino);
                        if (x2 == 0 || x2 ==2)
                        {
                            double peso = Math.Sqrt(Math.Pow((destino.getPoint().X - origen.getPoint().X), 2) + Math.Pow((destino.getPoint().Y - origen.getPoint().Y), 2));
                            Arista a = new Arista(destino, peso);
                            origen.insertaArista(a);
                        }
                    }
                }
            }
        }
        public List<Vertice> getLV()
        {
            return lv;
        }
        
        public int existeA2(Vertice origen, Vertice destino)
        {
            double m;
            int ban;
            double b;
            ban = 0;
            int xi, xf, yi, yf;
            xi = origen.getPoint().X;
            xf = destino.getPoint().X;
            yi = origen.getPoint().Y;
            yf = destino.getPoint().Y;
            m = ((double)yf - (double)yi) / ((double)xf - (double)xi);
            
            b = destino.getPoint().Y - (m * destino.getPoint().X);

            if (m > 1||m<-1)
            {
                if (origen.getPoint().Y <= destino.getPoint().Y)
                {
                    ban = 0;
                    for (int x = origen.getPoint().Y; x <= destino.getPoint().Y; x++)
                    {
                        double r = ((x - b) / m);
                        
                        int yk = (int)r;
                        if (imgGrafo.GetPixel(yk, x).B == 255 && imgGrafo.GetPixel(yk, x).R != 255 && imgGrafo.GetPixel(yk,x).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(yk + 1,x).B ==255 && imgGrafo.GetPixel(yk + 1,x).R != 255 && imgGrafo.GetPixel(yk + 1,x).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(yk - 1,x).B == 255 && imgGrafo.GetPixel(yk - 1,x).R != 255 && imgGrafo.GetPixel(yk - 1,x).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(yk, x).B == 255 && imgGrafo.GetPixel(yk, x).R == 255 && imgGrafo.GetPixel(yk, x).G == 255 && ban == 0)
                        {
                            ban = 1;
                        }
                        if (imgGrafo.GetPixel(yk, x).B == 0 && imgGrafo.GetPixel(yk, x).R == 0 && imgGrafo.GetPixel(yk, x).G == 0 && ban == 1)
                        {
                            ban = 2;
                        }
                        if (imgGrafo.GetPixel(yk, x).B == 255 && imgGrafo.GetPixel(yk, x).R == 255 && imgGrafo.GetPixel(yk, x).G == 255 && ban == 2)
                        {
                            ban = 1; 
                            return ban;
                        }

                    }

                }

                else
                {
                    ban = 0;
                    for (int x = origen.getPoint().Y; x >= destino.getPoint().Y; x--)
                    {
                        double r = ((x - b) / m);
                        r = Math.Round(r);
                        int yk = (int)r;
                        if (imgGrafo.GetPixel(yk, x).B == 255 && imgGrafo.GetPixel(yk, x).R != 255 && imgGrafo.GetPixel(yk, x).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(yk + 1, x).B == 255 && imgGrafo.GetPixel(yk + 1, x).R != 255 && imgGrafo.GetPixel(yk + 1, x).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(yk - 1, x).B == 255 && imgGrafo.GetPixel(yk - 1, x).R != 255 && imgGrafo.GetPixel(yk - 1, x).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(yk, x).B == 255 && imgGrafo.GetPixel(yk, x).R == 255 && imgGrafo.GetPixel(yk, x).G == 255 && ban == 0)
                        {
                            ban = 1;
                        }
                        if (imgGrafo.GetPixel(yk, x).B == 0 && imgGrafo.GetPixel(yk, x).R == 0 && imgGrafo.GetPixel(yk, x).G == 0 && ban == 1)
                        {
                            ban = 2;
                        }
                        if (imgGrafo.GetPixel(yk, x).B == 255 && imgGrafo.GetPixel(yk, x).R == 255 && imgGrafo.GetPixel(yk, x).G == 255 && ban == 2)
                        {
                            ban = 1;
                            return ban;
                        }



                    }
                }
            }
            else if (m <= 1 && m >= -1)
            {
                if (origen.getPoint().X <= destino.getPoint().X)
                {
                    ban = 0;
                    for (int x = origen.getPoint().X; x <= destino.getPoint().X; x++)
                    {

                        double r = (m * x + b);

                        r = Math.Round(r);
                        int yk = (int)r;
                        if (imgGrafo.GetPixel(x, yk).B == 255 && imgGrafo.GetPixel(x, yk).R != 255 && imgGrafo.GetPixel(x,yk).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if(imgGrafo.GetPixel(x, yk+1).B == 255 && imgGrafo.GetPixel(x, yk+1).R != 255 && imgGrafo.GetPixel(x, yk+1).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if(imgGrafo.GetPixel(x, yk-1).B == 255 && imgGrafo.GetPixel(x, yk-1).R != 255 && imgGrafo.GetPixel(x, yk-1).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(x, yk).B == 255 && imgGrafo.GetPixel(x, yk).R == 255 && imgGrafo.GetPixel(x, yk).G == 255 && ban == 0)
                        {
                            ban = 1;
                        }
                        if (imgGrafo.GetPixel(x, yk).B == 0 && imgGrafo.GetPixel(x, yk).R == 0 && imgGrafo.GetPixel(x, yk).G == 0 && ban == 1)
                        {
                            ban = 2;
                        }
                        if (imgGrafo.GetPixel(x, yk).B == 255 && imgGrafo.GetPixel(x, yk).R == 255 && imgGrafo.GetPixel(x, yk).G == 255 && ban == 2)
                        {
                            ban = 1;
                            return ban;
                        }

                    }
                }
                else
                {
                    ban = 0;
                    for (int x = origen.getPoint().X; x >= destino.getPoint().X; x--)
                    {
                        double r = (m * x + b);
                        r = Math.Round(r);
                        int yk = (int)r;
                        
                        if (imgGrafo.GetPixel(x, yk).B == 255 && imgGrafo.GetPixel(x, yk).R != 255 && imgGrafo.GetPixel(x, yk).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(x, yk + 1).B == 255 && imgGrafo.GetPixel(x, yk + 1).R != 255 && imgGrafo.GetPixel(x, yk + 1).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(x, yk - 1).B == 255 && imgGrafo.GetPixel(x, yk - 1).R != 255 && imgGrafo.GetPixel(x, yk - 1).G != 255)
                        {
                            ban = 1;
                            return ban;
                        }
                        if (imgGrafo.GetPixel(x, yk).B == 255 && imgGrafo.GetPixel(x, yk).R == 255 && imgGrafo.GetPixel(x, yk).G == 255 && ban == 0)
                        {
                            ban = 1;
                        }
                        if (imgGrafo.GetPixel(x, yk).B == 0 && imgGrafo.GetPixel(x, yk).R == 0 && imgGrafo.GetPixel(x, yk).G == 0 && ban == 1)
                        {
                            ban = 2;
                        }
                        if (imgGrafo.GetPixel(x, yk).B == 255 && imgGrafo.GetPixel(x, yk).R == 255 && imgGrafo.GetPixel(x, yk).G == 255 && ban == 2)
                        {
                            ban = 1;
                            return ban;
                        }

                    }
                }
            }
            return 0;
        }




    }

    public class Vertice
    {
        List<Arista> la;
        int nombre;
        Point p;
        public Vertice(Point p, int c)
        {
            this.la = new List<Arista>();
            this.p = p;
            this.nombre = c;
        }
        public Point getPoint()
        {
            return this.p;
        }
        public int getNombre()
        {
            return this.nombre;
        }
        public void insertaArista(Arista a)
        {
            this.la.Add(a);
        }
        public List<Arista> getLA()
        {
            return la;
        }
    }

    public class Arista
    {
        double ponderacion;
        Vertice v;

        public Arista(Vertice v, double peso)
        {
            this.v = v;
            ponderacion = peso;
        }
        public Vertice getV()
        {
            return v;
        }
        public double getP()
        {
            return ponderacion;
        }
        public String toS()
        {
            string c = getV().getNombre() + ":" + Math.Round(ponderacion, 1);
            return c;
        }
    }
}
