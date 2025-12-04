namespace Tyuiu.AymurzinaJV.Sprint6.Task0.V7
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
            groupBoxTask_AJV = new GroupBox();
            labelTask_AJV = new Label();
            pictureBoxFormula_AJV = new PictureBox();
            textBoxXInput_AJV = new TextBox();
            groupBoxInput_AJV = new GroupBox();
            labelXInput_AJV = new Label();
            groupBoxOutput_AJV = new GroupBox();
            textBoxOutput_AJV = new TextBox();
            labelOutput_AJV = new Label();
            buttonDevInfo_AJV = new Button();
            buttonDone_AJV = new Button();
            groupBoxTask_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AJV).BeginInit();
            groupBoxInput_AJV.SuspendLayout();
            groupBoxOutput_AJV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Controls.Add(pictureBoxFormula_AJV);
            groupBoxTask_AJV.Location = new Point(21, 12);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(754, 232);
            groupBoxTask_AJV.TabIndex = 0;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие";
            groupBoxTask_AJV.Enter += groupBox1_Enter;
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = true;
            labelTask_AJV.Location = new Point(6, 26);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(257, 20);
            labelTask_AJV.TabIndex = 1;
            labelTask_AJV.Text = "Вычислить выражение по формуле";
            labelTask_AJV.Click += label1_Click;
            // 
            // pictureBoxFormula_AJV
            // 
            pictureBoxFormula_AJV.Image = (Image)resources.GetObject("pictureBoxFormula_AJV.Image");
            pictureBoxFormula_AJV.Location = new Point(588, 26);
            pictureBoxFormula_AJV.Name = "pictureBoxFormula_AJV";
            pictureBoxFormula_AJV.Size = new Size(135, 70);
            pictureBoxFormula_AJV.TabIndex = 1;
            pictureBoxFormula_AJV.TabStop = false;
            pictureBoxFormula_AJV.Click += pictureBoxTask_AJV_Click;
            // 
            // textBoxXInput_AJV
            // 
            textBoxXInput_AJV.BackColor = SystemColors.Info;
            textBoxXInput_AJV.Location = new Point(10, 61);
            textBoxXInput_AJV.Name = "textBoxXInput_AJV";
            textBoxXInput_AJV.Size = new Size(114, 27);
            textBoxXInput_AJV.TabIndex = 0;
            textBoxXInput_AJV.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxInput_AJV
            // 
            groupBoxInput_AJV.Controls.Add(labelXInput_AJV);
            groupBoxInput_AJV.Controls.Add(textBoxXInput_AJV);
            groupBoxInput_AJV.Location = new Point(21, 250);
            groupBoxInput_AJV.Name = "groupBoxInput_AJV";
            groupBoxInput_AJV.Size = new Size(351, 135);
            groupBoxInput_AJV.TabIndex = 1;
            groupBoxInput_AJV.TabStop = false;
            groupBoxInput_AJV.Text = "Ввод данных";
            groupBoxInput_AJV.Enter += groupBoxInput_AJV_Enter;
            // 
            // labelXInput_AJV
            // 
            labelXInput_AJV.AutoSize = true;
            labelXInput_AJV.Location = new Point(10, 31);
            labelXInput_AJV.Name = "labelXInput_AJV";
            labelXInput_AJV.Size = new Size(114, 20);
            labelXInput_AJV.TabIndex = 1;
            labelXInput_AJV.Text = "Переменная X:";
            // 
            // groupBoxOutput_AJV
            // 
            groupBoxOutput_AJV.Controls.Add(textBoxOutput_AJV);
            groupBoxOutput_AJV.Controls.Add(labelOutput_AJV);
            groupBoxOutput_AJV.Location = new Point(378, 250);
            groupBoxOutput_AJV.Name = "groupBoxOutput_AJV";
            groupBoxOutput_AJV.Size = new Size(397, 135);
            groupBoxOutput_AJV.TabIndex = 2;
            groupBoxOutput_AJV.TabStop = false;
            groupBoxOutput_AJV.Text = "Вывод данных";
            // 
            // textBoxOutput_AJV
            // 
            textBoxOutput_AJV.BackColor = SystemColors.Control;
            textBoxOutput_AJV.Location = new Point(13, 61);
            textBoxOutput_AJV.Name = "textBoxOutput_AJV";
            textBoxOutput_AJV.ReadOnly = true;
            textBoxOutput_AJV.Size = new Size(125, 27);
            textBoxOutput_AJV.TabIndex = 3;
            textBoxOutput_AJV.TextChanged += textBoxOutput_AJV_TextChanged;
            // 
            // labelOutput_AJV
            // 
            labelOutput_AJV.AutoSize = true;
            labelOutput_AJV.Location = new Point(6, 31);
            labelOutput_AJV.Name = "labelOutput_AJV";
            labelOutput_AJV.Size = new Size(78, 20);
            labelOutput_AJV.TabIndex = 2;
            labelOutput_AJV.Text = "Результат:";
            // 
            // buttonDevInfo_AJV
            // 
            buttonDevInfo_AJV.FlatStyle = FlatStyle.Flat;
            buttonDevInfo_AJV.Location = new Point(570, 395);
            buttonDevInfo_AJV.Name = "buttonDevInfo_AJV";
            buttonDevInfo_AJV.Size = new Size(44, 43);
            buttonDevInfo_AJV.TabIndex = 4;
            buttonDevInfo_AJV.Text = "?";
            buttonDevInfo_AJV.UseVisualStyleBackColor = true;
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.Location = new Point(629, 395);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(146, 43);
            buttonDone_AJV.TabIndex = 5;
            buttonDone_AJV.Text = "Выполнить";
            buttonDone_AJV.UseVisualStyleBackColor = true;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_AJV);
            Controls.Add(groupBoxOutput_AJV);
            Controls.Add(buttonDevInfo_AJV);
            Controls.Add(groupBoxInput_AJV);
            Controls.Add(groupBoxTask_AJV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант7 | Аймурзина Ю.В";
            groupBoxTask_AJV.ResumeLayout(false);
            groupBoxTask_AJV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AJV).EndInit();
            groupBoxInput_AJV.ResumeLayout(false);
            groupBoxInput_AJV.PerformLayout();
            groupBoxOutput_AJV.ResumeLayout(false);
            groupBoxOutput_AJV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AJV;
        private TextBox textBoxXInput_AJV;
        private PictureBox pictureBoxFormula_AJV;
        private GroupBox groupBoxInput_AJV;
        private GroupBox groupBoxOutput_AJV;
        private Label labelTask_AJV;
        private Label labelXInput_AJV;
        private Label labelOutput_AJV;
        private TextBox textBoxOutput_AJV;
        private Button buttonDevInfo_AJV;
        private Button buttonDone_AJV;
    }
}
