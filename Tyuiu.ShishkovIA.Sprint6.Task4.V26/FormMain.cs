using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShishkovIA.Sprint6.Task4.V26.Lib;

namespace Tyuiu.ShishkovIA.Sprint6.Task4.V26
{
    public partial class FormMain_SIA : Form
    {
        DataService ds = new DataService();
        public FormMain_SIA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttondone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SIA.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_SIA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartMain_SIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartMain_SIA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPut_SIA.Text = "";
                chartMain_SIA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartMain_SIA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPut_SIA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutPut_SIA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n  Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 V26 выполнил студент АСОиУб-23-2 Шишков Илья Александрович", "Сообщение");
        }
    }
}
