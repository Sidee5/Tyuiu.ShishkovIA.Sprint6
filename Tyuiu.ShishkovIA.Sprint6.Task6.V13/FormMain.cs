using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShishkovIA.Sprint6.Task6.V13.Lib;

namespace Tyuiu.ShishkovIA.Sprint6.Task6.V13
{
    public partial class FormMain_SIA : Form
    {
        public FormMain_SIA()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService dataService = new DataService();
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            textBoxResult_SIA.Text = dataService.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            FormAbout_SIA formAbout = new FormAbout_SIA();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SIA.ShowDialog();
            openFilePath = openFileDialogTask_SIA.FileName;
            textBoxInput_SIA.Text = File.ReadAllText(openFilePath);
            groupBoxResult_SIA.Text = groupBoxResult_SIA.Text + " " + openFileDialogTask_SIA.FileName;
            buttonDone_SIA.Enabled = true;
        }
    }
}
