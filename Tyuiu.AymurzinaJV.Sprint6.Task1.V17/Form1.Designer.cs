namespace Tyuiu.AymurzinaJV.Sprint6.Task1.V17
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxTask_AJV = new GroupBox();
            pictureBoxFormula_AJV = new PictureBox();
            labelTask_AJV = new Label();
            groupBoxInput_AJV = new GroupBox();
            textBoxStart_AJV = new TextBox();
            textBoxEnd_AJV = new TextBox();
            labelStart_AJV = new Label();
            labelEnd_AJV = new Label();
            groupBoxResult_AJV = new GroupBox();
            buttonInfo_AJV = new Button();
            buttonDone_AJV = new Button();
            labelResult_AJV = new Label();
            textBoxResult_AJV = new TextBox();
            groupBoxTask_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AJV).BeginInit();
            groupBoxInput_AJV.SuspendLayout();
            groupBoxResult_AJV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(pictureBoxFormula_AJV);
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Location = new Point(12, 12);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(665, 328);
            groupBoxTask_AJV.TabIndex = 0;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие";
            // 
            // pictureBoxFormula_AJV
            // 
            pictureBoxFormula_AJV.Image = (Image)resources.GetObject("pictureBoxFormula_AJV.Image");
            pictureBoxFormula_AJV.Location = new Point(7, 82);
            pictureBoxFormula_AJV.Name = "pictureBoxFormula_AJV";
            pictureBoxFormula_AJV.Size = new Size(267, 50);
            pictureBoxFormula_AJV.TabIndex = 1;
            pictureBoxFormula_AJV.TabStop = false;
            pictureBoxFormula_AJV.Click += pictureBoxFormula_AJV_Click;
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = true;
            labelTask_AJV.Location = new Point(7, 26);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(475, 40);
            labelTask_AJV.TabIndex = 0;
            labelTask_AJV.Text = "Протабулировать функцию f(x) на заданном диапазоне с шагом 1.\r\nРезультат вывести в виде таблицы\r\n";
            labelTask_AJV.Click += labelTask_AJV_Click;
            // 
            // groupBoxInput_AJV
            // 
            groupBoxInput_AJV.Controls.Add(labelEnd_AJV);
            groupBoxInput_AJV.Controls.Add(labelStart_AJV);
            groupBoxInput_AJV.Controls.Add(textBoxEnd_AJV);
            groupBoxInput_AJV.Controls.Add(textBoxStart_AJV);
            groupBoxInput_AJV.Location = new Point(12, 346);
            groupBoxInput_AJV.Name = "groupBoxInput_AJV";
            groupBoxInput_AJV.Size = new Size(296, 92);
            groupBoxInput_AJV.TabIndex = 1;
            groupBoxInput_AJV.TabStop = false;
            groupBoxInput_AJV.Text = "Ввод данных";
            // 
            // textBoxStart_AJV
            // 
            textBoxStart_AJV.Location = new Point(6, 46);
            textBoxStart_AJV.Name = "textBoxStart_AJV";
            textBoxStart_AJV.Size = new Size(125, 27);
            textBoxStart_AJV.TabIndex = 0;
            textBoxStart_AJV.TextChanged += textBoxStart_AJV_TextChanged;
            // 
            // textBoxEnd_AJV
            // 
            textBoxEnd_AJV.Location = new Point(150, 46);
            textBoxEnd_AJV.Name = "textBoxEnd_AJV";
            textBoxEnd_AJV.Size = new Size(125, 27);
            textBoxEnd_AJV.TabIndex = 1;
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
            // labelEnd_AJV
            // 
            labelEnd_AJV.AutoSize = true;
            labelEnd_AJV.Location = new Point(150, 23);
            labelEnd_AJV.Name = "labelEnd_AJV";
            labelEnd_AJV.Size = new Size(94, 20);
            labelEnd_AJV.TabIndex = 3;
            labelEnd_AJV.Text = "Конец шага:";
            // 
            // groupBoxResult_AJV
            // 
            groupBoxResult_AJV.Controls.Add(textBoxResult_AJV);
            groupBoxResult_AJV.Controls.Add(labelResult_AJV);
            groupBoxResult_AJV.Location = new Point(683, 12);
            groupBoxResult_AJV.Name = "groupBoxResult_AJV";
            groupBoxResult_AJV.Size = new Size(408, 426);
            groupBoxResult_AJV.TabIndex = 2;
            groupBoxResult_AJV.TabStop = false;
            groupBoxResult_AJV.Text = "Вывод данных";
            // 
            // buttonInfo_AJV
            // 
            buttonInfo_AJV.BackColor = Color.FromArgb(128, 64, 64);
            buttonInfo_AJV.Location = new Point(351, 360);
            buttonInfo_AJV.Name = "buttonInfo_AJV";
            buttonInfo_AJV.Size = new Size(90, 78);
            buttonInfo_AJV.TabIndex = 3;
            buttonInfo_AJV.Text = "Справка";
            buttonInfo_AJV.UseVisualStyleBackColor = false;
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.BackColor = Color.FromArgb(255, 128, 128);
            buttonDone_AJV.Location = new Point(476, 360);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(170, 78);
            buttonDone_AJV.TabIndex = 4;
            buttonDone_AJV.Text = "Выполнить";
            buttonDone_AJV.UseVisualStyleBackColor = false;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
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
            // textBoxResult_AJV
            // 
            textBoxResult_AJV.BackColor = SystemColors.Control;
            textBoxResult_AJV.Location = new Point(6, 46);
            textBoxResult_AJV.Multiline = true;
            textBoxResult_AJV.Name = "textBoxResult_AJV";
            textBoxResult_AJV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_AJV.Size = new Size(396, 374);
            textBoxResult_AJV.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 450);
            Controls.Add(buttonDone_AJV);
            Controls.Add(buttonInfo_AJV);
            Controls.Add(groupBoxResult_AJV);
            Controls.Add(groupBoxInput_AJV);
            Controls.Add(groupBoxTask_AJV);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 17 | Аймурзина Ю.В";
            groupBoxTask_AJV.ResumeLayout(false);
            groupBoxTask_AJV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AJV).EndInit();
            groupBoxInput_AJV.ResumeLayout(false);
            groupBoxInput_AJV.PerformLayout();
            groupBoxResult_AJV.ResumeLayout(false);
            groupBoxResult_AJV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AJV;
        private Label labelTask_AJV;
        private PictureBox pictureBoxFormula_AJV;
        private GroupBox groupBoxInput_AJV;
        private Label labelEnd_AJV;
        private Label labelStart_AJV;
        private TextBox textBoxEnd_AJV;
        private TextBox textBoxStart_AJV;
        private GroupBox groupBoxResult_AJV;
        private TextBox textBoxResult_AJV;
        private Label labelResult_AJV;
        private Button buttonInfo_AJV;
        private Button buttonDone_AJV;
    }
}
