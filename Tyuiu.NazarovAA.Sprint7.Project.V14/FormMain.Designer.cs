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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonGeneralForm_NAA = new Button();
            buttonHelp_NAA = new Button();
            buttonAuthorInfo_NAA = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGeneralForm_NAA
            // 
            buttonGeneralForm_NAA.Image = (Image)resources.GetObject("buttonGeneralForm_NAA.Image");
            buttonGeneralForm_NAA.Location = new Point(22, 27);
            buttonGeneralForm_NAA.Name = "buttonGeneralForm_NAA";
            buttonGeneralForm_NAA.Size = new Size(107, 55);
            buttonGeneralForm_NAA.TabIndex = 0;
            buttonGeneralForm_NAA.UseVisualStyleBackColor = true;
            buttonGeneralForm_NAA.Click += buttonGeneralForm_NAA_Click;
            // 
            // buttonHelp_NAA
            // 
            buttonHelp_NAA.Image = (Image)resources.GetObject("buttonHelp_NAA.Image");
            buttonHelp_NAA.Location = new Point(22, 135);
            buttonHelp_NAA.Name = "buttonHelp_NAA";
            buttonHelp_NAA.Size = new Size(107, 55);
            buttonHelp_NAA.TabIndex = 0;
            buttonHelp_NAA.UseVisualStyleBackColor = true;
            // 
            // buttonAuthorInfo_NAA
            // 
            buttonAuthorInfo_NAA.Image = (Image)resources.GetObject("buttonAuthorInfo_NAA.Image");
            buttonAuthorInfo_NAA.Location = new Point(22, 244);
            buttonAuthorInfo_NAA.Name = "buttonAuthorInfo_NAA";
            buttonAuthorInfo_NAA.Size = new Size(107, 55);
            buttonAuthorInfo_NAA.TabIndex = 0;
            buttonAuthorInfo_NAA.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(477, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(63, 26);
            label1.Name = "label1";
            label1.Size = new Size(416, 46);
            label1.TabIndex = 2;
            label1.Text = "Управление маршрутами";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(1, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonGeneralForm_NAA);
            splitContainer1.Panel1.Controls.Add(buttonHelp_NAA);
            splitContainer1.Panel1.Controls.Add(buttonAuthorInfo_NAA);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(696, 332);
            splitContainer1.SplitterDistance = 157;
            splitContainer1.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 334);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(713, 381);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGeneralForm_NAA;
        private Button buttonHelp_NAA;
        private Button buttonAuthorInfo_NAA;
        private PictureBox pictureBox1;
        private Label label1;
        private SplitContainer splitContainer1;
    }
}