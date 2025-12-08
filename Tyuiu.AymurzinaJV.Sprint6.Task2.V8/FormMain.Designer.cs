namespace Tyuiu.AymurzinaJV.Sprint6.Task2.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone_AJV = new Button();
            buttonInfo_AJV = new Button();
            groupBoxInput_AJV = new GroupBox();
            labelEnd_AJV = new Label();
            labelStart_AJV = new Label();
            textBoxEnd_AJV = new TextBox();
            textBoxStart_AJV = new TextBox();
            groupBoxTask_AJV = new GroupBox();
            pictureBoxFormula_AJV = new PictureBox();
            labelTask_AJV = new Label();
            groupBoxResult_AJV = new GroupBox();
            dataGridViewFunction_AJV = new DataGridView();
            labelResult_AJV = new Label();
            groupBoxInput_AJV.SuspendLayout();
            groupBoxTask_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AJV).BeginInit();
            groupBoxResult_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AJV).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.BackColor = Color.FromArgb(255, 128, 128);
            buttonDone_AJV.Location = new Point(476, 357);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(170, 81);
            buttonDone_AJV.TabIndex = 8;
            buttonDone_AJV.Text = "Выполнить";
            buttonDone_AJV.UseVisualStyleBackColor = false;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
            // 
            // buttonInfo_AJV
            // 
            buttonInfo_AJV.BackColor = Color.FromArgb(128, 64, 64);
            buttonInfo_AJV.Location = new Point(351, 357);
            buttonInfo_AJV.Name = "buttonInfo_AJV";
            buttonInfo_AJV.Size = new Size(90, 81);
            buttonInfo_AJV.TabIndex = 7;
            buttonInfo_AJV.Text = "Справка";
            buttonInfo_AJV.UseVisualStyleBackColor = false;
            // 
            // groupBoxInput_AJV
            // 
            groupBoxInput_AJV.Controls.Add(labelEnd_AJV);
            groupBoxInput_AJV.Controls.Add(labelStart_AJV);
            groupBoxInput_AJV.Controls.Add(textBoxEnd_AJV);
            groupBoxInput_AJV.Controls.Add(textBoxStart_AJV);
            groupBoxInput_AJV.Location = new Point(12, 343);
            groupBoxInput_AJV.Name = "groupBoxInput_AJV";
            groupBoxInput_AJV.Size = new Size(296, 95);
            groupBoxInput_AJV.TabIndex = 6;
            groupBoxInput_AJV.TabStop = false;
            groupBoxInput_AJV.Text = "Ввод данных";
            // 
            // labelEnd_AJV
            // 
            labelEnd_AJV.AutoSize = true;
            labelEnd_AJV.Location = new Point(150, 23);
            labelEnd_AJV.Name = "labelEnd_AJV";
            labelEnd_AJV.Size = new Size(94, 20);
            labelEnd_AJV.TabIndex = 3;
            labelEnd_AJV.Text = "Конец шага:";
            // 
            // labelStart_AJV
            // 
            labelStart_AJV.AutoSize = true;
            labelStart_AJV.Location = new Point(8, 23);
            labelStart_AJV.Name = "labelStart_AJV";
            labelStart_AJV.Size = new Size(88, 20);
            labelStart_AJV.TabIndex = 2;
            labelStart_AJV.Text = "Старт шага:";
            // 
            // textBoxEnd_AJV
            // 
            textBoxEnd_AJV.Location = new Point(150, 46);
            textBoxEnd_AJV.Name = "textBoxEnd_AJV";
            textBoxEnd_AJV.Size = new Size(125, 27);
            textBoxEnd_AJV.TabIndex = 1;
            // 
            // textBoxStart_AJV
            // 
            textBoxStart_AJV.Location = new Point(6, 46);
            textBoxStart_AJV.Name = "textBoxStart_AJV";
            textBoxStart_AJV.Size = new Size(125, 27);
            textBoxStart_AJV.TabIndex = 0;
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(pictureBoxFormula_AJV);
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Location = new Point(12, 9);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(665, 331);
            groupBoxTask_AJV.TabIndex = 5;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие";
            // 
            // pictureBoxFormula_AJV
            // 
            pictureBoxFormula_AJV.Image = (Image)resources.GetObject("pictureBoxFormula_AJV.Image");
            pictureBoxFormula_AJV.Location = new Point(7, 82);
            pictureBoxFormula_AJV.Name = "pictureBoxFormula_AJV";
            pictureBoxFormula_AJV.Size = new Size(342, 49);
            pictureBoxFormula_AJV.TabIndex = 1;
            pictureBoxFormula_AJV.TabStop = false;
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = true;
            labelTask_AJV.Location = new Point(7, 26);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(475, 80);
            labelTask_AJV.TabIndex = 0;
            labelTask_AJV.Text = "Протабулировать функцию f(x) на заданном диапазоне с шагом 1.\r\nРезультат вывести в DataGridView и построить график функции\r\n\r\n\r\n";
            // 
            // groupBoxResult_AJV
            // 
            groupBoxResult_AJV.Controls.Add(dataGridViewFunction_AJV);
            groupBoxResult_AJV.Controls.Add(labelResult_AJV);
            groupBoxResult_AJV.Location = new Point(697, 9);
            groupBoxResult_AJV.Name = "groupBoxResult_AJV";
            groupBoxResult_AJV.Size = new Size(658, 429);
            groupBoxResult_AJV.TabIndex = 9;
            groupBoxResult_AJV.TabStop = false;
            groupBoxResult_AJV.Text = "Вывод данных";
            // 
            // dataGridViewFunction_AJV
            // 
            dataGridViewFunction_AJV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_AJV.Location = new Point(6, 46);
            dataGridViewFunction_AJV.Name = "dataGridViewFunction_AJV";
            dataGridViewFunction_AJV.RowHeadersWidth = 51;
            dataGridViewFunction_AJV.Size = new Size(193, 361);
            dataGridViewFunction_AJV.TabIndex = 2;
            dataGridViewFunction_AJV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelResult_AJV
            // 
            labelResult_AJV.AutoSize = true;
            labelResult_AJV.Location = new Point(6, 23);
            labelResult_AJV.Name = "labelResult_AJV";
            labelResult_AJV.Size = new Size(78, 20);
            labelResult_AJV.TabIndex = 1;
            labelResult_AJV.Text = "Результат:";
            labelResult_AJV.Click += labelResult_AJV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 450);
            Controls.Add(groupBoxResult_AJV);
            Controls.Add(buttonDone_AJV);
            Controls.Add(buttonInfo_AJV);
            Controls.Add(groupBoxInput_AJV);
            Controls.Add(groupBoxTask_AJV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 8 | Аймурзина Ю.В";
            groupBoxInput_AJV.ResumeLayout(false);
            groupBoxInput_AJV.PerformLayout();
            groupBoxTask_AJV.ResumeLayout(false);
            groupBoxTask_AJV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AJV).EndInit();
            groupBoxResult_AJV.ResumeLayout(false);
            groupBoxResult_AJV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AJV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_AJV;
        private Button buttonInfo_AJV;
        private GroupBox groupBoxInput_AJV;
        private Label labelEnd_AJV;
        private Label labelStart_AJV;
        private TextBox textBoxEnd_AJV;
        private TextBox textBoxStart_AJV;
        private GroupBox groupBoxTask_AJV;
        private PictureBox pictureBoxFormula_AJV;
        private Label labelTask_AJV;
        private GroupBox groupBoxResult_AJV;
        private DataGridView dataGridViewFunction_AJV;
        private Label labelResult_AJV;
        private ScottPlot.WinForms.FormsPlot formsPlotFunction_AJV;
    }
}
