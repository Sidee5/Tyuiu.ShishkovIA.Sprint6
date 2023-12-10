namespace Tyuiu.ShishkovIA.Sprint6.Task5.V23
{
    partial class FormMain_SIA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxMain_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxMain_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_SIA = new System.Windows.Forms.DataGridView();
            this.chartDiag_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.buttonOpen_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.groupBoxMain_SIA.SuspendLayout();
            this.groupBoxResult_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain_SIA
            // 
            this.groupBoxMain_SIA.Controls.Add(this.textBoxMain_SIA);
            this.groupBoxMain_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain_SIA.Name = "groupBoxMain_SIA";
            this.groupBoxMain_SIA.Size = new System.Drawing.Size(257, 95);
            this.groupBoxMain_SIA.TabIndex = 0;
            this.groupBoxMain_SIA.TabStop = false;
            this.groupBoxMain_SIA.Text = "Условие:";
            // 
            // textBoxMain_SIA
            // 
            this.textBoxMain_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMain_SIA.Location = new System.Drawing.Point(7, 17);
            this.textBoxMain_SIA.Multiline = true;
            this.textBoxMain_SIA.Name = "textBoxMain_SIA";
            this.textBoxMain_SIA.ReadOnly = true;
            this.textBoxMain_SIA.Size = new System.Drawing.Size(245, 70);
            this.textBoxMain_SIA.TabIndex = 0;
            this.textBoxMain_SIA.Text = "Дан список из чисел. \r\nВывести все числа, меньше 0.\r\nПостроить диаграмму по этим " +
    "значениям.\r\nУ вещественных значений округлить до трёх знаков после запятой.";
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.dataGridViewNums_SIA);
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(13, 113);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(256, 325);
            this.groupBoxResult_SIA.TabIndex = 1;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод данных:";
            // 
            // dataGridViewNums_SIA
            // 
            this.dataGridViewNums_SIA.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNums_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNums_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_SIA.ColumnHeadersVisible = false;
            this.dataGridViewNums_SIA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewNums_SIA.Name = "dataGridViewNums_SIA";
            this.dataGridViewNums_SIA.RowHeadersVisible = false;
            this.dataGridViewNums_SIA.Size = new System.Drawing.Size(244, 300);
            this.dataGridViewNums_SIA.TabIndex = 0;
            // 
            // chartDiag_SIA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_SIA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDiag_SIA.Legends.Add(legend2);
            this.chartDiag_SIA.Location = new System.Drawing.Point(291, 119);
            this.chartDiag_SIA.Name = "chartDiag_SIA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "SeriesMain";
            this.chartDiag_SIA.Series.Add(series2);
            this.chartDiag_SIA.Size = new System.Drawing.Size(421, 319);
            this.chartDiag_SIA.TabIndex = 2;
            this.chartDiag_SIA.Text = "chart";
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_SIA.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDone_SIA.Location = new System.Drawing.Point(327, 29);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(105, 50);
            this.buttonDone_SIA.TabIndex = 3;
            this.buttonDone_SIA.Text = "Выполнить";
            this.buttonDone_SIA.UseVisualStyleBackColor = false;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpen_SIA
            // 
            this.buttonOpen_SIA.BackColor = System.Drawing.Color.Blue;
            this.buttonOpen_SIA.Location = new System.Drawing.Point(483, 29);
            this.buttonOpen_SIA.Name = "buttonOpen_SIA";
            this.buttonOpen_SIA.Size = new System.Drawing.Size(105, 50);
            this.buttonOpen_SIA.TabIndex = 4;
            this.buttonOpen_SIA.Text = "Открыть файл";
            this.buttonOpen_SIA.UseVisualStyleBackColor = false;
            this.buttonOpen_SIA.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_SIA.Location = new System.Drawing.Point(638, 29);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(105, 50);
            this.buttonHelp_SIA.TabIndex = 5;
            this.buttonHelp_SIA.Text = "Справка";
            this.buttonHelp_SIA.UseVisualStyleBackColor = false;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_SIA);
            this.Controls.Add(this.buttonOpen_SIA);
            this.Controls.Add(this.buttonDone_SIA);
            this.Controls.Add(this.chartDiag_SIA);
            this.Controls.Add(this.groupBoxResult_SIA);
            this.Controls.Add(this.groupBoxMain_SIA);
            this.Name = "FormMain_SIA";
            this.Text = "Sprint 6 | Task 5 | ShishkovIA | V23";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMain_SIA.ResumeLayout(false);
            this.groupBoxMain_SIA.PerformLayout();
            this.groupBoxResult_SIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain_SIA;
        private System.Windows.Forms.TextBox textBoxMain_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.Button buttonOpen_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.DataGridView dataGridViewNums_SIA;
    }
}

