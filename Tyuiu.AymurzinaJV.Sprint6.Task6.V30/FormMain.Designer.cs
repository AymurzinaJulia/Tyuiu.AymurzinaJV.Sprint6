namespace Tyuiu.AymurzinaJV.Sprint6.Task6.V30
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonUpload_AJV = new Button();
            openFileDialogTask_AJV = new OpenFileDialog();
            toolTip_AJV = new ToolTip(components);
            buttonDone_AJV = new Button();
            buttonInfo_AJV = new Button();
            groupBoxTask_AJV = new GroupBox();
            labelTask_AJV = new Label();
            textBoxOutput_AJV = new TextBox();
            groupBoxOutput_AJV = new GroupBox();
            groupBoxIn_AJV = new GroupBox();
            textBoxIn_AJV = new TextBox();
            groupBoxTask_AJV.SuspendLayout();
            groupBoxOutput_AJV.SuspendLayout();
            groupBoxIn_AJV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUpload_AJV
            // 
            buttonUpload_AJV.BackgroundImage = (Image)resources.GetObject("buttonUpload_AJV.BackgroundImage");
            buttonUpload_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpload_AJV.Location = new Point(11, 10);
            buttonUpload_AJV.Name = "buttonUpload_AJV";
            buttonUpload_AJV.Size = new Size(112, 70);
            buttonUpload_AJV.TabIndex = 0;
            toolTip_AJV.SetToolTip(buttonUpload_AJV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonUpload_AJV.UseVisualStyleBackColor = true;
            buttonUpload_AJV.Click += buttonUpload_AJV_Click;
            // 
            // toolTip_AJV
            // 
            toolTip_AJV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_AJV.ToolTipTitle = "Подсказка";
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.BackgroundImage = (Image)resources.GetObject("buttonDone_AJV.BackgroundImage");
            buttonDone_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_AJV.Location = new Point(142, 10);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(112, 70);
            buttonDone_AJV.TabIndex = 1;
            toolTip_AJV.SetToolTip(buttonDone_AJV, "Выполнить обработку\r\n\r\n");
            buttonDone_AJV.UseVisualStyleBackColor = true;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
            // 
            // buttonInfo_AJV
            // 
            buttonInfo_AJV.BackgroundImage = (Image)resources.GetObject("buttonInfo_AJV.BackgroundImage");
            buttonInfo_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInfo_AJV.Location = new Point(981, 12);
            buttonInfo_AJV.Name = "buttonInfo_AJV";
            buttonInfo_AJV.Size = new Size(112, 70);
            buttonInfo_AJV.TabIndex = 2;
            toolTip_AJV.SetToolTip(buttonInfo_AJV, "Сведения о программе");
            buttonInfo_AJV.UseVisualStyleBackColor = true;
            buttonInfo_AJV.Click += buttonInfo_AJV_Click;
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Location = new Point(11, 86);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(1082, 99);
            groupBoxTask_AJV.TabIndex = 3;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие:";
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = true;
            labelTask_AJV.Location = new Point(10, 28);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(925, 40);
            labelTask_AJV.TabIndex = 0;
            labelTask_AJV.Text = resources.GetString("labelTask_AJV.Text");
            // 
            // textBoxOutput_AJV
            // 
            textBoxOutput_AJV.Location = new Point(4, 27);
            textBoxOutput_AJV.Multiline = true;
            textBoxOutput_AJV.Name = "textBoxOutput_AJV";
            textBoxOutput_AJV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_AJV.Size = new Size(530, 458);
            textBoxOutput_AJV.TabIndex = 7;
            // 
            // groupBoxOutput_AJV
            // 
            groupBoxOutput_AJV.Controls.Add(textBoxOutput_AJV);
            groupBoxOutput_AJV.Location = new Point(553, 191);
            groupBoxOutput_AJV.Name = "groupBoxOutput_AJV";
            groupBoxOutput_AJV.Size = new Size(540, 496);
            groupBoxOutput_AJV.TabIndex = 8;
            groupBoxOutput_AJV.TabStop = false;
            groupBoxOutput_AJV.Text = "Вывод:";
            groupBoxOutput_AJV.Enter += groupBoxOutput_AJV_Enter;
            // 
            // groupBoxIn_AJV
            // 
            groupBoxIn_AJV.Controls.Add(textBoxIn_AJV);
            groupBoxIn_AJV.Location = new Point(7, 191);
            groupBoxIn_AJV.Name = "groupBoxIn_AJV";
            groupBoxIn_AJV.Size = new Size(540, 496);
            groupBoxIn_AJV.TabIndex = 9;
            groupBoxIn_AJV.TabStop = false;
            groupBoxIn_AJV.Text = "Ввод:";
            // 
            // textBoxIn_AJV
            // 
            textBoxIn_AJV.Location = new Point(4, 27);
            textBoxIn_AJV.Multiline = true;
            textBoxIn_AJV.Name = "textBoxIn_AJV";
            textBoxIn_AJV.ScrollBars = ScrollBars.Vertical;
            textBoxIn_AJV.Size = new Size(530, 458);
            textBoxIn_AJV.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 708);
            Controls.Add(groupBoxIn_AJV);
            Controls.Add(groupBoxOutput_AJV);
            Controls.Add(groupBoxTask_AJV);
            Controls.Add(buttonInfo_AJV);
            Controls.Add(buttonDone_AJV);
            Controls.Add(buttonUpload_AJV);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask_AJV.ResumeLayout(false);
            groupBoxTask_AJV.PerformLayout();
            groupBoxOutput_AJV.ResumeLayout(false);
            groupBoxOutput_AJV.PerformLayout();
            groupBoxIn_AJV.ResumeLayout(false);
            groupBoxIn_AJV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonUpload_AJV;
        private OpenFileDialog openFileDialogTask_AJV;
        private ToolTip toolTip_AJV;
        private Button buttonDone_AJV;
        private Button buttonInfo_AJV;
        private GroupBox groupBoxTask_AJV;
        private Label labelTask_AJV;
        private TextBox textBoxOutput_AJV;
        private GroupBox groupBoxOutput_AJV;
        private GroupBox groupBoxIn_AJV;
        private TextBox textBoxIn_AJV;
    }
}