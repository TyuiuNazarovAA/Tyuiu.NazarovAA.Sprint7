namespace Tyuiu.NazarovAA.Sprint7.Project.V14
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
            buttonGeneralForm_NAA = new Button();
            buttonHelp_NAA = new Button();
            buttonAuthorInfo_NAA = new Button();
            pictureBoxMain_NAA = new PictureBox();
            labelTitle_NAA = new Label();
            toolTipMain = new ToolTip(components);
            panelButtons_NAA = new Panel();
            panelContent_NAA = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain_NAA).BeginInit();
            panelButtons_NAA.SuspendLayout();
            panelContent_NAA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGeneralForm_NAA
            // 
            buttonGeneralForm_NAA.Image = (Image)resources.GetObject("buttonGeneralForm_NAA.Image");
            buttonGeneralForm_NAA.Location = new Point(21, 24);
            buttonGeneralForm_NAA.Name = "buttonGeneralForm_NAA";
            buttonGeneralForm_NAA.Size = new Size(107, 55);
            buttonGeneralForm_NAA.TabIndex = 0;
            toolTipMain.SetToolTip(buttonGeneralForm_NAA, "Запустить программу");
            buttonGeneralForm_NAA.UseVisualStyleBackColor = true;
            buttonGeneralForm_NAA.Click += buttonGeneralForm_NAA_Click;
            // 
            // buttonHelp_NAA
            // 
            buttonHelp_NAA.Image = (Image)resources.GetObject("buttonHelp_NAA.Image");
            buttonHelp_NAA.Location = new Point(21, 122);
            buttonHelp_NAA.Name = "buttonHelp_NAA";
            buttonHelp_NAA.Size = new Size(107, 55);
            buttonHelp_NAA.TabIndex = 0;
            toolTipMain.SetToolTip(buttonHelp_NAA, "Информация о программе");
            buttonHelp_NAA.UseVisualStyleBackColor = true;
            buttonHelp_NAA.Click += buttonHelp_NAA_Click;
            // 
            // buttonAuthorInfo_NAA
            // 
            buttonAuthorInfo_NAA.Image = (Image)resources.GetObject("buttonAuthorInfo_NAA.Image");
            buttonAuthorInfo_NAA.Location = new Point(21, 226);
            buttonAuthorInfo_NAA.Name = "buttonAuthorInfo_NAA";
            buttonAuthorInfo_NAA.Size = new Size(107, 55);
            buttonAuthorInfo_NAA.TabIndex = 0;
            toolTipMain.SetToolTip(buttonAuthorInfo_NAA, "Информация об авторе");
            buttonAuthorInfo_NAA.UseVisualStyleBackColor = true;
            buttonAuthorInfo_NAA.Click += buttonAuthorInfo_NAA_Click;
            // 
            // pictureBoxMain_NAA
            // 
            pictureBoxMain_NAA.Image = (Image)resources.GetObject("pictureBoxMain_NAA.Image");
            pictureBoxMain_NAA.Location = new Point(19, 90);
            pictureBoxMain_NAA.Name = "pictureBoxMain_NAA";
            pictureBoxMain_NAA.Size = new Size(477, 202);
            pictureBoxMain_NAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMain_NAA.TabIndex = 1;
            pictureBoxMain_NAA.TabStop = false;
            // 
            // labelTitle_NAA
            // 
            labelTitle_NAA.AutoSize = true;
            labelTitle_NAA.Font = new Font("Segoe UI", 16F);
            labelTitle_NAA.Location = new Point(19, 27);
            labelTitle_NAA.Name = "labelTitle_NAA";
            labelTitle_NAA.Size = new Size(441, 37);
            labelTitle_NAA.TabIndex = 2;
            labelTitle_NAA.Text = "Система управления маршрутами";
            // 
            // toolTipMain
            // 
            toolTipMain.ToolTipIcon = ToolTipIcon.Info;
            toolTipMain.ToolTipTitle = "Подсказка";
            // 
            // panelButtons_NAA
            // 
            panelButtons_NAA.BackColor = SystemColors.ControlLight;
            panelButtons_NAA.Controls.Add(buttonGeneralForm_NAA);
            panelButtons_NAA.Controls.Add(buttonHelp_NAA);
            panelButtons_NAA.Controls.Add(buttonAuthorInfo_NAA);
            panelButtons_NAA.Location = new Point(12, 12);
            panelButtons_NAA.Name = "panelButtons_NAA";
            panelButtons_NAA.Size = new Size(149, 310);
            panelButtons_NAA.TabIndex = 3;
            // 
            // panelContent_NAA
            // 
            panelContent_NAA.BackColor = SystemColors.ControlLight;
            panelContent_NAA.Controls.Add(labelTitle_NAA);
            panelContent_NAA.Controls.Add(pictureBoxMain_NAA);
            panelContent_NAA.Location = new Point(167, 12);
            panelContent_NAA.Name = "panelContent_NAA";
            panelContent_NAA.Size = new Size(516, 310);
            panelContent_NAA.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 334);
            Controls.Add(panelContent_NAA);
            Controls.Add(panelButtons_NAA);
            MaximumSize = new Size(713, 381);
            MinimumSize = new Size(713, 381);
            Name = "FormMain";
            Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain_NAA).EndInit();
            panelButtons_NAA.ResumeLayout(false);
            panelContent_NAA.ResumeLayout(false);
            panelContent_NAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGeneralForm_NAA;
        private Button buttonHelp_NAA;
        private Button buttonAuthorInfo_NAA;
        private PictureBox pictureBoxMain_NAA;
        private Label labelTitle_NAA;
        private ToolTip toolTipMain;
        private Panel panelButtons_NAA;
        private Panel panelContent_NAA;
    }
}