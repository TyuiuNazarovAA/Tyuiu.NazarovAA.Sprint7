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
            SuspendLayout();
            // 
            // buttonGeneralForm_NAA
            // 
            buttonGeneralForm_NAA.Image = (Image)resources.GetObject("buttonGeneralForm_NAA.Image");
            buttonGeneralForm_NAA.Location = new Point(317, 55);
            buttonGeneralForm_NAA.Name = "buttonGeneralForm_NAA";
            buttonGeneralForm_NAA.Size = new Size(107, 55);
            buttonGeneralForm_NAA.TabIndex = 0;
            buttonGeneralForm_NAA.UseVisualStyleBackColor = true;
            buttonGeneralForm_NAA.Click += buttonGeneralForm_NAA_Click;
            // 
            // buttonHelp_NAA
            // 
            buttonHelp_NAA.Image = (Image)resources.GetObject("buttonHelp_NAA.Image");
            buttonHelp_NAA.Location = new Point(317, 155);
            buttonHelp_NAA.Name = "buttonHelp_NAA";
            buttonHelp_NAA.Size = new Size(107, 55);
            buttonHelp_NAA.TabIndex = 0;
            buttonHelp_NAA.UseVisualStyleBackColor = true;
            // 
            // buttonAuthorInfo_NAA
            // 
            buttonAuthorInfo_NAA.Image = (Image)resources.GetObject("buttonAuthorInfo_NAA.Image");
            buttonAuthorInfo_NAA.Location = new Point(317, 252);
            buttonAuthorInfo_NAA.Name = "buttonAuthorInfo_NAA";
            buttonAuthorInfo_NAA.Size = new Size(107, 55);
            buttonAuthorInfo_NAA.TabIndex = 0;
            buttonAuthorInfo_NAA.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAuthorInfo_NAA);
            Controls.Add(buttonHelp_NAA);
            Controls.Add(buttonGeneralForm_NAA);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGeneralForm_NAA;
        private Button buttonHelp_NAA;
        private Button buttonAuthorInfo_NAA;
    }
}