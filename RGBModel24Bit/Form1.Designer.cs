namespace RGBModel24Bit
{
    partial class Form1
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
            this.PicInput = new System.Windows.Forms.PictureBox();
            this.PicOutput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.Histogram = new System.Windows.Forms.Button();
            this.Brightness = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // PicInput
            // 
            this.PicInput.Location = new System.Drawing.Point(12, 12);
            this.PicInput.Name = "PicInput";
            this.PicInput.Size = new System.Drawing.Size(256, 256);
            this.PicInput.TabIndex = 0;
            this.PicInput.TabStop = false;
            // 
            // PicOutput
            // 
            this.PicOutput.Location = new System.Drawing.Point(274, 12);
            this.PicOutput.Name = "PicOutput";
            this.PicOutput.Size = new System.Drawing.Size(256, 256);
            this.PicOutput.TabIndex = 0;
            this.PicOutput.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Image";
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Open.Location = new System.Drawing.Point(536, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(193, 57);
            this.Open.TabIndex = 2;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Histogram
            // 
            this.Histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Histogram.Location = new System.Drawing.Point(536, 85);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(193, 57);
            this.Histogram.TabIndex = 2;
            this.Histogram.Text = "Histogram";
            this.Histogram.UseVisualStyleBackColor = true;
            // 
            // Brightness
            // 
            this.Brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Brightness.Location = new System.Drawing.Point(536, 148);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(193, 57);
            this.Brightness.TabIndex = 2;
            this.Brightness.Text = "Brightness";
            this.Brightness.UseVisualStyleBackColor = true;
            // 
            // Negative
            // 
            this.Negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Negative.Location = new System.Drawing.Point(536, 211);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(193, 57);
            this.Negative.TabIndex = 2;
            this.Negative.Text = "Negative";
            this.Negative.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Percentage (+/-)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 334);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.Histogram);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicOutput);
            this.Controls.Add(this.PicInput);
            this.Name = "Form1";
            this.Text = "RGBModel24nit";
            ((System.ComponentModel.ISupportInitialize)(this.PicInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicInput;
        private System.Windows.Forms.PictureBox PicOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Histogram;
        private System.Windows.Forms.Button Brightness;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

