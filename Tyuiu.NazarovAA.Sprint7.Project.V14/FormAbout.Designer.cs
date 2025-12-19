namespace Tyuiu.NazarovAA.Sprint7.Project.V14
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
            textBoxAuthor_NAA = new TextBox();
            buttonClose_NAA = new Button();
            toolTipAbout = new ToolTip(components);
            SuspendLayout();
            // 
            // textBoxAuthor_NAA
            // 
            textBoxAuthor_NAA.Enabled = false;
            textBoxAuthor_NAA.Location = new Point(12, 12);
            textBoxAuthor_NAA.Multiline = true;
            textBoxAuthor_NAA.Name = "textBoxAuthor_NAA";
            textBoxAuthor_NAA.ReadOnly = true;
            textBoxAuthor_NAA.Size = new Size(385, 96);
            textBoxAuthor_NAA.TabIndex = 0;
            textBoxAuthor_NAA.Text = "Разработчик: Назаров Артём Александрович\r\nГруппа: РППб 25-1\r\nПрограмма разработана в рамках C# курса\r\nТюменский индустриальный университет";
            // 
            // buttonClose_NAA
            // 
            buttonClose_NAA.Location = new Point(297, 123);
            buttonClose_NAA.Name = "buttonClose_NAA";
            buttonClose_NAA.Size = new Size(94, 29);
            buttonClose_NAA.TabIndex = 1;
            buttonClose_NAA.Text = "Ок";
            toolTipAbout.SetToolTip(buttonClose_NAA, "На главную");
            buttonClose_NAA.UseVisualStyleBackColor = true;
            buttonClose_NAA.Click += buttonClose_NAA_Click;
            // 
            // toolTipAbout
            // 
            toolTipAbout.ToolTipIcon = ToolTipIcon.Info;
            toolTipAbout.ToolTipTitle = "Подсказка";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 165);
            Controls.Add(buttonClose_NAA);
            Controls.Add(textBoxAuthor_NAA);
            MaximumSize = new Size(433, 212);
            MinimumSize = new Size(433, 212);
            Name = "FormAbout";
            Text = "Об авторе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAuthor_NAA;
        private Button buttonClose_NAA;
        private ToolTip toolTipAbout;
    }
}