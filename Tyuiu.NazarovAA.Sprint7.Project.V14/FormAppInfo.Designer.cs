namespace Tyuiu.NazarovAA.Sprint7.Project.V14
{
    partial class FormAppInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppInfo));
            panelGuide1_NAA = new Panel();
            pictureBox1 = new PictureBox();
            labelTitle1_NAA = new Label();
            labelTitle_NAA = new Label();
            panelGuide2_NAA = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            labelTitle2_NAA = new Label();
            buttonNextPage_NAA = new Button();
            buttonClose_NAA = new Button();
            toolTipGuide = new ToolTip(components);
            panelGuide1_NAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGuide2_NAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelGuide1_NAA
            // 
            panelGuide1_NAA.BackColor = SystemColors.ControlLight;
            panelGuide1_NAA.Controls.Add(pictureBox1);
            panelGuide1_NAA.Controls.Add(labelTitle1_NAA);
            panelGuide1_NAA.Location = new Point(12, 72);
            panelGuide1_NAA.Name = "panelGuide1_NAA";
            panelGuide1_NAA.Size = new Size(539, 511);
            panelGuide1_NAA.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTitle1_NAA
            // 
            labelTitle1_NAA.AutoSize = true;
            labelTitle1_NAA.Font = new Font("Segoe UI", 11F);
            labelTitle1_NAA.Location = new Point(26, 18);
            labelTitle1_NAA.Name = "labelTitle1_NAA";
            labelTitle1_NAA.Size = new Size(233, 25);
            labelTitle1_NAA.TabIndex = 0;
            labelTitle1_NAA.Text = "1. Выбираем базу данных";
            // 
            // labelTitle_NAA
            // 
            labelTitle_NAA.AutoSize = true;
            labelTitle_NAA.Font = new Font("Segoe UI", 16F);
            labelTitle_NAA.Location = new Point(12, 18);
            labelTitle_NAA.Name = "labelTitle_NAA";
            labelTitle_NAA.Size = new Size(241, 37);
            labelTitle_NAA.TabIndex = 0;
            labelTitle_NAA.Text = "Поиск маршрутов";
            // 
            // panelGuide2_NAA
            // 
            panelGuide2_NAA.BackColor = SystemColors.ControlLight;
            panelGuide2_NAA.Controls.Add(pictureBox4);
            panelGuide2_NAA.Controls.Add(pictureBox2);
            panelGuide2_NAA.Controls.Add(label1);
            panelGuide2_NAA.Controls.Add(labelTitle2_NAA);
            panelGuide2_NAA.Location = new Point(571, 72);
            panelGuide2_NAA.Name = "panelGuide2_NAA";
            panelGuide2_NAA.Size = new Size(563, 511);
            panelGuide2_NAA.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 203);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(547, 283);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(424, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(26, 163);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 0;
            label1.Text = "3. Сохраняем данные";
            // 
            // labelTitle2_NAA
            // 
            labelTitle2_NAA.AutoSize = true;
            labelTitle2_NAA.Font = new Font("Segoe UI", 11F);
            labelTitle2_NAA.Location = new Point(26, 18);
            labelTitle2_NAA.Name = "labelTitle2_NAA";
            labelTitle2_NAA.Size = new Size(197, 25);
            labelTitle2_NAA.TabIndex = 0;
            labelTitle2_NAA.Text = "2. Фильтруем данные";
            // 
            // buttonNextPage_NAA
            // 
            buttonNextPage_NAA.Location = new Point(937, 606);
            buttonNextPage_NAA.Name = "buttonNextPage_NAA";
            buttonNextPage_NAA.Size = new Size(94, 29);
            buttonNextPage_NAA.TabIndex = 1;
            buttonNextPage_NAA.Text = "Вперед";
            toolTipGuide.SetToolTip(buttonNextPage_NAA, "Следующая страница");
            buttonNextPage_NAA.UseVisualStyleBackColor = true;
            buttonNextPage_NAA.Click += buttonNextPage_NAA_Click;
            // 
            // buttonClose_NAA
            // 
            buttonClose_NAA.Location = new Point(1037, 606);
            buttonClose_NAA.Name = "buttonClose_NAA";
            buttonClose_NAA.Size = new Size(94, 29);
            buttonClose_NAA.TabIndex = 1;
            buttonClose_NAA.Text = "Ок";
            toolTipGuide.SetToolTip(buttonClose_NAA, "На главную");
            buttonClose_NAA.UseVisualStyleBackColor = true;
            buttonClose_NAA.Click += buttonClose_NAA_Click;
            // 
            // toolTipGuide
            // 
            toolTipGuide.ToolTipIcon = ToolTipIcon.Info;
            toolTipGuide.ToolTipTitle = "Подсказка";
            // 
            // FormAppInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 647);
            Controls.Add(buttonClose_NAA);
            Controls.Add(buttonNextPage_NAA);
            Controls.Add(panelGuide2_NAA);
            Controls.Add(panelGuide1_NAA);
            Controls.Add(labelTitle_NAA);
            MaximumSize = new Size(1170, 694);
            MinimumSize = new Size(1170, 694);
            Name = "FormAppInfo";
            Text = "Инструкция по использованию";
            panelGuide1_NAA.ResumeLayout(false);
            panelGuide1_NAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGuide2_NAA.ResumeLayout(false);
            panelGuide2_NAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGuide1_NAA;
        private PictureBox pictureBox1;
        private Label labelTitle1_NAA;
        private Label labelTitle_NAA;
        private Panel panelGuide2_NAA;
        private PictureBox pictureBox2;
        private Label labelTitle2_NAA;
        private Button buttonNextPage_NAA;
        private Button buttonClose_NAA;
        private ToolTip toolTipGuide;
        private PictureBox pictureBox4;
        private Label label1;
    }
}