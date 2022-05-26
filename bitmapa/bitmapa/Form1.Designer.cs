
namespace bitmapa {
    partial class Form1 {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wielkoscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szaroscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramSzarosciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przeksztalcenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.binaryzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podwojneOgraniczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBProg1 = new System.Windows.Forms.TextBox();
            this.tBProg2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otworzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.wielkoscToolStripMenuItem,
            this.szaroscToolStripMenuItem,
            this.histogramSzarosciToolStripMenuItem,
            this.histogramRGBToolStripMenuItem,
            this.przeksztalcenieToolStripMenuItem,
            this.binaryzacjaToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.Click += new System.EventHandler(this.plikToolStripMenuItem_Click);
            // 
            // otworzToolStripMenuItem
            // 
            this.otworzToolStripMenuItem.Name = "otworzToolStripMenuItem";
            this.otworzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otworzToolStripMenuItem.Text = "Otwórz";
            this.otworzToolStripMenuItem.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // wielkoscToolStripMenuItem
            // 
            this.wielkoscToolStripMenuItem.Name = "wielkoscToolStripMenuItem";
            this.wielkoscToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wielkoscToolStripMenuItem.Text = "Wielkość";
            this.wielkoscToolStripMenuItem.Click += new System.EventHandler(this.wielkoscToolStripMenuItem_Click);
            // 
            // szaroscToolStripMenuItem
            // 
            this.szaroscToolStripMenuItem.Name = "szaroscToolStripMenuItem";
            this.szaroscToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szaroscToolStripMenuItem.Text = "Szarość";
            this.szaroscToolStripMenuItem.Click += new System.EventHandler(this.szaroscToolStripMenuItem_Click);
            // 
            // histogramSzarosciToolStripMenuItem
            // 
            this.histogramSzarosciToolStripMenuItem.Name = "histogramSzarosciToolStripMenuItem";
            this.histogramSzarosciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramSzarosciToolStripMenuItem.Text = "Histogram szarości";
            this.histogramSzarosciToolStripMenuItem.Click += new System.EventHandler(this.histogramSzarosciToolStripMenuItem_Click);
            // 
            // histogramRGBToolStripMenuItem
            // 
            this.histogramRGBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.histogramRGBToolStripMenuItem.Name = "histogramRGBToolStripMenuItem";
            this.histogramRGBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramRGBToolStripMenuItem.Text = "Histogram RGB";
            this.histogramRGBToolStripMenuItem.Click += new System.EventHandler(this.histogramRGBToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // przeksztalcenieToolStripMenuItem
            // 
            this.przeksztalcenieToolStripMenuItem.Name = "przeksztalcenieToolStripMenuItem";
            this.przeksztalcenieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.przeksztalcenieToolStripMenuItem.Text = "Przekształcenie";
            this.przeksztalcenieToolStripMenuItem.Click += new System.EventHandler(this.przeksztalcenieToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 481);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 268);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // binaryzacjaToolStripMenuItem
            // 
            this.binaryzacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gorneToolStripMenuItem,
            this.dolneToolStripMenuItem,
            this.podwojneOgraniczenieToolStripMenuItem});
            this.binaryzacjaToolStripMenuItem.Name = "binaryzacjaToolStripMenuItem";
            this.binaryzacjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binaryzacjaToolStripMenuItem.Text = "Binaryzacja";
            // 
            // gorneToolStripMenuItem
            // 
            this.gorneToolStripMenuItem.Name = "gorneToolStripMenuItem";
            this.gorneToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.gorneToolStripMenuItem.Text = "górne";
            this.gorneToolStripMenuItem.Click += new System.EventHandler(this.gorneToolStripMenuItem_Click);
            // 
            // dolneToolStripMenuItem
            // 
            this.dolneToolStripMenuItem.Name = "dolneToolStripMenuItem";
            this.dolneToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dolneToolStripMenuItem.Text = "dolne";
            this.dolneToolStripMenuItem.Click += new System.EventHandler(this.dolneToolStripMenuItem_Click);
            // 
            // podwojneOgraniczenieToolStripMenuItem
            // 
            this.podwojneOgraniczenieToolStripMenuItem.Name = "podwojneOgraniczenieToolStripMenuItem";
            this.podwojneOgraniczenieToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.podwojneOgraniczenieToolStripMenuItem.Text = "podwójne ograniczenie";
            this.podwojneOgraniczenieToolStripMenuItem.Click += new System.EventHandler(this.podwojneOgraniczenieToolStripMenuItem_Click);
            // 
            // tBProg1
            // 
            this.tBProg1.Location = new System.Drawing.Point(65, 449);
            this.tBProg1.Name = "tBProg1";
            this.tBProg1.Size = new System.Drawing.Size(100, 20);
            this.tBProg1.TabIndex = 3;
            this.tBProg1.TextChanged += new System.EventHandler(this.tBProg1_TextChanged);
            // 
            // tBProg2
            // 
            this.tBProg2.Location = new System.Drawing.Point(232, 449);
            this.tBProg2.Name = "tBProg2";
            this.tBProg2.Size = new System.Drawing.Size(100, 20);
            this.tBProg2.TabIndex = 4;
            this.tBProg2.TextChanged += new System.EventHandler(this.tBProg2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prog1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(188, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prog2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBProg2);
            this.Controls.Add(this.tBProg1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otworzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem wielkoscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szaroscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramSzarosciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramRGBToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przeksztalcenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podwojneOgraniczenieToolStripMenuItem;
        private System.Windows.Forms.TextBox tBProg1;
        private System.Windows.Forms.TextBox tBProg2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

