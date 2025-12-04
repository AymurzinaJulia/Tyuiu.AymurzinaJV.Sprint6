using System.Linq.Expressions;
using Tyuiu.AymurzinaJV.Sprint6.Task0.V7.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8)) e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_AJV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_AJV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutput_AJV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxXInput_AJV.Text)));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxOutput_AJV_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxTask_AJV_Click(object sender, EventArgs e)
        {

        }
    }
}
