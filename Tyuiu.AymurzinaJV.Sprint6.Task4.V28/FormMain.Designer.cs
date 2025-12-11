namespace Tyuiu.AymurzinaJV.Sprint6.Task4.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            chartFunction_AJV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_AJV = new GroupBox();
            textBoxOutput_AJV = new TextBox();
            groupBoxTask_AJV = new GroupBox();
            pictureBoxTask_AJV = new PictureBox();
            labelTask_AJV = new Label();
            groupBoxInput_AJV = new GroupBox();
            textBoxEnd_AJV = new TextBox();
            textBoxStart_AJV = new TextBox();
            labelEnd_AJV = new Label();
            labelStart_AJV = new Label();
            buttonDone_AJV = new Button();
            buttonSave_AJV = new Button();
            buttonInfo_AJV = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AJV).BeginInit();
            groupBoxOutput_AJV.SuspendLayout();
            groupBoxTask_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AJV).BeginInit();
            groupBoxInput_AJV.SuspendLayout();
            SuspendLayout();
            // 
            // chartFunction_AJV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_AJV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_AJV.Legends.Add(legend1);
            chartFunction_AJV.Location = new Point(437, 124);
            chartFunction_AJV.Name = "chartFunction_AJV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_AJV.Series.Add(series1);
            chartFunction_AJV.Size = new Size(906, 613);
            chartFunction_AJV.TabIndex = 0;
            chartFunction_AJV.Text = "chartFunction_AJV";
            title1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.FromArgb(128, 128, 255);
            title1.Name = "Title1";
            title1.ShadowColor = Color.FromArgb(128, 255, 255);
            title1.Text = "График функции f(x)";
            chartFunction_AJV.Titles.Add(title1);
            // 
            // groupBoxOutput_AJV
            // 
            groupBoxOutput_AJV.Controls.Add(textBoxOutput_AJV);
            groupBoxOutput_AJV.Location = new Point(2, 124);
            groupBoxOutput_AJV.Name = "groupBoxOutput_AJV";
            groupBoxOutput_AJV.Size = new Size(429, 613);
            groupBoxOutput_AJV.TabIndex = 1;
            groupBoxOutput_AJV.TabStop = false;
            groupBoxOutput_AJV.Text = "Вывод:";
            // 
            // textBoxOutput_AJV
            // 
            textBoxOutput_AJV.Location = new Point(6, 26);
            textBoxOutput_AJV.Multiline = true;
            textBoxOutput_AJV.Name = "textBoxOutput_AJV";
            textBoxOutput_AJV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_AJV.Size = new Size(423, 587);
            textBoxOutput_AJV.TabIndex = 0;
            textBoxOutput_AJV.TextChanged += textBoxOutput_AJV_TextChanged;
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(pictureBoxTask_AJV);
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Location = new Point(8, 3);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(552, 115);
            groupBoxTask_AJV.TabIndex = 2;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие:";
            // 
            // pictureBoxTask_AJV
            // 
            pictureBoxTask_AJV.Image = (Image)resources.GetObject("pictureBoxTask_AJV.Image");
            pictureBoxTask_AJV.Location = new Point(6, 67);
            pictureBoxTask_AJV.Name = "pictureBoxTask_AJV";
            pictureBoxTask_AJV.Size = new Size(339, 48);
            pictureBoxTask_AJV.TabIndex = 1;
            pictureBoxTask_AJV.TabStop = false;
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = true;
            labelTask_AJV.Location = new Point(6, 23);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(482, 40);
            labelTask_AJV.TabIndex = 0;
            labelTask_AJV.Text = "Написать программу, которая выводит таблицу значений функции.\r\n(произвести табулирование) f(x) на заданном диапазоне [-5; 5]";
            // 
            // groupBoxInput_AJV
            // 
            groupBoxInput_AJV.Controls.Add(textBoxEnd_AJV);
            groupBoxInput_AJV.Controls.Add(textBoxStart_AJV);
            groupBoxInput_AJV.Controls.Add(labelEnd_AJV);
            groupBoxInput_AJV.Controls.Add(labelStart_AJV);
            groupBoxInput_AJV.Location = new Point(566, 3);
            groupBoxInput_AJV.Name = "groupBoxInput_AJV";
            groupBoxInput_AJV.Size = new Size(317, 115);
            groupBoxInput_AJV.TabIndex = 3;
            groupBoxInput_AJV.TabStop = false;
            groupBoxInput_AJV.Text = "Ввод данных";
            // 
            // textBoxEnd_AJV
            // 
            textBoxEnd_AJV.Location = new Point(171, 51);
            textBoxEnd_AJV.Name = "textBoxEnd_AJV";
            textBoxEnd_AJV.Size = new Size(125, 27);
            textBoxEnd_AJV.TabIndex = 3;
            // 
            // textBoxStart_AJV
            // 
            textBoxStart_AJV.Location = new Point(18, 51);
            textBoxStart_AJV.Name = "textBoxStart_AJV";
            textBoxStart_AJV.Size = new Size(125, 27);
            textBoxStart_AJV.TabIndex = 2;
            // 
            // labelEnd_AJV
            // 
            labelEnd_AJV.AutoSize = true;
            labelEnd_AJV.Location = new Point(171, 28);
            labelEnd_AJV.Name = "labelEnd_AJV";
            labelEnd_AJV.Size = new Size(94, 20);
            labelEnd_AJV.TabIndex = 1;
            labelEnd_AJV.Text = "Конец шага:";
            // 
            // labelStart_AJV
            // 
            labelStart_AJV.AutoSize = true;
            labelStart_AJV.Location = new Point(18, 28);
            labelStart_AJV.Name = "labelStart_AJV";
            labelStart_AJV.Size = new Size(88, 20);
            labelStart_AJV.TabIndex = 0;
            labelStart_AJV.Text = "Старт шага:";
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_AJV.Location = new Point(902, 27);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(127, 80);
            buttonDone_AJV.TabIndex = 4;
            buttonDone_AJV.Text = "Выполнить";
            buttonDone_AJV.UseVisualStyleBackColor = false;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
            // 
            // buttonSave_AJV
            // 
            buttonSave_AJV.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_AJV.Location = new Point(1047, 27);
            buttonSave_AJV.Name = "buttonSave_AJV";
            buttonSave_AJV.Size = new Size(127, 80);
            buttonSave_AJV.TabIndex = 5;
            buttonSave_AJV.Text = "Сохранить";
            buttonSave_AJV.UseVisualStyleBackColor = false;
            buttonSave_AJV.Click += buttonSave_AJV_Click;
            // 
            // buttonInfo_AJV
            // 
            buttonInfo_AJV.BackColor = Color.FromArgb(128, 255, 255);
            buttonInfo_AJV.Location = new Point(1193, 27);
            buttonInfo_AJV.Name = "buttonInfo_AJV";
            buttonInfo_AJV.Size = new Size(127, 80);
            buttonInfo_AJV.TabIndex = 6;
            buttonInfo_AJV.Text = "Справка";
            buttonInfo_AJV.UseVisualStyleBackColor = false;
            buttonInfo_AJV.Click += buttonInfo_AJV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1341, 736);
            Controls.Add(buttonInfo_AJV);
            Controls.Add(buttonSave_AJV);
            Controls.Add(buttonDone_AJV);
            Controls.Add(groupBoxInput_AJV);
            Controls.Add(groupBoxTask_AJV);
            Controls.Add(groupBoxOutput_AJV);
            Controls.Add(chartFunction_AJV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 28 | Аймурзина Ю.В";
            ((System.ComponentModel.ISupportInitialize)chartFunction_AJV).EndInit();
            groupBoxOutput_AJV.ResumeLayout(false);
            groupBoxOutput_AJV.PerformLayout();
            groupBoxTask_AJV.ResumeLayout(false);
            groupBoxTask_AJV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AJV).EndInit();
            groupBoxInput_AJV.ResumeLayout(false);
            groupBoxInput_AJV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AJV;
        private GroupBox groupBoxOutput_AJV;
        private TextBox textBoxOutput_AJV;
        private GroupBox groupBoxTask_AJV;
        private GroupBox groupBoxInput_AJV;
        private Button buttonDone_AJV;
        private Button buttonSave_AJV;
        private Button buttonInfo_AJV;
        private PictureBox pictureBoxTask_AJV;
        private Label labelTask_AJV;
        private TextBox textBoxEnd_AJV;
        private TextBox textBoxStart_AJV;
        private Label labelEnd_AJV;
        private Label labelStart_AJV;
    }
}
