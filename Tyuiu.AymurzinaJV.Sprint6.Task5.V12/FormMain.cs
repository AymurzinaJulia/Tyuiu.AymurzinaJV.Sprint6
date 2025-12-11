using System.Windows.Forms;
using Tyuiu.AymurzinaJV.Sprint6.Task5.V12.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V12.txt";
        private void buttonDone_AJV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_AJV.ColumnCount = 2;
            dataGridViewResult_AJV.Columns[0].Width = 20;
            dataGridViewResult_AJV.Columns[1].Width = 50;

            this.chartResult_AJV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_AJV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_AJV.Series[0].Points.Clear();

            double[] nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewResult_AJV.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartResult_AJV.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonSave_AJV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_AJV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы РППб-25-1 Аймурзина Юлия Владимировна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartResult_AJV_Click(object sender, EventArgs e)
        {

        }
        
    }
}
