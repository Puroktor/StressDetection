namespace TestWinfromsFramework
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHFP = new System.Windows.Forms.Label();
            this.labelLFP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHF = new System.Windows.Forms.Label();
            this.labelLF = new System.Windows.Forms.Label();
            this.labelVLF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.chartFourier = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.stressPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFourier)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartData
            // 
            chartArea9.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea9);
            this.chartData.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend9.Name = "Legend1";
            this.chartData.Legends.Add(legend9);
            this.chartData.Location = new System.Drawing.Point(0, 0);
            this.chartData.Name = "chartData";
            this.chartData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Color = System.Drawing.Color.Red;
            series9.Legend = "Legend1";
            series9.Name = "Сигнал";
            this.chartData.Series.Add(series9);
            this.chartData.Size = new System.Drawing.Size(800, 169);
            this.chartData.TabIndex = 0;
            this.chartData.Text = "chart";
            this.chartData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseMove);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.stressPanel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelHFP);
            this.panel1.Controls.Add(this.labelLFP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelSum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelHF);
            this.panel1.Controls.Add(this.labelLF);
            this.panel1.Controls.Add(this.labelVLF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // labelHFP
            // 
            this.labelHFP.AutoSize = true;
            this.labelHFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHFP.Location = new System.Drawing.Point(681, 73);
            this.labelHFP.Name = "labelHFP";
            this.labelHFP.Size = new System.Drawing.Size(0, 18);
            this.labelHFP.TabIndex = 12;
            // 
            // labelLFP
            // 
            this.labelLFP.AutoSize = true;
            this.labelLFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLFP.Location = new System.Drawing.Point(681, 38);
            this.labelLFP.Name = "labelLFP";
            this.labelLFP.Size = new System.Drawing.Size(0, 18);
            this.labelLFP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(534, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Нормализованная:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(170, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Мощность:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(390, 38);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 18);
            this.labelSum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(369, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Общая (<= 0.4 Гц):";
            // 
            // labelHF
            // 
            this.labelHF.AutoSize = true;
            this.labelHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHF.Location = new System.Drawing.Point(261, 73);
            this.labelHF.Name = "labelHF";
            this.labelHF.Size = new System.Drawing.Size(0, 18);
            this.labelHF.TabIndex = 5;
            // 
            // labelLF
            // 
            this.labelLF.AutoSize = true;
            this.labelLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLF.Location = new System.Drawing.Point(261, 38);
            this.labelLF.Name = "labelLF";
            this.labelLF.Size = new System.Drawing.Size(0, 18);
            this.labelLF.TabIndex = 4;
            // 
            // labelVLF
            // 
            this.labelVLF.AutoSize = true;
            this.labelVLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVLF.Location = new System.Drawing.Point(261, 7);
            this.labelVLF.Name = "labelVLF";
            this.labelVLF.Size = new System.Drawing.Size(0, 18);
            this.labelVLF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "HF: 0.15 - 0.4 Гц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "LF:  0.04 - 0.15 Гц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "VLF: <= 0.04 Гц";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseButton
            // 
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(110, 20);
            this.chooseButton.Text = "Выбрать данные";
            this.chooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // chartFourier
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFourier.ChartAreas.Add(chartArea10);
            this.chartFourier.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend10.Name = "Legend1";
            this.chartFourier.Legends.Add(legend10);
            this.chartFourier.Location = new System.Drawing.Point(0, 169);
            this.chartFourier.Name = "chartFourier";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartFourier.Series.Add(series10);
            this.chartFourier.Size = new System.Drawing.Size(800, 169);
            this.chartFourier.TabIndex = 3;
            this.chartFourier.Text = "chart1";
            this.chartFourier.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartData);
            this.panel2.Controls.Add(this.chartFourier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 338);
            this.panel2.TabIndex = 4;
            this.panel2.Resize += new System.EventHandler(this.Panel2_Resize);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(574, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "(- VLF)";
            // 
            // stressPanel
            // 
            this.stressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stressPanel.Location = new System.Drawing.Point(731, 38);
            this.stressPanel.Name = "stressPanel";
            this.stressPanel.Size = new System.Drawing.Size(50, 50);
            this.stressPanel.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(727, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Стресс:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Определение стресса";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFourier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFourier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHF;
        private System.Windows.Forms.Label labelLF;
        private System.Windows.Forms.Label labelVLF;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHFP;
        private System.Windows.Forms.Label labelLFP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel stressPanel;
    }
}

