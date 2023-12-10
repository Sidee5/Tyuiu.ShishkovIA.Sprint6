namespace Tyuiu.ShishkovIA.Sprint6.Task7.V29
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
            this.panelOne_SIA = new System.Windows.Forms.Panel();
            this.buttonSaveFile_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SIA = new System.Windows.Forms.Button();
            this.panelTwo_SIA = new System.Windows.Forms.Panel();
            this.groupBoxNameedOne_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxNamedOne_SIA = new System.Windows.Forms.TextBox();
            this.panelThree_SIA = new System.Windows.Forms.Panel();
            this.groupBoxTwo_SIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_SIA = new System.Windows.Forms.DataGridView();
            this.splitter_SIA = new System.Windows.Forms.Splitter();
            this.panelFour_SIA = new System.Windows.Forms.Panel();
            this.groupBoxThree_SIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_SIA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_SIA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SIA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SIA = new System.Windows.Forms.SaveFileDialog();
            this.panelOne_SIA.SuspendLayout();
            this.panelTwo_SIA.SuspendLayout();
            this.groupBoxNameedOne_SIA.SuspendLayout();
            this.panelThree_SIA.SuspendLayout();
            this.groupBoxTwo_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_SIA)).BeginInit();
            this.panelFour_SIA.SuspendLayout();
            this.groupBoxThree_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_SIA
            // 
            this.panelOne_SIA.Controls.Add(this.buttonSaveFile_SIA);
            this.panelOne_SIA.Controls.Add(this.buttonHelp_SIA);
            this.panelOne_SIA.Controls.Add(this.buttonDone_SIA);
            this.panelOne_SIA.Controls.Add(this.buttonOpenFile_SIA);
            this.panelOne_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_SIA.Location = new System.Drawing.Point(0, 0);
            this.panelOne_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.panelOne_SIA.Name = "panelOne_SIA";
            this.panelOne_SIA.Size = new System.Drawing.Size(776, 69);
            this.panelOne_SIA.TabIndex = 0;
            // 
            // buttonSaveFile_SIA
            // 
            this.buttonSaveFile_SIA.Enabled = false;
            this.buttonSaveFile_SIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_SIA.Image")));
            this.buttonSaveFile_SIA.Location = new System.Drawing.Point(147, 11);
            this.buttonSaveFile_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveFile_SIA.Name = "buttonSaveFile_SIA";
            this.buttonSaveFile_SIA.Size = new System.Drawing.Size(63, 53);
            this.buttonSaveFile_SIA.TabIndex = 3;
            this.toolTip_SIA.SetToolTip(this.buttonSaveFile_SIA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_SIA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SIA.Click += new System.EventHandler(this.buttonSaveFile_NVD_Click);
            this.buttonSaveFile_SIA.MouseEnter += new System.EventHandler(this.buttonSaveFile_NVD_MouseEnter);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SIA.Image")));
            this.buttonHelp_SIA.Location = new System.Drawing.Point(698, 10);
            this.buttonHelp_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(67, 54);
            this.buttonHelp_SIA.TabIndex = 2;
            this.toolTip_SIA.SetToolTip(this.buttonHelp_SIA, "Сведение о программе");
            this.buttonHelp_SIA.UseVisualStyleBackColor = true;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            this.buttonHelp_SIA.MouseEnter += new System.EventHandler(this.buttonHelp_NVD_MouseEnter);
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.Enabled = false;
            this.buttonDone_SIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SIA.Image")));
            this.buttonDone_SIA.Location = new System.Drawing.Point(76, 10);
            this.buttonDone_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(65, 54);
            this.buttonDone_SIA.TabIndex = 1;
            this.toolTip_SIA.SetToolTip(this.buttonDone_SIA, "Выполнить обработку данных");
            this.buttonDone_SIA.UseVisualStyleBackColor = true;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            this.buttonDone_SIA.MouseEnter += new System.EventHandler(this.buttonDone_NVD_MouseEnter);
            // 
            // buttonOpenFile_SIA
            // 
            this.buttonOpenFile_SIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SIA.Image")));
            this.buttonOpenFile_SIA.Location = new System.Drawing.Point(9, 10);
            this.buttonOpenFile_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile_SIA.Name = "buttonOpenFile_SIA";
            this.buttonOpenFile_SIA.Size = new System.Drawing.Size(63, 54);
            this.buttonOpenFile_SIA.TabIndex = 0;
            this.toolTip_SIA.SetToolTip(this.buttonOpenFile_SIA, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_SIA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SIA.Click += new System.EventHandler(this.buttonOpenFile_NVD_Click);
            this.buttonOpenFile_SIA.MouseEnter += new System.EventHandler(this.buttonOpenFile_NVD_MouseEnter);
            // 
            // panelTwo_SIA
            // 
            this.panelTwo_SIA.Controls.Add(this.groupBoxNameedOne_SIA);
            this.panelTwo_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_SIA.Location = new System.Drawing.Point(0, 69);
            this.panelTwo_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.panelTwo_SIA.Name = "panelTwo_SIA";
            this.panelTwo_SIA.Size = new System.Drawing.Size(776, 71);
            this.panelTwo_SIA.TabIndex = 1;
            // 
            // groupBoxNameedOne_SIA
            // 
            this.groupBoxNameedOne_SIA.Controls.Add(this.textBoxNamedOne_SIA);
            this.groupBoxNameedOne_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNameedOne_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNameedOne_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNameedOne_SIA.Name = "groupBoxNameedOne_SIA";
            this.groupBoxNameedOne_SIA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNameedOne_SIA.Size = new System.Drawing.Size(776, 71);
            this.groupBoxNameedOne_SIA.TabIndex = 9;
            this.groupBoxNameedOne_SIA.TabStop = false;
            this.groupBoxNameedOne_SIA.Text = "Условие";
            // 
            // textBoxNamedOne_SIA
            // 
            this.textBoxNamedOne_SIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNamedOne_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNamedOne_SIA.Location = new System.Drawing.Point(2, 15);
            this.textBoxNamedOne_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamedOne_SIA.Multiline = true;
            this.textBoxNamedOne_SIA.Name = "textBoxNamedOne_SIA";
            this.textBoxNamedOne_SIA.ReadOnly = true;
            this.textBoxNamedOne_SIA.Size = new System.Drawing.Size(772, 54);
            this.textBoxNamedOne_SIA.TabIndex = 3;
            this.textBoxNamedOne_SIA.Text = resources.GetString("textBoxNamedOne_SIA.Text");
            // 
            // panelThree_SIA
            // 
            this.panelThree_SIA.Controls.Add(this.groupBoxTwo_SIA);
            this.panelThree_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_SIA.Location = new System.Drawing.Point(0, 140);
            this.panelThree_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.panelThree_SIA.Name = "panelThree_SIA";
            this.panelThree_SIA.Size = new System.Drawing.Size(384, 316);
            this.panelThree_SIA.TabIndex = 2;
            // 
            // groupBoxTwo_SIA
            // 
            this.groupBoxTwo_SIA.Controls.Add(this.dataGridViewInMatrix_SIA);
            this.groupBoxTwo_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTwo_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTwo_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTwo_SIA.Name = "groupBoxTwo_SIA";
            this.groupBoxTwo_SIA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTwo_SIA.Size = new System.Drawing.Size(384, 316);
            this.groupBoxTwo_SIA.TabIndex = 0;
            this.groupBoxTwo_SIA.TabStop = false;
            this.groupBoxTwo_SIA.Text = "Ввод";
            // 
            // dataGridViewInMatrix_SIA
            // 
            this.dataGridViewInMatrix_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_SIA.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_SIA.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewInMatrix_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInMatrix_SIA.Name = "dataGridViewInMatrix_SIA";
            this.dataGridViewInMatrix_SIA.RowHeadersVisible = false;
            this.dataGridViewInMatrix_SIA.RowHeadersWidth = 51;
            this.dataGridViewInMatrix_SIA.RowTemplate.Height = 24;
            this.dataGridViewInMatrix_SIA.Size = new System.Drawing.Size(380, 299);
            this.dataGridViewInMatrix_SIA.TabIndex = 0;
            // 
            // splitter_SIA
            // 
            this.splitter_SIA.Location = new System.Drawing.Point(384, 140);
            this.splitter_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.splitter_SIA.Name = "splitter_SIA";
            this.splitter_SIA.Size = new System.Drawing.Size(2, 316);
            this.splitter_SIA.TabIndex = 3;
            this.splitter_SIA.TabStop = false;
            // 
            // panelFour_SIA
            // 
            this.panelFour_SIA.Controls.Add(this.groupBoxThree_SIA);
            this.panelFour_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_SIA.Location = new System.Drawing.Point(386, 140);
            this.panelFour_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.panelFour_SIA.Name = "panelFour_SIA";
            this.panelFour_SIA.Size = new System.Drawing.Size(390, 316);
            this.panelFour_SIA.TabIndex = 4;
            // 
            // groupBoxThree_SIA
            // 
            this.groupBoxThree_SIA.Controls.Add(this.dataGridViewOutMatrix_SIA);
            this.groupBoxThree_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThree_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxThree_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxThree_SIA.Name = "groupBoxThree_SIA";
            this.groupBoxThree_SIA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxThree_SIA.Size = new System.Drawing.Size(390, 316);
            this.groupBoxThree_SIA.TabIndex = 1;
            this.groupBoxThree_SIA.TabStop = false;
            this.groupBoxThree_SIA.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_SIA
            // 
            this.dataGridViewOutMatrix_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_SIA.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_SIA.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewOutMatrix_SIA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOutMatrix_SIA.Name = "dataGridViewOutMatrix_SIA";
            this.dataGridViewOutMatrix_SIA.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_SIA.RowHeadersWidth = 51;
            this.dataGridViewOutMatrix_SIA.RowTemplate.Height = 24;
            this.dataGridViewOutMatrix_SIA.Size = new System.Drawing.Size(386, 299);
            this.dataGridViewOutMatrix_SIA.TabIndex = 0;
            // 
            // openFileDialogTask_SIA
            // 
            this.openFileDialogTask_SIA.FileName = "openFileDialog";
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
            this.ClientSize = new System.Drawing.Size(776, 456);
            this.Controls.Add(this.panelFour_SIA);
            this.Controls.Add(this.splitter_SIA);
            this.Controls.Add(this.panelThree_SIA);
            this.Controls.Add(this.panelTwo_SIA);
            this.Controls.Add(this.panelOne_SIA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(792, 495);
            this.Name = "FormMain_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 29 | Шишков И.А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelOne_SIA.ResumeLayout(false);
            this.panelTwo_SIA.ResumeLayout(false);
            this.groupBoxNameedOne_SIA.ResumeLayout(false);
            this.groupBoxNameedOne_SIA.PerformLayout();
            this.panelThree_SIA.ResumeLayout(false);
            this.groupBoxTwo_SIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_SIA)).EndInit();
            this.panelFour_SIA.ResumeLayout(false);
            this.groupBoxThree_SIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SIA;
        private System.Windows.Forms.Panel panelTwo_SIA;
        private System.Windows.Forms.GroupBox groupBoxNameedOne_SIA;
        private System.Windows.Forms.TextBox textBoxNamedOne_SIA;
        private System.Windows.Forms.Panel panelThree_SIA;
        private System.Windows.Forms.GroupBox groupBoxTwo_SIA;
        private System.Windows.Forms.Splitter splitter_SIA;
        private System.Windows.Forms.Panel panelFour_SIA;
        private System.Windows.Forms.GroupBox groupBoxThree_SIA;
        private System.Windows.Forms.Button buttonOpenFile_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SIA;
        private System.Windows.Forms.ToolTip toolTip_SIA;
        private System.Windows.Forms.Button buttonSaveFile_SIA;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_SIA;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_SIA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SIA;
    }
}

