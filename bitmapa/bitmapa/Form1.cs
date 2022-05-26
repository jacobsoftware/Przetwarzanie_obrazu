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
namespace bitmapa {
    public partial class Form1 : Form {
        private Graphics g;
        public Bitmap obraz;
        public Bitmap obrazRGB;
        public Bitmap obrazDoDzialan;
        //public Form2 form2 = new Form2();
        System.Drawing.Color kolorRGB = new System.Drawing.Color();
        //System.Drawing.Color kolorSzary = new System.Drawing.Color();
        public int[] tablica = new int[256];
        public IList<int> listaWartosci = new List<int>(256);
        public bool sprawdzenie = false;
        public int prog1, prog2;
        public static Color czarny = Color.Black;
        public static Color bialy = Color.White;
        public Bitmap obrazSzary;
        public Form1() {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(776, 400);
            g = Graphics.FromImage(pictureBox1.Image);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            //dialogOpen.ShowDialog();
            dialogOpen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialogOpen.ShowDialog() == DialogResult.OK) { 
                pictureBox1.Image = new Bitmap(dialogOpen.FileName);
                obraz = new Bitmap(dialogOpen.FileName);
                obrazRGB = obraz;
                //obraz = new Bitmap(pictureBox1.Image);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp|png|*.png|jpg|*.jpg|gif|*.gif";
            dialog.ShowDialog();
            if (dialog.FileName != "") {
                pictureBox1.Image.Save(dialog.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void wielkoscToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Wielkość: " + obraz.Height + "\nSzerokość: " + obraz.Width);
        }

        private void szaroscToolStripMenuItem_Click(object sender, EventArgs e) {
            if (obraz != null) {
                sprawdzenie = true;
                for (int i = 0; i < obraz.Width; i++) {
                    for (int j = 0; j < obraz.Height; j++) {
                        kolorRGB=obraz.GetPixel(i, j);
                        int GS = 0;
                        GS = (int)(Math.Round(0.255 * kolorRGB.R)+ Math.Round(0.527 * kolorRGB.G)+Math.Round(0.114*kolorRGB.B));
                        Color kolorSzary = Color.FromArgb(GS, GS, GS);
                        obraz.SetPixel(i, j, kolorSzary);
                        pictureBox1.Image = obraz;
                    }
                }
                obrazSzary = obraz;
            } 
            else 
            {
                MessageBox.Show("Brak wprowadzonego obrazu");

            }
            
        }

        private void histogramSzarosciToolStripMenuItem_Click(object sender, EventArgs e) {
            if (obraz != null) {
                if(sprawdzenie==true) {

                    for (int i = 0; i < obraz.Width; i++) {
                        for (int j = 0; j < obraz.Height; j++) {
                            kolorRGB = obraz.GetPixel(i, j);

                            //listaWartosci[kolorRGB.R] += 1;
                            tablica[kolorRGB.R] += 1;

                        }
                    }
                    for (int n = 0; n < 256; n++) {
                        Console.WriteLine("SKALA szarosci: " + n + " liczba wystapien: " + tablica[n]);
                        //Console.WriteLine("SKALA szarosci: " + n + " liczba wystapien: " + listaWartosci[n]);
                    }
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczba przypadków");
                    chart1.Series["Liczba przypadków"].ChartType = SeriesChartType.Point;
                    chart1.ChartAreas[0].AxisX.Title = "skala szarości";
                    chart1.ChartAreas[0].AxisY.Title = "liczba wystąpień";
                    string[] linie = new string[256];
                    for (int i = 0; i < 256; i++) {

                        //chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica[i]);
                        linie[i] = i.ToString();
                        chart1.Series.Add(linie[i]);
                        chart1.Series[linie[i]].ChartType = SeriesChartType.Line;
                        chart1.Series[linie[i]].Color = Color.Blue;
                        chart1.Series[linie[i]].Points.AddXY(i, tablica[i]);
                        chart1.Series[linie[i]].Points.AddXY(i, 0);
                        chart1.Series[linie[i]].IsVisibleInLegend = false;


                    }

                } else {
                    MessageBox.Show("Nie przetworzono obrazu na skale szarości");
                }


                //Form2 form2 = new Form2();
                /*for (int k = 0; k < 256; k++)
                {
                    form2.wprowadzDoTablicy(tablica[k], k);
                }*/
                /*for(int k=0;k<256;k++) 
                {
                    form2.tablica2[k] = tablica[k];
                }*/
                //form2.tablica2 = tablica;
                //form2.TheBitMapProperty = obraz;
                //form2.Show();


            } else {
                MessageBox.Show("Brak wprowadzonego obrazu");

            }
        }

        private void histogramRGBToolStripMenuItem_Click(object sender, EventArgs e) {
            if(obrazRGB!=null) 
            {
                int[] tablicaR = new int[256];
                int[] tablicaG = new int[256];
                int[] tablicaB = new int[256];
                System.Drawing.Color kolorRGB2 = new System.Drawing.Color();
                for (int i = 0; i < obrazRGB.Width; i++) 
                {
                   
                    for(int j=0;j<obrazRGB.Height;j++) 
                    {
                        kolorRGB2 = obrazRGB.GetPixel(i, j);
                        tablicaR[kolorRGB2.R] += 1;
                        tablicaG[kolorRGB2.G] += 1;
                        tablicaB[kolorRGB2.B] += 1;

                    }
                }
                chart1.Series.Clear();
                chart1.Series.Add("Liczba przypadków");
                chart1.Series["Liczba przypadków"].ChartType = SeriesChartType.Point;
                chart1.ChartAreas[0].AxisX.Title = "skala szarości";
                chart1.ChartAreas[0].AxisY.Title = "liczba wystąpień";
                string[] linieR = new string[256];
                string[] linieG = new string[256];
                string[] linieB = new string[256];
                for (int i = 0; i < 256; i++) {

                    //chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica[i]);
                    linieR[i] = i.ToString();
                    chart1.Series.Add("R" + linieR[i]);
                    chart1.Series["R"+linieR[i]].ChartType = SeriesChartType.Line;
                    chart1.Series["R" + linieR[i]].Color = Color.Red;
                    chart1.Series["R" + linieR[i]].Points.AddXY(i, tablicaR[i]);
                    chart1.Series["R" + linieR[i]].Points.AddXY(i, 0);
                    chart1.Series["R" + linieR[i]].IsVisibleInLegend = false;


                }
                for (int i = 0; i < 256; i++) {

                    //chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica[i]);
                    linieG[i] = i.ToString();
                    chart1.Series.Add("G" + linieG[i]);
                    chart1.Series["G" + linieG[i]].ChartType = SeriesChartType.Line;
                    chart1.Series["G" + linieG[i]].Color = Color.Green;
                    chart1.Series["G" + linieG[i]].Points.AddXY(i, tablicaG[i]);
                    chart1.Series["G" + linieG[i]].Points.AddXY(i, 0);
                    chart1.Series["G" + linieG[i]].IsVisibleInLegend = false;


                }
                for (int i = 0; i < 256; i++) {

                    //chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica[i]);
                    linieB[i] = i.ToString();
                    chart1.Series.Add("B" + linieB[i]);
                    chart1.Series["B" + linieB[i]].ChartType = SeriesChartType.Line;
                    chart1.Series["B" + linieB[i]].Color = Color.Blue;
                    chart1.Series["B" + linieB[i]].Points.AddXY(i, tablicaB[i]);
                    chart1.Series["B" + linieB[i]].Points.AddXY(i, 0);
                    chart1.Series["B" + linieB[i]].IsVisibleInLegend = false;


                }


            } else 
            {
                MessageBox.Show("Brak wprowadzonego obrazu");
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e) {
            int[] tablicaR = new int[256];
            System.Drawing.Color kolorRGB2 = new System.Drawing.Color();
            for (int i = 0; i < obrazRGB.Width; i++) {

                for (int j = 0; j < obrazRGB.Height; j++) {
                    kolorRGB2 = obrazRGB.GetPixel(i, j);
                    tablicaR[kolorRGB2.R] += 1;


                }
            }
            chart1.Series.Clear();
            chart1.Series.Add("Liczba przypadków");
            chart1.Series["Liczba przypadków"].ChartType = SeriesChartType.Point;
            chart1.ChartAreas[0].AxisX.Title = "skala szarości";
            chart1.ChartAreas[0].AxisY.Title = "liczba wystąpień";
            string[] linieR = new string[256];

            for (int i = 0; i < 256; i++) {

                //chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica[i]);
                linieR[i] = i.ToString();
                chart1.Series.Add("R" + linieR[i]);
                chart1.Series["R" + linieR[i]].ChartType = SeriesChartType.Line;
                chart1.Series["R" + linieR[i]].Color = Color.Red;
                chart1.Series["R" + linieR[i]].Points.AddXY(i, tablicaR[i]);
                chart1.Series["R" + linieR[i]].Points.AddXY(i, 0);
                chart1.Series["R" + linieR[i]].IsVisibleInLegend = false;


            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e) {
            int[] tablicaG = new int[256];
            System.Drawing.Color kolorRGB2 = new System.Drawing.Color();
            for (int i = 0; i < obrazRGB.Width; i++) {

                for (int j = 0; j < obrazRGB.Height; j++) {
                    kolorRGB2 = obrazRGB.GetPixel(i, j);
                    tablicaG[kolorRGB2.G] += 1;


                }
            }
            chart1.Series.Clear();
            chart1.Series.Add("Liczba przypadków");
            chart1.Series["Liczba przypadków"].ChartType = SeriesChartType.Point;
            chart1.ChartAreas[0].AxisX.Title = "skala szarości";
            chart1.ChartAreas[0].AxisY.Title = "liczba wystąpień";
            string[] linieG = new string[256];
            for (int i = 0; i < 256; i++) {

                //chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica[i]);
                linieG[i] = i.ToString();
                chart1.Series.Add("G" + linieG[i]);
                chart1.Series["G" + linieG[i]].ChartType = SeriesChartType.Line;
                chart1.Series["G" + linieG[i]].Color = Color.Green;
                chart1.Series["G" + linieG[i]].Points.AddXY(i, tablicaG[i]);
                chart1.Series["G" + linieG[i]].Points.AddXY(i, 0);
                chart1.Series["G" + linieG[i]].IsVisibleInLegend = false;


            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e) {
            int[] tablicaB = new int[256];
            System.Drawing.Color kolorRGB2 = new System.Drawing.Color();
            for (int i = 0; i < obrazRGB.Width; i++) {

                for (int j = 0; j < obrazRGB.Height; j++) {
                    kolorRGB2 = obrazRGB.GetPixel(i, j);
                    tablicaB[kolorRGB2.B] += 1;


                }
            }
            chart1.Series.Clear();
            chart1.Series.Add("Liczba przypadków");
            chart1.Series["Liczba przypadków"].ChartType = SeriesChartType.Point;
            chart1.ChartAreas[0].AxisX.Title = "skala szarości";
            chart1.ChartAreas[0].AxisY.Title = "liczba wystąpień";
            string[] linieB = new string[256];
            for (int i = 0; i < 256; i++) {

                //chart1.Series["Liczba przypadków"].Points.AddXY(i, tablica[i]);
                linieB[i] = i.ToString();
                chart1.Series.Add("B" + linieB[i]);
                chart1.Series["B" + linieB[i]].ChartType = SeriesChartType.Line;
                chart1.Series["B" + linieB[i]].Color = Color.Blue;
                chart1.Series["B" + linieB[i]].Points.AddXY(i, tablicaB[i]);
                chart1.Series["B" + linieB[i]].Points.AddXY(i, 0);
                chart1.Series["B" + linieB[i]].IsVisibleInLegend = false;


            }
        }

        private void przeksztalcenieToolStripMenuItem_Click(object sender, EventArgs e) {

            Bitmap przeksztalcenie = obraz;
            int newColor;
            double wartosc = 255;
            for (int i = 0; i < obraz.Width; i++) 
            {
                for(int j=0;j<obraz.Height;j++) 
                {
                    Color przeksztalcony = new Color();
                    przeksztalcony = przeksztalcenie.GetPixel(i, j);
                    newColor = (int)(Math.Round((przeksztalcony.R * przeksztalcony.R) / wartosc));
                    //przeksztalcony.R = kolorRGB.R / 65025 * 255;
                    //przeksztalcenie.SetPixel(i, j,);
                    Color kolorPrzekonwertowany = Color.FromArgb(newColor, newColor, newColor);
                    przeksztalcenie.SetPixel(i, j, kolorPrzekonwertowany);
                    
                }
            }
            pictureBox1.Image = przeksztalcenie;
        }

        private void gorneToolStripMenuItem_Click(object sender, EventArgs e) {
            if(sprawdzenie==true) 
            {
                if(tBProg1.Text!="") {
                    prog1 = int.Parse(tBProg1.Text);
                    obrazDoDzialan = new Bitmap (obrazSzary);
                    for (int i = 0; i < obrazDoDzialan.Width; i++) {
                        for (int j = 0; j < obrazDoDzialan.Height; j++) {
                            kolorRGB = obrazDoDzialan.GetPixel(i, j);
                            if (kolorRGB.R <= prog1) {
                                obrazDoDzialan.SetPixel(i, j, czarny);
                            } else {
                                obrazDoDzialan.SetPixel(i, j, bialy);
                            }
                        }
                    }
                    pictureBox1.Image = obrazDoDzialan;
                }
                else {
                    MessageBox.Show("Brak wprowadzonej wartości progu");
                }

            } 
            else {
                MessageBox.Show("Brak przetworzenia na skale szarości");
            }
        }

        private void dolneToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sprawdzenie == true) 
            {
                if (tBProg1.Text != "") {
                    prog1 = int.Parse(tBProg1.Text);
                    obrazDoDzialan = new Bitmap(obrazSzary);
                    for (int i = 0; i < obrazDoDzialan.Width; i++) {
                        for (int j = 0; j < obrazDoDzialan.Height; j++) {
                            kolorRGB = obrazDoDzialan.GetPixel(i, j);
                            if (kolorRGB.R >= prog1) {
                                obrazDoDzialan.SetPixel(i, j, czarny);
                            } else {
                                obrazDoDzialan.SetPixel(i, j, bialy);
                            }
                        }
                    }
                    pictureBox1.Image = obrazDoDzialan;
                } else {
                    MessageBox.Show("Brak wprowadzonej wartości progu");
                }

            } 
            else 
            {
                MessageBox.Show("Brak przetworzenia na skale szarości");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void tBProg1_TextChanged(object sender, EventArgs e) {
            //prog1 = int.Parse(tBProg1.Text);
        }

        private void tBProg2_TextChanged(object sender, EventArgs e) {
            //prog2 = int.Parse(tBProg2.Text);
        }

        private void podwojneOgraniczenieToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sprawdzenie == true) 
            {
                if (tBProg1.Text != "" && tBProg2.Text!="") {
                    obrazDoDzialan = new Bitmap (obrazSzary);
                    prog1 = int.Parse(tBProg1.Text);
                    prog2 = int.Parse(tBProg2.Text);
                    if(prog1<prog2) {
                        for (int i = 0; i < obrazDoDzialan.Width; i++) {
                            for (int j = 0; j < obrazDoDzialan.Height; j++) {
                                kolorRGB = obrazDoDzialan.GetPixel(i, j);
                                if (kolorRGB.R <= prog1 ||kolorRGB.R>prog2) {
                                    obrazSzary.SetPixel(i, j, czarny);
                                } else {
                                    obrazDoDzialan.SetPixel(i, j, bialy);
                                }
                            }
                        }
                        pictureBox1.Image = obrazDoDzialan;
                    } else {
                        MessageBox.Show("Wartość pierwszego progu nie może być większa od drugiego");
                    }
                } 
                else {
                    MessageBox.Show("Brak wprowadzonej wartości progu");
                }
            } 
            else {
                MessageBox.Show("Brak przetworzenia na skale szarości");
            }
        }
    }
}
