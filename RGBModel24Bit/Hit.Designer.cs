namespace RGBModel24Bit
{
    partial class Hit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.R = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.G = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.B = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.SuspendLayout();
            // 
            // R
            // 
            chartArea1.Name = "ChartArea1";
            this.R.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.R.Legends.Add(legend1);
            this.R.Location = new System.Drawing.Point(12, 12);
            this.R.Name = "R";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "R";
            this.R.Series.Add(series1);
            this.R.Size = new System.Drawing.Size(628, 177);
            this.R.TabIndex = 0;
            this.R.Text = "R";
            // 
            // G
            // 
            chartArea2.Name = "ChartArea1";
            this.G.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.G.Legends.Add(legend2);
            this.G.Location = new System.Drawing.Point(12, 195);
            this.G.Name = "G";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "G";
            this.G.Series.Add(series2);
            this.G.Size = new System.Drawing.Size(628, 177);
            this.G.TabIndex = 0;
            this.G.Text = "G";
            // 
            // B
            // 
            chartArea3.Name = "ChartArea1";
            this.B.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.B.Legends.Add(legend3);
            this.B.Location = new System.Drawing.Point(12, 378);
            this.B.Name = "B";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "B";
            this.B.Series.Add(series3);
            this.B.Size = new System.Drawing.Size(628, 177);
            this.B.TabIndex = 0;
            this.B.Text = "B";
            // 
            // Hit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 570);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Name = "Hit";
            this.Text = "Hit";
            this.Load += new System.EventHandler(this.Hit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart R;
        private System.Windows.Forms.DataVisualization.Charting.Chart G;
        private System.Windows.Forms.DataVisualization.Charting.Chart B;
    }
}