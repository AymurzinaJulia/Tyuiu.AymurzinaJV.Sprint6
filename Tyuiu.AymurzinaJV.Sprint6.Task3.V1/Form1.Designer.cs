namespace Tyuiu.AymurzinaJV.Sprint6.Task3.V1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDone_AJV = new Button();
            groupBoxTask_AJV = new GroupBox();
            dataGridViewResult = new DataGridView();
            labelTask_AJV = new Label();
            groupBoxResult_AJV = new GroupBox();
            buttonInfo_AJV = new Button();
            textBoxResult_AJV = new TextBox();
            labelResult_AJV = new Label();
            groupBoxTask_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            groupBoxResult_AJV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.BackColor = Color.FromArgb(255, 128, 128);
            buttonDone_AJV.Location = new Point(64, 289);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(95, 33);
            buttonDone_AJV.TabIndex = 2;
            buttonDone_AJV.Text = "Выполнить";
            buttonDone_AJV.UseVisualStyleBackColor = false;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(dataGridViewResult);
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Location = new Point(12, 12);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(605, 328);
            groupBoxTask_AJV.TabIndex = 2;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(313, 23);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(286, 296);
            dataGridViewResult.TabIndex = 1;
            dataGridViewResult.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = true;
            labelTask_AJV.Location = new Point(9, 34);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(298, 140);
            labelTask_AJV.TabIndex = 0;
            labelTask_AJV.Text = "Дан массив 5 на 5 элементов. Выполнить\r\nсортировку по возрастанию в 1 столбце.\r\n25  20  28   2   6\r\n19   9  18  -7  24\r\n21  16   5  -7  -8\r\n30 -13   1 -15   2\r\n31   9  -3  -9 -18\r\n";
            // 
            // groupBoxResult_AJV
            // 
            groupBoxResult_AJV.Controls.Add(buttonInfo_AJV);
            groupBoxResult_AJV.Controls.Add(buttonDone_AJV);
            groupBoxResult_AJV.Controls.Add(textBoxResult_AJV);
            groupBoxResult_AJV.Controls.Add(labelResult_AJV);
            groupBoxResult_AJV.Location = new Point(623, 12);
            groupBoxResult_AJV.Name = "groupBoxResult_AJV";
            groupBoxResult_AJV.Size = new Size(165, 328);
            groupBoxResult_AJV.TabIndex = 3;
            groupBoxResult_AJV.TabStop = false;
            groupBoxResult_AJV.Text = "Вывод данных";
            // 
            // buttonInfo_AJV
            // 
            buttonInfo_AJV.BackColor = Color.FromArgb(255, 128, 128);
            buttonInfo_AJV.Location = new Point(6, 289);
            buttonInfo_AJV.Name = "buttonInfo_AJV";
            buttonInfo_AJV.Size = new Size(34, 33);
            buttonInfo_AJV.TabIndex = 3;
            buttonInfo_AJV.Text = "?";
            buttonInfo_AJV.UseVisualStyleBackColor = false;
            // 
            // textBoxResult_AJV
            // 
            textBoxResult_AJV.Location = new Point(6, 46);
            textBoxResult_AJV.Name = "textBoxResult_AJV";
            textBoxResult_AJV.Size = new Size(153, 27);
            textBoxResult_AJV.TabIndex = 1;
            textBoxResult_AJV.TextChanged += textBoxResult_AJV_TextChanged;
            // 
            // labelResult_AJV
            // 
            labelResult_AJV.AutoSize = true;
            labelResult_AJV.Location = new Point(6, 23);
            labelResult_AJV.Name = "labelResult_AJV";
            labelResult_AJV.Size = new Size(78, 20);
            labelResult_AJV.TabIndex = 0;
            labelResult_AJV.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(groupBoxTask_AJV);
            Controls.Add(groupBoxResult_AJV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxTask_AJV.ResumeLayout(false);
            groupBoxTask_AJV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            groupBoxResult_AJV.ResumeLayout(false);
            groupBoxResult_AJV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_AJV;
        private GroupBox groupBoxTask_AJV;
        private DataGridView dataGridViewResult;
        private Label labelTask_AJV;
        private GroupBox groupBoxResult_AJV;
        private Button buttonInfo_AJV;
        private TextBox textBoxResult_AJV;
        private Label labelResult_AJV;
    }
}