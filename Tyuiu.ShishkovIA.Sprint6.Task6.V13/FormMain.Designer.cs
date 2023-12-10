namespace Tyuiu.ShishkovIA.Sprint6.Task6.V13
{
    partial class FormMain_SIA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SIA));
            this.panelTop_SIA = new System.Windows.Forms.Panel();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SIA = new System.Windows.Forms.Button();
            this.panelTop2_SIA = new System.Windows.Forms.Panel();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.panelLeft_SIA = new System.Windows.Forms.Panel();
            this.groupBoxInput_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_SIA = new System.Windows.Forms.TextBox();
            this.panelFill_SIA = new System.Windows.Forms.Panel();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SIA = new System.Windows.Forms.TextBox();
            this.splitter_SIA = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_SIA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SIA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_SIA.SuspendLayout();
            this.panelTop2_SIA.SuspendLayout();
            this.groupBoxTask_SIA.SuspendLayout();
            this.panelLeft_SIA.SuspendLayout();
            this.groupBoxInput_SIA.SuspendLayout();
            this.panelFill_SIA.SuspendLayout();
            this.groupBoxResult_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SIA
            // 
            this.panelTop_SIA.Controls.Add(this.buttonHelp_SIA);
            this.panelTop_SIA.Controls.Add(this.buttonDone_SIA);
            this.panelTop_SIA.Controls.Add(this.buttonOpenFile_SIA);
            this.panelTop_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SIA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SIA.Name = "panelTop_SIA";
            this.panelTop_SIA.Size = new System.Drawing.Size(884, 64);
            this.panelTop_SIA.TabIndex = 0;
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SIA.Image")));
            this.buttonHelp_SIA.Location = new System.Drawing.Point(806, 3);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_SIA.TabIndex = 1;
            this.toolTip_SIA.SetToolTip(this.buttonHelp_SIA, "Сведения о программе");
            this.buttonHelp_SIA.UseVisualStyleBackColor = true;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.Enabled = false;
            this.buttonDone_SIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SIA.Image")));
            this.buttonDone_SIA.Location = new System.Drawing.Point(84, 3);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_SIA.TabIndex = 1;
            this.toolTip_SIA.SetToolTip(this.buttonDone_SIA, "Выводит перове слово каждой строки\r\n");
            this.buttonDone_SIA.UseVisualStyleBackColor = true;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            // 
            // buttonOpenFile_SIA
            // 
            this.buttonOpenFile_SIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SIA.Image")));
            this.buttonOpenFile_SIA.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_SIA.Name = "buttonOpenFile_SIA";
            this.buttonOpenFile_SIA.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_SIA.TabIndex = 1;
            this.toolTip_SIA.SetToolTip(this.buttonOpenFile_SIA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SIA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SIA.Click += new System.EventHandler(this.buttonOpenFile_SSV_Click);
            // 
            // panelTop2_SIA
            // 
            this.panelTop2_SIA.Controls.Add(this.groupBoxTask_SIA);
            this.panelTop2_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2_SIA.Location = new System.Drawing.Point(0, 64);
            this.panelTop2_SIA.Name = "panelTop2_SIA";
            this.panelTop2_SIA.Size = new System.Drawing.Size(884, 85);
            this.panelTop2_SIA.TabIndex = 0;
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(884, 85);
            this.groupBoxTask_SIA.TabIndex = 0;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие:";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(878, 66);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = resources.GetString("textBoxTask_SIA.Text");
            // 
            // panelLeft_SIA
            // 
            this.panelLeft_SIA.Controls.Add(this.groupBoxInput_SIA);
            this.panelLeft_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SIA.Location = new System.Drawing.Point(0, 149);
            this.panelLeft_SIA.Name = "panelLeft_SIA";
            this.panelLeft_SIA.Size = new System.Drawing.Size(430, 362);
            this.panelLeft_SIA.TabIndex = 0;
            // 
            // groupBoxInput_SIA
            // 
            this.groupBoxInput_SIA.Controls.Add(this.textBoxInput_SIA);
            this.groupBoxInput_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_SIA.Name = "groupBoxInput_SIA";
            this.groupBoxInput_SIA.Size = new System.Drawing.Size(430, 362);
            this.groupBoxInput_SIA.TabIndex = 0;
            this.groupBoxInput_SIA.TabStop = false;
            this.groupBoxInput_SIA.Text = "Ввод:";
            // 
            // textBoxInput_SIA
            // 
            this.textBoxInput_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_SIA.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_SIA.Multiline = true;
            this.textBoxInput_SIA.Name = "textBoxInput_SIA";
            this.textBoxInput_SIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_SIA.Size = new System.Drawing.Size(424, 343);
            this.textBoxInput_SIA.TabIndex = 0;
            // 
            // panelFill_SIA
            // 
            this.panelFill_SIA.Controls.Add(this.groupBoxResult_SIA);
            this.panelFill_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SIA.Location = new System.Drawing.Point(430, 149);
            this.panelFill_SIA.Name = "panelFill_SIA";
            this.panelFill_SIA.Size = new System.Drawing.Size(454, 362);
            this.panelFill_SIA.TabIndex = 0;
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.textBoxResult_SIA);
            this.groupBoxResult_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(454, 362);
            this.groupBoxResult_SIA.TabIndex = 0;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод:";
            // 
            // textBoxResult_SIA
            // 
            this.textBoxResult_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SIA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_SIA.Multiline = true;
            this.textBoxResult_SIA.Name = "textBoxResult_SIA";
            this.textBoxResult_SIA.ReadOnly = true;
            this.textBoxResult_SIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SIA.Size = new System.Drawing.Size(448, 343);
            this.textBoxResult_SIA.TabIndex = 0;
            // 
            // splitter_SIA
            // 
            this.splitter_SIA.Location = new System.Drawing.Point(430, 149);
            this.splitter_SIA.Name = "splitter_SIA";
            this.splitter_SIA.Size = new System.Drawing.Size(3, 362);
            this.splitter_SIA.TabIndex = 1;
            this.splitter_SIA.TabStop = false;
            // 
            // openFileDialogTask_SIA
            // 
            this.openFileDialogTask_SIA.FileName = "openFileDialog1";
            // 
            // toolTip_SIA
            // 
            this.toolTip_SIA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SIA.ToolTipTitle = "Подсказка";
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitter_SIA);
            this.Controls.Add(this.panelFill_SIA);
            this.Controls.Add(this.panelLeft_SIA);
            this.Controls.Add(this.panelTop2_SIA);
            this.Controls.Add(this.panelTop_SIA);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 13 | Шишков И.А.";
            this.panelTop_SIA.ResumeLayout(false);
            this.panelTop2_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.panelLeft_SIA.ResumeLayout(false);
            this.groupBoxInput_SIA.ResumeLayout(false);
            this.groupBoxInput_SIA.PerformLayout();
            this.panelFill_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SIA;
        private System.Windows.Forms.Panel panelTop2_SIA;
        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.Panel panelLeft_SIA;
        private System.Windows.Forms.GroupBox groupBoxInput_SIA;
        private System.Windows.Forms.TextBox textBoxInput_SIA;
        private System.Windows.Forms.Panel panelFill_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.TextBox textBoxResult_SIA;
        private System.Windows.Forms.Splitter splitter_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.Button buttonOpenFile_SIA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SIA;
        private System.Windows.Forms.ToolTip toolTip_SIA;
    }
}

