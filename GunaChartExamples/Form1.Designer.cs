
namespace GunaChartExamples
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
            Guna.Charts.WinForms.ChartFont chartFont73 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont74 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont75 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont76 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid28 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick28 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont77 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid29 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick29 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont78 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid30 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel10 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont79 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick30 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont80 = new Guna.Charts.WinForms.ChartFont();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaChart1
            // 
            this.gunaChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaChart1.BackColor = System.Drawing.Color.White;
            chartFont73.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont73;
            this.gunaChart1.Location = new System.Drawing.Point(200, 54);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(795, 581);
            this.gunaChart1.TabIndex = 0;
            chartFont74.FontName = "Arial";
            chartFont74.Size = 12;
            chartFont74.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont74;
            chartFont75.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont75;
            chartFont76.FontName = "Arial";
            chartFont76.Size = 9;
            chartFont76.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont76;
            this.gunaChart1.XAxes.GridLines = grid28;
            chartFont77.FontName = "Arial";
            tick28.Font = chartFont77;
            this.gunaChart1.XAxes.Ticks = tick28;
            this.gunaChart1.YAxes.GridLines = grid29;
            chartFont78.FontName = "Arial";
            tick29.Font = chartFont78;
            this.gunaChart1.YAxes.Ticks = tick29;
            this.gunaChart1.ZAxes.GridLines = grid30;
            chartFont79.FontName = "Arial";
            pointLabel10.Font = chartFont79;
            this.gunaChart1.ZAxes.PointLabels = pointLabel10;
            chartFont80.FontName = "Arial";
            tick30.Font = chartFont80;
            this.gunaChart1.ZAxes.Ticks = tick30;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(257, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Dark";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(311, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Light";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(183, 647);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(200, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "{  }";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 5);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.gunaChart1);
            this.Name = "Form1";
            this.Text = "Guna Chart Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}

