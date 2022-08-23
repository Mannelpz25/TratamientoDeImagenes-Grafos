using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3
{
    public partial class infGrafo : Form
    {
        Grafo g;
        Bitmap imgGrafo;
        Particula p = new Particula();
        string sel;
        Graphics c;
        Brush b = new SolidBrush(Color.Red);

        public infGrafo(Bitmap b, Grafo g)
        {
            string aristas = "";
            InitializeComponent();
            imgGrafo = new Bitmap( b);
           
            pictureBox1.BackgroundImage = b;
            pictureBox1.Image = imgGrafo;
            sel = "";
            this.g = g;
            c = Graphics.FromImage(imgGrafo);
            foreach (Vertice v in g.getLV())
            {
                foreach (Arista a in v.getLA())
                {
                    aristas = aristas + a.toS() + "     ";             
                    
                }
                verticeListbox.Items.Add(v.getNombre());
                aristaListbox.Items.Add(aristas);
                aristas = "";
            }
        }

        private void verticeListbox_MouseClick(object sender, EventArgs e)
        {
            int ban = 0;
            sel = verticeListbox.SelectedItem.ToString();
            if(!particulaButton.Enabled)
            {
                foreach (Vertice v in g.getLV())
                {
                    if (sel == v.getNombre().ToString())
                    {
                        foreach (Arista a in p.getVertice().getLA())
                        {
                            if (a.getV().getNombre() == v.getNombre())
                            {
                                movimiento(p.getVertice(), a.getV());
                                p.setPoint(a.getV().getPoint());
                                p.setVertice(a.getV());
                                ban = 1;
                                break;
                            }

                        }
                    }
                }
                if(ban==1)
                {
                    
                    c.Clear(Color.Empty);
                    c.FillEllipse(b, p.getPoint().X - 9, p.getPoint().Y - 9, 18, 18);
                    pictureBox1.Image = imgGrafo;
                    mensajeLabel.Text = "Seleccione un vertice para moverse";
                }
                else
                {
                    mensajeLabel.Text = "El vertice seleccionado no es adyacente al vertice actual";
                }

            }

        }

        private void particulaButton_Click(object sender, EventArgs e)
        {
            if (sel == "")
            {
                mensajeLabel.Text = "Seleccione un vertice y pulsa el boton";
            }
            else if(particulaButton.Enabled)
            {
                particulaButton.Enabled = false;
                foreach (Vertice v in g.getLV())
                {
                    if (sel == v.getNombre().ToString())
                    {
                        p = new Particula(v.getPoint(),v);
                    }
                }
                c.FillEllipse(b, p.getPoint().X - 9, p.getPoint().Y - 9, 18, 18);
                pictureBox1.Image = imgGrafo;
                mensajeLabel.Text = "Seleccione un vertice para moverse";
            }
        }
        public void movimiento(Vertice origen, Vertice destino)
        {
            double m;
            double b2;
            int xi, xf, yi, yf;
            xi = origen.getPoint().X;
            xf = destino.getPoint().X;
            yi = origen.getPoint().Y;
            yf = destino.getPoint().Y;
            m = ((double)yf - (double)yi) / ((double)xf - (double)xi);
            int s = 0;
            b2 = destino.getPoint().Y - (m * destino.getPoint().X);

            if (m > 1 || m < -1)
            {
                if (origen.getPoint().Y <= destino.getPoint().Y)
                {
                    for (int x = origen.getPoint().Y; x <= destino.getPoint().Y; x++)
                    {

                        pictureBox1.Refresh();
                        double r = ((x - b2) / m);

                        int yk = (int)r;
                        c.Clear(Color.Empty);
                        c.FillEllipse(b, yk - 9, x - 9, 18, 18);
                        pictureBox1.Image = imgGrafo;
                        s++;
                        mensajeLabel.Text = s.ToString();
                        System.Threading.Thread.Sleep(1);



                    }

                }

                else
                {
                    for (int x = origen.getPoint().Y; x >= destino.getPoint().Y; x--)
                    {

                        pictureBox1.Refresh();
                        double r = ((x - b2) / m);
                        r = Math.Round(r);
                        int yk = (int)r;
                        c.Clear(Color.Empty);
                        c.FillEllipse(b, yk - 9, x - 9, 18, 18);
                        pictureBox1.Image = imgGrafo;
                        s++;
                        mensajeLabel.Text = s.ToString();

                        System.Threading.Thread.Sleep(1);

                    }
                }
            }
            else if (m <= 1 && m >= -1)
            {
                if (origen.getPoint().X <= destino.getPoint().X)
                {
                    for (int x = origen.getPoint().X; x <= destino.getPoint().X; x++)
                    {

                        pictureBox1.Refresh();

                        double r = (m * x + b2);

                        r = Math.Round(r);
                        int yk = (int)r;

                        c.Clear(Color.Empty);
                        c.FillEllipse(b, x - 9, yk - 9, 18, 18);
                        pictureBox1.Image = imgGrafo;
                        s++;
                        mensajeLabel.Text = s.ToString();
                        System.Threading.Thread.Sleep(1);
                    }
                }
                else
                {
                    for (int x = origen.getPoint().X; x >= destino.getPoint().X; x--)
                    {
                        pictureBox1.Refresh();
                        double r = (m * x + b2);
                        r = Math.Round(r);
                        int yk = (int)r;
                        c.Clear(Color.Empty);
                        c.FillEllipse(b, x - 9, yk - 9, 18, 18);
                        pictureBox1.Image = imgGrafo;
                        s++;
                        mensajeLabel.Text = s.ToString();
                        System.Threading.Thread.Sleep(1);

                    }
                }
            } 
            
        }

    }
}
