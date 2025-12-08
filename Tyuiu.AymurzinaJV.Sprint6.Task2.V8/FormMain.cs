
extern alias ChartLib;
using Chart = ChartLib::System.Windows.Forms.DataVisualization.Charting.Chart;
using ChartArea = ChartLib::System.Windows.Forms.DataVisualization.Charting.ChartArea;
using Series = ChartLib::System.Windows.Forms.DataVisualization.Charting.Series;
using Tyuiu.AymurzinaJV.Sprint6.Task2.V8.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_AJV_Click(object sender, EventArgs e)
        {
            try
            {

                int start = Convert.ToInt32(textBoxStart_AJV.Text);
                int end = Convert.ToInt32(textBoxEnd_AJV.Text);

                string strLine;

                int len = ds.GetMassFunction(start, end).Length;

                double[] nums;
                nums = new double[len];
                nums = ds.GetMassFunction(start, end);

                this.chart1.titles.add("График функции");

                this.chart1.chartareas[0].axisX.title = "Ось X";
                this.chart1.chartareas[0].axisY.title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_AJV.Rows.Add(Convert.ToString(start), Convert.ToString(nums[i]));

                    this.chart1.Series[0].Points.AddXY(start, nums[i]);

                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelResult_AJV_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
