using System.Windows.Forms;

namespace Tyuiu.AymurzinaJV.Sprint6.Task7.V28
{
    partial class FormAbout
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
            panelTop_AJV = new Panel();
            buttonSave_AJV = new Button();
            buttonInfo_AJV = new Button();
            buttonDone_AJV = new Button();
            buttonUpload_AJV = new Button();
            groupBoxTask_AJV = new GroupBox();
            labelTask_AJV = new Label();
            splitContainer1 = new SplitContainer();
            groupBoxIn_AJV = new GroupBox();
            dataGridViewIn_AJV = new DataGridView();
            groupBoxOutput_AJV = new GroupBox();
            dataGridViewOut_AJV = new DataGridView();
            toolTip_AJV = new ToolTip(components);
            openFileDialogTask_AJV = new OpenFileDialog();
            saveFileDialogMatrix_AJV = new SaveFileDialog();
            panelTop_AJV.SuspendLayout();
            groupBoxTask_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxIn_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AJV).BeginInit();
            groupBoxOutput_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AJV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_AJV
            // 
            panelTop_AJV.Controls.Add(buttonSave_AJV);
            panelTop_AJV.Controls.Add(buttonInfo_AJV);
            panelTop_AJV.Controls.Add(buttonDone_AJV);
            panelTop_AJV.Controls.Add(buttonUpload_AJV);
            panelTop_AJV.Dock = DockStyle.Top;
            panelTop_AJV.Location = new Point(0, 0);
            panelTop_AJV.Name = "panelTop_AJV";
            panelTop_AJV.Size = new Size(1082, 91);
            panelTop_AJV.TabIndex = 0;
            // 
            // buttonSave_AJV
            // 
            buttonSave_AJV.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonSave_AJV.BackgroundImage = (Image)resources.GetObject("buttonSave_AJV.BackgroundImage");
            buttonSave_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSave_AJV.Enabled = false;
            buttonSave_AJV.Location = new Point(260, 9);
            buttonSave_AJV.Name = "buttonSave_AJV";
            buttonSave_AJV.Size = new Size(112, 70);
            buttonSave_AJV.TabIndex = 6;
            toolTip_AJV.SetToolTip(buttonSave_AJV, "Сохранить файл");
            buttonSave_AJV.UseVisualStyleBackColor = true;
            buttonSave_AJV.Click += buttonSave_AJV_Click;
            // 
            // buttonInfo_AJV
            // 
            buttonInfo_AJV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_AJV.BackgroundImage = (Image)resources.GetObject("buttonInfo_AJV.BackgroundImage");
            buttonInfo_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInfo_AJV.Location = new Point(970, 11);
            buttonInfo_AJV.Name = "buttonInfo_AJV";
            buttonInfo_AJV.Size = new Size(112, 70);
            buttonInfo_AJV.TabIndex = 5;
            toolTip_AJV.SetToolTip(buttonInfo_AJV, "Сведения о программе");
            buttonInfo_AJV.UseVisualStyleBackColor = true;
            buttonInfo_AJV.Click += buttonInfo_AJV_Click;
            // 
            // buttonDone_AJV
            // 
            buttonDone_AJV.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonDone_AJV.BackgroundImage = (Image)resources.GetObject("buttonDone_AJV.BackgroundImage");
            buttonDone_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_AJV.Enabled = false;
            buttonDone_AJV.Location = new Point(131, 9);
            buttonDone_AJV.Name = "buttonDone_AJV";
            buttonDone_AJV.Size = new Size(112, 70);
            buttonDone_AJV.TabIndex = 4;
            toolTip_AJV.SetToolTip(buttonDone_AJV, "Выполнить обработку");
            buttonDone_AJV.UseVisualStyleBackColor = true;
            buttonDone_AJV.Click += buttonDone_AJV_Click;
            // 
            // buttonUpload_AJV
            // 
            buttonUpload_AJV.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonUpload_AJV.BackgroundImage = (Image)resources.GetObject("buttonUpload_AJV.BackgroundImage");
            buttonUpload_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpload_AJV.Location = new Point(0, 9);
            buttonUpload_AJV.Name = "buttonUpload_AJV";
            buttonUpload_AJV.Size = new Size(112, 70);
            buttonUpload_AJV.TabIndex = 3;
            toolTip_AJV.SetToolTip(buttonUpload_AJV, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonUpload_AJV.UseVisualStyleBackColor = true;
            buttonUpload_AJV.Click += buttonUpload_AJV_Click;
            // 
            // groupBoxTask_AJV
            // 
            groupBoxTask_AJV.Controls.Add(labelTask_AJV);
            groupBoxTask_AJV.Dock = DockStyle.Top;
            groupBoxTask_AJV.Location = new Point(0, 91);
            groupBoxTask_AJV.Name = "groupBoxTask_AJV";
            groupBoxTask_AJV.Size = new Size(1082, 99);
            groupBoxTask_AJV.TabIndex = 4;
            groupBoxTask_AJV.TabStop = false;
            groupBoxTask_AJV.Text = "Условие:";
            // 
            // labelTask_AJV
            // 
            labelTask_AJV.AutoSize = false;
            labelTask_AJV.Dock = DockStyle.Fill;
            labelTask_AJV.Location = new Point(3, 23);
            labelTask_AJV.Name = "labelTask_AJV";
            labelTask_AJV.Size = new Size(1076, 73);
            labelTask_AJV.TabIndex = 0;
            labelTask_AJV.Text = resources.GetString("labelTask_AJV.Text");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 190);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxIn_AJV);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxOutput_AJV);
            splitContainer1.Size = new Size(1082, 519);
            splitContainer1.SplitterDistance = 536;
            splitContainer1.TabIndex = 5;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // groupBoxIn_AJV
            // 
            groupBoxIn_AJV.Controls.Add(dataGridViewIn_AJV);
            groupBoxIn_AJV.Dock = DockStyle.Fill;
            groupBoxIn_AJV.Location = new Point(0, 0);
            groupBoxIn_AJV.Name = "groupBoxIn_AJV";
            groupBoxIn_AJV.Size = new Size(536, 519);
            groupBoxIn_AJV.TabIndex = 10;
            groupBoxIn_AJV.TabStop = false;
            groupBoxIn_AJV.Text = "Ввод:";
            // 
            // dataGridViewIn_AJV
            // 
            dataGridViewIn_AJV.AllowUserToAddRows = false;
            dataGridViewIn_AJV.AllowUserToDeleteRows = false;
            dataGridViewIn_AJV.AllowUserToResizeRows = false;
            dataGridViewIn_AJV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIn_AJV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewIn_AJV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_AJV.Dock = DockStyle.Fill;
            dataGridViewIn_AJV.Location = new Point(3, 23);
            dataGridViewIn_AJV.Name = "dataGridViewIn_AJV";
            dataGridViewIn_AJV.RowHeadersWidth = 51;
            dataGridViewIn_AJV.Size = new Size(530, 493);
            dataGridViewIn_AJV.TabIndex = 0;
            dataGridViewIn_AJV.RowPrePaint += dataGridViewIn_AJV_RowPrePaint;
            // 
            // groupBoxOutput_AJV
            // 
            groupBoxOutput_AJV.Controls.Add(dataGridViewOut_AJV);
            groupBoxOutput_AJV.Dock = DockStyle.Fill;
            groupBoxOutput_AJV.Location = new Point(0, 0);
            groupBoxOutput_AJV.Name = "groupBoxOutput_AJV";
            groupBoxOutput_AJV.Size = new Size(542, 519);
            groupBoxOutput_AJV.TabIndex = 9;
            groupBoxOutput_AJV.TabStop = false;
            groupBoxOutput_AJV.Text = "Вывод:";
            // 
            // dataGridViewOut_AJV
            // 
            dataGridViewOut_AJV.AllowUserToAddRows = false;
            dataGridViewOut_AJV.AllowUserToDeleteRows = false;
            dataGridViewOut_AJV.AllowUserToResizeRows = false;
            dataGridViewOut_AJV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOut_AJV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOut_AJV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_AJV.Dock = DockStyle.Fill;
            dataGridViewOut_AJV.Location = new Point(3, 23);
            dataGridViewOut_AJV.Name = "dataGridViewOut_AJV";
            dataGridViewOut_AJV.RowHeadersWidth = 51;
            dataGridViewOut_AJV.Size = new Size(536, 493);
            dataGridViewOut_AJV.TabIndex = 1;
            dataGridViewOut_AJV.RowPrePaint += dataGridViewOut_AJV_RowPrePaint;
            // 
            // toolTip_AJV
            // 
            toolTip_AJV.IsBalloon = true;
            toolTip_AJV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_AJV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1082, 709);
            Controls.Add(splitContainer1);
            Controls.Add(groupBoxTask_AJV);
            Controls.Add(panelTop_AJV);
            MinimumSize = new Size(1100, 756);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Задание 7 | Вариант 28 | Аймурзина Ю.В";
            Load += FormMain_Load;
            SizeChanged += FormMain_SizeChanged;
            panelTop_AJV.ResumeLayout(false);
            groupBoxTask_AJV.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxIn_AJV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AJV).EndInit();
            groupBoxOutput_AJV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AJV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOK_AJV;
        private Label labelInfo_AJV;
        private PictureBox pictureBoxAvatar_AJV;
    }
}