using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace bitmapa
{
    public partial class Form2 : Form

    {
        public Form1 f1 = new Form1();
        public Bitmap obraz2 { get; set; }
        public int[] tablica2 = new int[256];
        //public int[] tablica2 { get; set; }
        System.Drawing.Color kolorRGB2 = new System.Drawing.Color();
        public Form2()
        {
            //Rysuj();
            InitializeComponent();
            Rysuj();
        }
        public Bitmap TheBitMapProperty {
            get {
                return obraz2;
            }
            set {
                f1.obraz = obraz2;
            }

        }
        public void Rysuj()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Liczba przypadków");
            chart1.Series["Liczba przypadków"].ChartType = SeriesChartType.Point;
            chart1.ChartAreas[0].AxisX.Title = "skala szarości";
            chart1.ChartAreas[0].AxisY.Title = "liczba wystąpień";

            /* for (int n = 0; n < 256; n++)
             {
                 Console.WriteLine("Skala szarosci: " + n + " liczba wystapien: " + f1.tablica[n]);
             }*/

            string[] linie = new string[256];
            //f1.tablica = tablica2;
            for (int n = 0; n < 256; n++)
            {
                Console.WriteLine("Skala szarosci: " + n + " liczba wystapien: " + tablica2[n]);
            }
            for (int i = 0; i < obraz2.Width; i++) {
                for (int j = 0; j < obraz2.Height; j++) {
                    kolorRGB2 = obraz2.GetPixel(i, j);

                    //listaWartosci[kolorRGB.R] += 1;
                    tablica2[kolorRGB2.R] += 1;

                }
            }
            for (int i = 0; i < 256; i++)
            {
                
                chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica2[i]);
                linie[i] = i.ToString();
                chart1.Series.Add(linie[i]);
                chart1.Series[linie[i]].ChartType = SeriesChartType.Line;
                chart1.Series[linie[i]].Color = Color.Blue;
                chart1.Series[linie[i]].Points.AddXY(i, tablica2[i]);
                chart1.Series[linie[i]].Points.AddXY(i, 0);
                chart1.Series[linie[i]].IsVisibleInLegend = false;


            }
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void wprowadzDoTablicy(int wartosc,int numerTablicy)
        {
         
            tablica2[numerTablicy] = wartosc;

        }
    }
}
