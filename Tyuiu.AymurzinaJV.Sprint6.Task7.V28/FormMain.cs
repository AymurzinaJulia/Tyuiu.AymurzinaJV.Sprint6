using Tyuiu.AymurzinaJV.Sprint6.Task7.V28.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_AJV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_AJV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        public static int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] nums = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    nums[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return nums;
        }
        private void buttonUpload_AJV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AJV.ShowDialog();
            openFilePath = openFileDialogTask_AJV.FileName;

            int[,] nums = LoadFromFileData(openFilePath);

            rows = nums.GetLength(0);
            cols = nums.GetLength(1);

            dataGridViewIn_AJV.ColumnCount = cols;
            dataGridViewIn_AJV.RowCount = rows;
            dataGridViewOut_AJV.ColumnCount = cols;
            dataGridViewOut_AJV.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn_AJV.Columns[i].Width = 35;
                dataGridViewOut_AJV.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn_AJV.Rows[r].Cells[c].Value = nums[r, c];
                }
            }

            nums = ds.GetMatrix(openFilePath);
            buttonDone_AJV.Enabled = true;
        }

        private void buttonInfo_AJV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_AJV_Click(object sender, EventArgs e)
        {
            int[,] nums = new int[rows, cols];
            nums = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut_AJV.Rows[r].Cells[c].Value = nums[r, c];
                }
            }

            buttonSave_AJV.Enabled = true;
        }

        private void buttonSave_AJV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_AJV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_AJV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_AJV.ShowDialog();

            string path = saveFileDialogMatrix_AJV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(path);

            int rows = dataGridViewOut_AJV.RowCount;
            int cols = dataGridViewOut_AJV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += dataGridViewOut_AJV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_AJV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
