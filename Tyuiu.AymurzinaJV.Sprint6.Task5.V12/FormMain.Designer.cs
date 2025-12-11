namespace Tyuiu.AymurzinaJV.Sprint6.Task5.V12
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
            buttonSave_AJV = new Button();
            groupBoxOutput_AJV = new GroupBox();
            dataGridViewResult_AJV = new DataGridView();
            groupBoxTask_AJV = new GroupBox();
            labelTask_AJV = new Label();
            buttonInfo_AJV = new Button();
            buttonDone_AJV = new Button();
            chartResult_AJV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AJV).BeginInit();
            groupBoxTask_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_AJV).BeginInit();
            SuspendLayout();
            // 
            // buttonSave_AJV
            // 
            buttonSave_AJV.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_AJV.Location = new Point(960, 35);
            buttonSave_AJV.Name = "buttonSave_AJV";
            buttonSave_AJV.Size = new Size(127, 80);
            buttonSave_AJV.TabIndex = 11;
            buttonSave_AJV.Text = "Открыть файл";
            buttonSave_AJV.UseVisualStyleBackColor = false;
            buttonSave_AJV.Click += buttonSave_AJV_Click;
            // 
            // groupBoxOutput_AJV
            // 
            groupBoxOutput_AJV.Controls.Add(dataGridViewResult_AJV);
            groupBoxOutput_AJV.Location = new Point(6, 133);
            groupBoxOutput_AJV.Name = "groupBoxOutput_AJV";
            groupBoxOutput_AJV.Size = new Size(308, 613);
            groupBoxOutput_AJV.TabIndex = 7;
            groupBoxOutput_AJV.TabStop = false;
            groupBoxOutput_AJV.Text = "Вывод:";
            // 
            // dataGridViewResult_AJV
            // 
            dataGridViewResult_AJV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_AJV.Location = new Point(6, 26);
            dataGridViewResult_AJV.Name = "dataGridViewResult_AJV";
            dataGridViewResult_AJV.RowHeadersWidth = 51;
            dataGridViewResult_AJV.Size = new Size(300, 581);
            dataGridViewResult_AJV.TabIndex = 0;
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Location = new Point(12, 12);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(782, 115);
            groupBoxTask_AJV.TabIndex = 8;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие:";
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = true;
            labelTask_AJV.Location = new Point(6, 23);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(752, 40);
            labelTask_AJV.TabIndex = 0;
            labelTask_AJV.Text = "Прочитать данные из файла InPutFileTask5V12.txt. Вывести в dataGridView. Вывести все числа не кратные 5.\r\nПостроить диаграмму по этим значениям";
            // 
            // buttonInfo_AJV
            // 
            buttonInfo_AJV.BackColor = Color.FromArgb(128, 255, 255);
            buttonInfo_AJV.Location = new Point(1106, 35);
            buttonInfo_AJV.Name = "buttonInfo_AJV";
            buttonInfo_AJV.Size = new Size(127, 80);
            buttonInfo_AJV.TabIndex = 12;
            buttonInfo_AJV.Text = "Справка";
            buttonInfo_AJV.UseVisualStyleBackColor = false;
            buttonInfo_AJV.Click += buttonInfo_AJV_Click;
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_AJV.Location = new Point(815, 35);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(127, 80);
            buttonDone_AJV.TabIndex = 10;
            buttonDone_AJV.Text = "Выполнить";
            buttonDone_AJV.UseVisualStyleBackColor = false;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
            // 
            // chartResult_AJV
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_AJV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_AJV.Legends.Add(legend1);
            chartResult_AJV.Location = new Point(330, 140);
            chartResult_AJV.Name = "chartResult_AJV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_AJV.Series.Add(series1);
            chartResult_AJV.Size = new Size(903, 600);
            chartResult_AJV.TabIndex = 13;
            chartResult_AJV.Text = "chartResult_AJV";
            chartResult_AJV.Click += chartResult_AJV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1252, 750);
            Controls.Add(chartResult_AJV);
            Controls.Add(buttonSave_AJV);
            Controls.Add(groupBoxOutput_AJV);
            Controls.Add(groupBoxTask_AJV);
            Controls.Add(buttonInfo_AJV);
            Controls.Add(buttonDone_AJV);
            Name = "FormMain";
            Text = "Form1";
            groupBoxOutput_AJV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AJV).EndInit();
            groupBoxTask_AJV.ResumeLayout(false);
            groupBoxTask_AJV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_AJV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave_AJV;
        private GroupBox groupBoxOutput_AJV;
        private GroupBox groupBoxTask_AJV;
        private Label labelTask_AJV;
        private Button buttonInfo_AJV;
        private Button buttonDone_AJV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AJV;
        private DataGridView dataGridViewResult_AJV;
    }
}
