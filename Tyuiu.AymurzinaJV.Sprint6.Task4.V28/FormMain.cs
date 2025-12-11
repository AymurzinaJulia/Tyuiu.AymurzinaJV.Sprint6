using Tyuiu.AymurzinaJV.Sprint6.Task4.V28.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxOutput_AJV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_AJV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_AJV.Text);
                int end = Convert.ToInt32(textBoxEnd_AJV.Text);

                int len = ds.GetMassFunction(start, end).Length;

                double[] nums = ds.GetMassFunction(start, end);

                this.chartFunction_AJV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AJV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_AJV.Text = "";

                chartFunction_AJV.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_AJV.Series[0].Points.AddXY(start, nums[i]);
                    textBoxOutput_AJV.AppendText(nums[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_AJV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы РППб-25-1 Аймурзина Юлия Владимировна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_AJV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutput_AJV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
    }
}
