namespace Tyuiu.ShishkovIA.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GroupBoxMain_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.groupBox_SIA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_SIA = new System.Windows.Forms.Label();
            this.labelStart_SIA = new System.Windows.Forms.Label();
            this.textBoxEnd_SIA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SIA = new System.Windows.Forms.TextBox();
            this.buttondone_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.buttonSave_SIA = new System.Windows.Forms.Button();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_SIA = new System.Windows.Forms.TextBox();
            this.chartMain_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBoxMain_SIA.SuspendLayout();
            this.groupBox_SIA.SuspendLayout();
            this.groupBoxResult_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxMain_SIA
            // 
            this.GroupBoxMain_SIA.Controls.Add(this.textBoxTask_SIA);
            this.GroupBoxMain_SIA.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxMain_SIA.Name = "GroupBoxMain_SIA";
            this.GroupBoxMain_SIA.Size = new System.Drawing.Size(247, 107);
            this.GroupBoxMain_SIA.TabIndex = 0;
            this.GroupBoxMain_SIA.TabStop = false;
            this.GroupBoxMain_SIA.Text = "Условие:";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(6, 16);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(230, 80);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = "Произвести табулирование f(x) на заданном диапазоне  [-5; 5] с шагом 1.\r\nПроизвес" +
    "ти проверку деления на ноль. \r\nПри делении на ноль вернуть значение 0. \r\nОкругли" +
    "ть до двух знаков после запятой.";
            this.textBoxTask_SIA.UseWaitCursor = true;
            this.textBoxTask_SIA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox_SIA
            // 
            this.groupBox_SIA.Controls.Add(this.labelStopStep_SIA);
            this.groupBox_SIA.Controls.Add(this.labelStart_SIA);
            this.groupBox_SIA.Controls.Add(this.textBoxEnd_SIA);
            this.groupBox_SIA.Controls.Add(this.textBoxStart_SIA);
            this.groupBox_SIA.Location = new System.Drawing.Point(265, 12);
            this.groupBox_SIA.Name = "groupBox_SIA";
            this.groupBox_SIA.Size = new System.Drawing.Size(304, 96);
            this.groupBox_SIA.TabIndex = 1;
            this.groupBox_SIA.TabStop = false;
            this.groupBox_SIA.Text = "Ввод данных:";
            // 
            // labelStopStep_SIA
            // 
            this.labelStopStep_SIA.AutoSize = true;
            this.labelStopStep_SIA.Location = new System.Drawing.Point(149, 34);
            this.labelStopStep_SIA.Name = "labelStopStep_SIA";
            this.labelStopStep_SIA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_SIA.TabIndex = 1;
            this.labelStopStep_SIA.Text = "Конец шага:";
            // 
            // labelStart_SIA
            // 
            this.labelStart_SIA.AutoSize = true;
            this.labelStart_SIA.Location = new System.Drawing.Point(25, 34);
            this.labelStart_SIA.Name = "labelStart_SIA";
            this.labelStart_SIA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SIA.TabIndex = 1;
            this.labelStart_SIA.Text = "Старт шага:";
            // 
            // textBoxEnd_SIA
            // 
            this.textBoxEnd_SIA.Location = new System.Drawing.Point(140, 49);
            this.textBoxEnd_SIA.Name = "textBoxEnd_SIA";
            this.textBoxEnd_SIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd_SIA.TabIndex = 0;
            // 
            // textBoxStart_SIA
            // 
            this.textBoxStart_SIA.Location = new System.Drawing.Point(15, 49);
            this.textBoxStart_SIA.Name = "textBoxStart_SIA";
            this.textBoxStart_SIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SIA.TabIndex = 0;
            // 
            // buttondone_SIA
            // 
            this.buttondone_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttondone_SIA.Location = new System.Drawing.Point(584, 31);
            this.buttondone_SIA.Name = "buttondone_SIA";
            this.buttondone_SIA.Size = new System.Drawing.Size(87, 54);
            this.buttondone_SIA.TabIndex = 2;
            this.buttondone_SIA.Text = "Выполнить";
            this.buttondone_SIA.UseVisualStyleBackColor = false;
            this.buttondone_SIA.Click += new System.EventHandler(this.buttondone_Click);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp_SIA.Location = new System.Drawing.Point(788, 31);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(87, 54);
            this.buttonHelp_SIA.TabIndex = 2;
            this.buttonHelp_SIA.Text = "Справка";
            this.buttonHelp_SIA.UseVisualStyleBackColor = false;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSave_SIA
            // 
            this.buttonSave_SIA.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_SIA.Location = new System.Drawing.Point(686, 31);
            this.buttonSave_SIA.Name = "buttonSave_SIA";
            this.buttonSave_SIA.Size = new System.Drawing.Size(87, 54);
            this.buttonSave_SIA.TabIndex = 2;
            this.buttonSave_SIA.Text = "Сохранить";
            this.buttonSave_SIA.UseVisualStyleBackColor = false;
            this.buttonSave_SIA.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.textBoxOutPut_SIA);
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(12, 126);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(247, 293);
            this.groupBoxResult_SIA.TabIndex = 3;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод:";
            // 
            // textBoxOutPut_SIA
            // 
            this.textBoxOutPut_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutPut_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_SIA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_SIA.Multiline = true;
            this.textBoxOutPut_SIA.Name = "textBoxOutPut_SIA";
            this.textBoxOutPut_SIA.ReadOnly = true;
            this.textBoxOutPut_SIA.Size = new System.Drawing.Size(241, 274);
            this.textBoxOutPut_SIA.TabIndex = 0;
            // 
            // chartMain_SIA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMain_SIA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMain_SIA.Legends.Add(legend3);
            this.chartMain_SIA.Location = new System.Drawing.Point(293, 126);
            this.chartMain_SIA.Name = "chartMain_SIA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "SeriesMain";
            this.chartMain_SIA.Series.Add(series3);
            this.chartMain_SIA.Size = new System.Drawing.Size(582, 300);
            this.chartMain_SIA.TabIndex = 4;
            title3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "Title1";
            title3.Text = "График функции f(x)";
            this.chartMain_SIA.Titles.Add(title3);
            this.chartMain_SIA.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.chartMain_SIA);
            this.Controls.Add(this.groupBoxResult_SIA);
            this.Controls.Add(this.buttonSave_SIA);
            this.Controls.Add(this.buttonHelp_SIA);
            this.Controls.Add(this.buttondone_SIA);
            this.Controls.Add(this.groupBox_SIA);
            this.Controls.Add(this.GroupBoxMain_SIA);
            this.Name = "FormMain_SIA";
            this.Text = "Sprint 6 | Task 4 | ShishkovIA | V26";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxMain_SIA.ResumeLayout(false);
            this.GroupBoxMain_SIA.PerformLayout();
            this.groupBox_SIA.ResumeLayout(false);
            this.groupBox_SIA.PerformLayout();
            this.groupBoxResult_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMain_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBox_SIA;
        private System.Windows.Forms.Label labelStopStep_SIA;
        private System.Windows.Forms.Label labelStart_SIA;
        private System.Windows.Forms.TextBox textBoxEnd_SIA;
        private System.Windows.Forms.TextBox textBoxStart_SIA;
        private System.Windows.Forms.Button buttondone_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.Button buttonSave_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.TextBox textBoxOutPut_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain_SIA;
    }
}

