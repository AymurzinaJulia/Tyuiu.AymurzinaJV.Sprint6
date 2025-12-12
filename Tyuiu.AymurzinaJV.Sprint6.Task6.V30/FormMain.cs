using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AymurzinaJV.Sprint6.Task6.V30.Lib;

namespace Tyuiu.AymurzinaJV.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonUpload_AJV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AJV.ShowDialog();
            openFilePath = openFileDialogTask_AJV.FileName;
            textBoxIn_AJV.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_AJV.Text = groupBoxOutput_AJV.Text + " " + openFileDialogTask_AJV.FileName;
            buttonDone_AJV.Enabled = true;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_AJV_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOutput_AJV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_AJV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void groupBoxOutput_AJV_Enter(object sender, EventArgs e)
        {

        }
    }
}
