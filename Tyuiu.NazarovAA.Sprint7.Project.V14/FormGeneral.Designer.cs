namespace Tyuiu.NazarovAA.Sprint7.Project.V14
{
    partial class FormGeneral
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxFromStation_NAA = new TextBox();
            textBoxToStation_NAA = new TextBox();
            panelInputAndOutput_NAA = new Panel();
            splitter4 = new Splitter();
            panelOutput_NAA = new Panel();
            groupBoxDatabase_NAA = new GroupBox();
            labelDatabasePath_NAA = new Label();
            textBoxDatabaseSource_NAA = new TextBox();
            buttonDatabaseFile_NAA = new Button();
            panelInput_NAA = new Panel();
            groupBoxInput_NAA = new GroupBox();
            labelTo_NAA = new Label();
            labelFrom_NAA = new Label();
            groupBoxInputTable_NAA = new GroupBox();
            dataGridViewAllRoutes_NAA = new DataGridView();
            openFileDialogRoutes = new OpenFileDialog();
            splitter1 = new Splitter();
            panelDataGridViewsAndCharts_NAA = new Panel();
            panelCharts_NAA = new Panel();
            groupBoxToChart_NAA = new GroupBox();
            splitter5 = new Splitter();
            groupBoxFromChart_NAA = new GroupBox();
            splitter2 = new Splitter();
            panelDataGridViews_NAA = new Panel();
            groupBoxOutputTable_NAA = new GroupBox();
            dataGridViewFilteredRoutes_NAA = new DataGridView();
            splitter3 = new Splitter();
            chartFromStation_NAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartToStation_NAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelInputAndOutput_NAA.SuspendLayout();
            panelOutput_NAA.SuspendLayout();
            groupBoxDatabase_NAA.SuspendLayout();
            panelInput_NAA.SuspendLayout();
            groupBoxInput_NAA.SuspendLayout();
            groupBoxInputTable_NAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllRoutes_NAA).BeginInit();
            panelDataGridViewsAndCharts_NAA.SuspendLayout();
            panelCharts_NAA.SuspendLayout();
            groupBoxToChart_NAA.SuspendLayout();
            groupBoxFromChart_NAA.SuspendLayout();
            panelDataGridViews_NAA.SuspendLayout();
            groupBoxOutputTable_NAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilteredRoutes_NAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFromStation_NAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartToStation_NAA).BeginInit();
            SuspendLayout();
            // 
            // textBoxFromStation_NAA
            // 
            textBoxFromStation_NAA.Location = new Point(74, 33);
            textBoxFromStation_NAA.Name = "textBoxFromStation_NAA";
            textBoxFromStation_NAA.Size = new Size(125, 27);
            textBoxFromStation_NAA.TabIndex = 0;
            // 
            // textBoxToStation_NAA
            // 
            textBoxToStation_NAA.Location = new Point(74, 66);
            textBoxToStation_NAA.Name = "textBoxToStation_NAA";
            textBoxToStation_NAA.Size = new Size(125, 27);
            textBoxToStation_NAA.TabIndex = 0;
            // 
            // panelInputAndOutput_NAA
            // 
            panelInputAndOutput_NAA.Controls.Add(splitter4);
            panelInputAndOutput_NAA.Controls.Add(panelOutput_NAA);
            panelInputAndOutput_NAA.Controls.Add(panelInput_NAA);
            panelInputAndOutput_NAA.Dock = DockStyle.Top;
            panelInputAndOutput_NAA.Location = new Point(0, 0);
            panelInputAndOutput_NAA.Name = "panelInputAndOutput_NAA";
            panelInputAndOutput_NAA.Padding = new Padding(10);
            panelInputAndOutput_NAA.Size = new Size(1123, 230);
            panelInputAndOutput_NAA.TabIndex = 1;
            // 
            // splitter4
            // 
            splitter4.Location = new Point(517, 10);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(4, 210);
            splitter4.TabIndex = 4;
            splitter4.TabStop = false;
            // 
            // panelOutput_NAA
            // 
            panelOutput_NAA.Controls.Add(groupBoxDatabase_NAA);
            panelOutput_NAA.Dock = DockStyle.Fill;
            panelOutput_NAA.Location = new Point(517, 10);
            panelOutput_NAA.Name = "panelOutput_NAA";
            panelOutput_NAA.Padding = new Padding(10);
            panelOutput_NAA.Size = new Size(596, 210);
            panelOutput_NAA.TabIndex = 3;
            // 
            // groupBoxDatabase_NAA
            // 
            groupBoxDatabase_NAA.Controls.Add(labelDatabasePath_NAA);
            groupBoxDatabase_NAA.Controls.Add(textBoxDatabaseSource_NAA);
            groupBoxDatabase_NAA.Controls.Add(buttonDatabaseFile_NAA);
            groupBoxDatabase_NAA.Dock = DockStyle.Fill;
            groupBoxDatabase_NAA.Location = new Point(10, 10);
            groupBoxDatabase_NAA.Name = "groupBoxDatabase_NAA";
            groupBoxDatabase_NAA.Size = new Size(576, 190);
            groupBoxDatabase_NAA.TabIndex = 2;
            groupBoxDatabase_NAA.TabStop = false;
            groupBoxDatabase_NAA.Text = "База данных";
            // 
            // labelDatabasePath_NAA
            // 
            labelDatabasePath_NAA.AutoSize = true;
            labelDatabasePath_NAA.Location = new Point(142, 26);
            labelDatabasePath_NAA.Name = "labelDatabasePath_NAA";
            labelDatabasePath_NAA.Size = new Size(144, 20);
            labelDatabasePath_NAA.TabIndex = 2;
            labelDatabasePath_NAA.Text = "Путь к базе данных";
            // 
            // textBoxDatabaseSource_NAA
            // 
            textBoxDatabaseSource_NAA.Location = new Point(140, 54);
            textBoxDatabaseSource_NAA.Multiline = true;
            textBoxDatabaseSource_NAA.Name = "textBoxDatabaseSource_NAA";
            textBoxDatabaseSource_NAA.ReadOnly = true;
            textBoxDatabaseSource_NAA.Size = new Size(388, 54);
            textBoxDatabaseSource_NAA.TabIndex = 1;
            textBoxDatabaseSource_NAA.Text = "Не выбран";
            // 
            // buttonDatabaseFile_NAA
            // 
            buttonDatabaseFile_NAA.Location = new Point(23, 43);
            buttonDatabaseFile_NAA.Name = "buttonDatabaseFile_NAA";
            buttonDatabaseFile_NAA.Size = new Size(94, 29);
            buttonDatabaseFile_NAA.TabIndex = 0;
            buttonDatabaseFile_NAA.Text = "button1";
            buttonDatabaseFile_NAA.UseVisualStyleBackColor = true;
            buttonDatabaseFile_NAA.Click += buttonDatabaseFile_NAA_Click;
            // 
            // panelInput_NAA
            // 
            panelInput_NAA.Controls.Add(groupBoxInput_NAA);
            panelInput_NAA.Dock = DockStyle.Left;
            panelInput_NAA.Location = new Point(10, 10);
            panelInput_NAA.Name = "panelInput_NAA";
            panelInput_NAA.Padding = new Padding(10);
            panelInput_NAA.Size = new Size(507, 210);
            panelInput_NAA.TabIndex = 3;
            // 
            // groupBoxInput_NAA
            // 
            groupBoxInput_NAA.Controls.Add(labelTo_NAA);
            groupBoxInput_NAA.Controls.Add(labelFrom_NAA);
            groupBoxInput_NAA.Controls.Add(textBoxFromStation_NAA);
            groupBoxInput_NAA.Controls.Add(textBoxToStation_NAA);
            groupBoxInput_NAA.Dock = DockStyle.Fill;
            groupBoxInput_NAA.Location = new Point(10, 10);
            groupBoxInput_NAA.Name = "groupBoxInput_NAA";
            groupBoxInput_NAA.Size = new Size(487, 190);
            groupBoxInput_NAA.TabIndex = 1;
            groupBoxInput_NAA.TabStop = false;
            groupBoxInput_NAA.Text = "Входные данные";
            // 
            // labelTo_NAA
            // 
            labelTo_NAA.AutoSize = true;
            labelTo_NAA.Location = new Point(27, 69);
            labelTo_NAA.Name = "labelTo_NAA";
            labelTo_NAA.Size = new Size(41, 20);
            labelTo_NAA.TabIndex = 1;
            labelTo_NAA.Text = "Куда";
            // 
            // labelFrom_NAA
            // 
            labelFrom_NAA.AutoSize = true;
            labelFrom_NAA.Location = new Point(12, 36);
            labelFrom_NAA.Name = "labelFrom_NAA";
            labelFrom_NAA.Size = new Size(56, 20);
            labelFrom_NAA.TabIndex = 1;
            labelFrom_NAA.Text = "Откуда";
            // 
            // groupBoxInputTable_NAA
            // 
            groupBoxInputTable_NAA.Controls.Add(dataGridViewAllRoutes_NAA);
            groupBoxInputTable_NAA.Dock = DockStyle.Top;
            groupBoxInputTable_NAA.Location = new Point(10, 10);
            groupBoxInputTable_NAA.Name = "groupBoxInputTable_NAA";
            groupBoxInputTable_NAA.Size = new Size(497, 231);
            groupBoxInputTable_NAA.TabIndex = 0;
            groupBoxInputTable_NAA.TabStop = false;
            groupBoxInputTable_NAA.Text = "Все маршруты";
            // 
            // dataGridViewAllRoutes_NAA
            // 
            dataGridViewAllRoutes_NAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllRoutes_NAA.Dock = DockStyle.Fill;
            dataGridViewAllRoutes_NAA.Location = new Point(3, 23);
            dataGridViewAllRoutes_NAA.Name = "dataGridViewAllRoutes_NAA";
            dataGridViewAllRoutes_NAA.RowHeadersWidth = 51;
            dataGridViewAllRoutes_NAA.Size = new Size(491, 205);
            dataGridViewAllRoutes_NAA.TabIndex = 0;
            // 
            // openFileDialogRoutes
            // 
            openFileDialogRoutes.FileName = "openFileDialog1";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 230);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1123, 4);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // panelDataGridViewsAndCharts_NAA
            // 
            panelDataGridViewsAndCharts_NAA.Controls.Add(panelCharts_NAA);
            panelDataGridViewsAndCharts_NAA.Controls.Add(splitter2);
            panelDataGridViewsAndCharts_NAA.Controls.Add(panelDataGridViews_NAA);
            panelDataGridViewsAndCharts_NAA.Dock = DockStyle.Fill;
            panelDataGridViewsAndCharts_NAA.Location = new Point(0, 234);
            panelDataGridViewsAndCharts_NAA.Name = "panelDataGridViewsAndCharts_NAA";
            panelDataGridViewsAndCharts_NAA.Size = new Size(1123, 536);
            panelDataGridViewsAndCharts_NAA.TabIndex = 9;
            // 
            // panelCharts_NAA
            // 
            panelCharts_NAA.Controls.Add(groupBoxToChart_NAA);
            panelCharts_NAA.Controls.Add(splitter5);
            panelCharts_NAA.Controls.Add(groupBoxFromChart_NAA);
            panelCharts_NAA.Dock = DockStyle.Fill;
            panelCharts_NAA.Location = new Point(521, 0);
            panelCharts_NAA.Name = "panelCharts_NAA";
            panelCharts_NAA.Padding = new Padding(10);
            panelCharts_NAA.Size = new Size(602, 536);
            panelCharts_NAA.TabIndex = 2;
            // 
            // groupBoxToChart_NAA
            // 
            groupBoxToChart_NAA.Controls.Add(chartToStation_NAA);
            groupBoxToChart_NAA.Dock = DockStyle.Fill;
            groupBoxToChart_NAA.Location = new Point(10, 245);
            groupBoxToChart_NAA.Name = "groupBoxToChart_NAA";
            groupBoxToChart_NAA.Size = new Size(582, 281);
            groupBoxToChart_NAA.TabIndex = 2;
            groupBoxToChart_NAA.TabStop = false;
            groupBoxToChart_NAA.Text = "Маршруты до остановки";
            // 
            // splitter5
            // 
            splitter5.Dock = DockStyle.Top;
            splitter5.Location = new Point(10, 241);
            splitter5.Name = "splitter5";
            splitter5.Size = new Size(582, 4);
            splitter5.TabIndex = 1;
            splitter5.TabStop = false;
            // 
            // groupBoxFromChart_NAA
            // 
            groupBoxFromChart_NAA.Controls.Add(chartFromStation_NAA);
            groupBoxFromChart_NAA.Dock = DockStyle.Top;
            groupBoxFromChart_NAA.Location = new Point(10, 10);
            groupBoxFromChart_NAA.Name = "groupBoxFromChart_NAA";
            groupBoxFromChart_NAA.Size = new Size(582, 231);
            groupBoxFromChart_NAA.TabIndex = 0;
            groupBoxFromChart_NAA.TabStop = false;
            groupBoxFromChart_NAA.Text = "Маршруты от остановки";
            // 
            // splitter2
            // 
            splitter2.Location = new Point(517, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 536);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            // 
            // panelDataGridViews_NAA
            // 
            panelDataGridViews_NAA.Controls.Add(groupBoxOutputTable_NAA);
            panelDataGridViews_NAA.Controls.Add(splitter3);
            panelDataGridViews_NAA.Controls.Add(groupBoxInputTable_NAA);
            panelDataGridViews_NAA.Dock = DockStyle.Left;
            panelDataGridViews_NAA.Location = new Point(0, 0);
            panelDataGridViews_NAA.Name = "panelDataGridViews_NAA";
            panelDataGridViews_NAA.Padding = new Padding(10);
            panelDataGridViews_NAA.Size = new Size(517, 536);
            panelDataGridViews_NAA.TabIndex = 0;
            // 
            // groupBoxOutputTable_NAA
            // 
            groupBoxOutputTable_NAA.Controls.Add(dataGridViewFilteredRoutes_NAA);
            groupBoxOutputTable_NAA.Dock = DockStyle.Fill;
            groupBoxOutputTable_NAA.Location = new Point(10, 245);
            groupBoxOutputTable_NAA.Name = "groupBoxOutputTable_NAA";
            groupBoxOutputTable_NAA.Size = new Size(497, 281);
            groupBoxOutputTable_NAA.TabIndex = 3;
            groupBoxOutputTable_NAA.TabStop = false;
            groupBoxOutputTable_NAA.Text = "Подходящие маршруты";
            // 
            // dataGridViewFilteredRoutes_NAA
            // 
            dataGridViewFilteredRoutes_NAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilteredRoutes_NAA.Dock = DockStyle.Fill;
            dataGridViewFilteredRoutes_NAA.Location = new Point(3, 23);
            dataGridViewFilteredRoutes_NAA.Name = "dataGridViewFilteredRoutes_NAA";
            dataGridViewFilteredRoutes_NAA.RowHeadersWidth = 51;
            dataGridViewFilteredRoutes_NAA.Size = new Size(491, 255);
            dataGridViewFilteredRoutes_NAA.TabIndex = 0;
            // 
            // splitter3
            // 
            splitter3.Dock = DockStyle.Top;
            splitter3.Location = new Point(10, 241);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(497, 4);
            splitter3.TabIndex = 2;
            splitter3.TabStop = false;
            // 
            // chartFromStation_NAA
            // 
            chartArea3.Name = "ChartArea1";
            chartFromStation_NAA.ChartAreas.Add(chartArea3);
            chartFromStation_NAA.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartFromStation_NAA.Legends.Add(legend3);
            chartFromStation_NAA.Location = new Point(3, 23);
            chartFromStation_NAA.Name = "chartFromStation_NAA";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            chartFromStation_NAA.Series.Add(series3);
            chartFromStation_NAA.Size = new Size(576, 205);
            chartFromStation_NAA.TabIndex = 0;
            chartFromStation_NAA.Text = "chart1";
            // 
            // chartToStation_NAA
            // 
            chartArea4.Name = "ChartArea1";
            chartToStation_NAA.ChartAreas.Add(chartArea4);
            chartToStation_NAA.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            chartToStation_NAA.Legends.Add(legend4);
            chartToStation_NAA.Location = new Point(3, 23);
            chartToStation_NAA.Name = "chartToStation_NAA";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartToStation_NAA.Series.Add(series4);
            chartToStation_NAA.Size = new Size(576, 255);
            chartToStation_NAA.TabIndex = 0;
            chartToStation_NAA.Text = "chart2";
            // 
            // FormGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 770);
            Controls.Add(panelDataGridViewsAndCharts_NAA);
            Controls.Add(splitter1);
            Controls.Add(panelInputAndOutput_NAA);
            Name = "FormGeneral";
            Text = "FormGeneral";
            panelInputAndOutput_NAA.ResumeLayout(false);
            panelOutput_NAA.ResumeLayout(false);
            groupBoxDatabase_NAA.ResumeLayout(false);
            groupBoxDatabase_NAA.PerformLayout();
            panelInput_NAA.ResumeLayout(false);
            groupBoxInput_NAA.ResumeLayout(false);
            groupBoxInput_NAA.PerformLayout();
            groupBoxInputTable_NAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllRoutes_NAA).EndInit();
            panelDataGridViewsAndCharts_NAA.ResumeLayout(false);
            panelCharts_NAA.ResumeLayout(false);
            groupBoxToChart_NAA.ResumeLayout(false);
            groupBoxFromChart_NAA.ResumeLayout(false);
            panelDataGridViews_NAA.ResumeLayout(false);
            groupBoxOutputTable_NAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilteredRoutes_NAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFromStation_NAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartToStation_NAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxFromStation_NAA;
        private TextBox textBoxToStation_NAA;
        private Panel panelInputAndOutput_NAA;
        private GroupBox groupBoxInput_NAA;
        private GroupBox groupBoxDatabase_NAA;
        private Label labelFrom_NAA;
        private Label labelTo_NAA;
        private Button buttonDatabaseFile_NAA;
        private OpenFileDialog openFileDialogRoutes;
        private TextBox textBoxDatabaseSource_NAA;
        private Label labelDatabasePath_NAA;
        private GroupBox groupBoxInputTable_NAA;
        private Panel panelInput_NAA;
        private Splitter splitter1;
        private Panel panelOutput_NAA;
        private Splitter splitter4;
        private Panel panelDataGridViewsAndCharts_NAA;
        private Panel panelCharts_NAA;
        private Splitter splitter2;
        private Panel panelDataGridViews_NAA;
        private GroupBox groupBoxFromChart_NAA;
        private GroupBox groupBoxToChart_NAA;
        private Splitter splitter5;
        private GroupBox groupBoxOutputTable_NAA;
        private Splitter splitter3;
        private DataGridView dataGridViewAllRoutes_NAA;
        private DataGridView dataGridViewFilteredRoutes_NAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartToStation_NAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFromStation_NAA;
    }
}