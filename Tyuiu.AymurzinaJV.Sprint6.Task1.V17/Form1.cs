using Tyuiu.AymurzinaJV.Sprint6.Task1.V17.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task1.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxFormula_AJV_Click(object sender, EventArgs e)
        {

        }

        private void labelTask_AJV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStart_AJV_TextChanged(object sender, EventArgs e)
        {

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

                textBoxResult_AJV.Font = new Font("Consolas", 10f);

                textBoxResult_AJV.Text = "";
                textBoxResult_AJV.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_AJV.AppendText("|    X     |    F(x)   |" + Environment.NewLine);
                textBoxResult_AJV.AppendText("+----------+-----------+" + Environment.NewLine);


                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,6:f2}   |", start, nums[i]);
                    textBoxResult_AJV.AppendText(strLine + Environment.NewLine);
                    start++;
                }
                textBoxResult_AJV.AppendText("+----------+-----------+" );
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
