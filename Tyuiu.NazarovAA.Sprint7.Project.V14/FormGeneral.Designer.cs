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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneral));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            labelFiltration_NAA = new Label();
            comboBoxSort_NAA = new ComboBox();
            buttonSearch_NAA = new Button();
            labelTo_NAA = new Label();
            labelFrom_NAA = new Label();
            groupBoxInputTable_NAA = new GroupBox();
            dataGridViewAllRoutes_NAA = new DataGridView();
            openFileDialogRoutes = new OpenFileDialog();
            splitter1 = new Splitter();
            panelDataGridViewsAndCharts_NAA = new Panel();
            panelCharts_NAA = new Panel();
            groupBoxToChart_NAA = new GroupBox();
            chartToStation_NAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter5 = new Splitter();
            groupBoxFromChart_NAA = new GroupBox();
            chartFromStation_NAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter2 = new Splitter();
            panelDataGridViews_NAA = new Panel();
            groupBoxOutputTable_NAA = new GroupBox();
            dataGridViewFilteredRoutes_NAA = new DataGridView();
            splitter3 = new Splitter();
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
            ((System.ComponentModel.ISupportInitialize)chartToStation_NAA).BeginInit();
            groupBoxFromChart_NAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFromStation_NAA).BeginInit();
            panelDataGridViews_NAA.SuspendLayout();
            groupBoxOutputTable_NAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilteredRoutes_NAA).BeginInit();
            SuspendLayout();
            // 
            // textBoxFromStation_NAA
            // 
            textBoxFromStation_NAA.Location = new Point(74, 33);
            textBoxFromStation_NAA.Name = "textBoxFromStation_NAA";
            textBoxFromStation_NAA.Size = new Size(229, 27);
            textBoxFromStation_NAA.TabIndex = 0;
            // 
            // textBoxToStation_NAA
            // 
            textBoxToStation_NAA.Location = new Point(74, 66);
            textBoxToStation_NAA.Name = "textBoxToStation_NAA";
            textBoxToStation_NAA.Size = new Size(229, 27);
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
            panelInputAndOutput_NAA.Size = new Size(1123, 166);
            panelInputAndOutput_NAA.TabIndex = 1;
            // 
            // splitter4
            // 
            splitter4.Location = new Point(604, 10);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(4, 146);
            splitter4.TabIndex = 4;
            splitter4.TabStop = false;
            // 
            // panelOutput_NAA
            // 
            panelOutput_NAA.Controls.Add(groupBoxDatabase_NAA);
            panelOutput_NAA.Dock = DockStyle.Fill;
            panelOutput_NAA.Location = new Point(604, 10);
            panelOutput_NAA.Name = "panelOutput_NAA";
            panelOutput_NAA.Padding = new Padding(10);
            panelOutput_NAA.Size = new Size(509, 146);
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
            groupBoxDatabase_NAA.Size = new Size(489, 126);
            groupBoxDatabase_NAA.TabIndex = 2;
            groupBoxDatabase_NAA.TabStop = false;
            groupBoxDatabase_NAA.Text = "База данных";
            // 
            // labelDatabasePath_NAA
            // 
            labelDatabasePath_NAA.AutoSize = true;
            labelDatabasePath_NAA.Location = new Point(92, 33);
            labelDatabasePath_NAA.Name = "labelDatabasePath_NAA";
            labelDatabasePath_NAA.Size = new Size(144, 20);
            labelDatabasePath_NAA.TabIndex = 2;
            labelDatabasePath_NAA.Text = "Путь к базе данных";
            // 
            // textBoxDatabaseSource_NAA
            // 
            textBoxDatabaseSource_NAA.Location = new Point(90, 61);
            textBoxDatabaseSource_NAA.Multiline = true;
            textBoxDatabaseSource_NAA.Name = "textBoxDatabaseSource_NAA";
            textBoxDatabaseSource_NAA.ReadOnly = true;
            textBoxDatabaseSource_NAA.Size = new Size(388, 54);
            textBoxDatabaseSource_NAA.TabIndex = 1;
            textBoxDatabaseSource_NAA.Text = "Не выбран";
            // 
            // buttonDatabaseFile_NAA
            // 
            buttonDatabaseFile_NAA.Image = (Image)resources.GetObject("buttonDatabaseFile_NAA.Image");
            buttonDatabaseFile_NAA.Location = new Point(17, 54);
            buttonDatabaseFile_NAA.Name = "buttonDatabaseFile_NAA";
            buttonDatabaseFile_NAA.Size = new Size(67, 61);
            buttonDatabaseFile_NAA.TabIndex = 0;
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
            panelInput_NAA.Size = new Size(594, 146);
            panelInput_NAA.TabIndex = 3;
            // 
            // groupBoxInput_NAA
            // 
            groupBoxInput_NAA.Controls.Add(labelFiltration_NAA);
            groupBoxInput_NAA.Controls.Add(comboBoxSort_NAA);
            groupBoxInput_NAA.Controls.Add(buttonSearch_NAA);
            groupBoxInput_NAA.Controls.Add(labelTo_NAA);
            groupBoxInput_NAA.Controls.Add(labelFrom_NAA);
            groupBoxInput_NAA.Controls.Add(textBoxFromStation_NAA);
            groupBoxInput_NAA.Controls.Add(textBoxToStation_NAA);
            groupBoxInput_NAA.Dock = DockStyle.Fill;
            groupBoxInput_NAA.Location = new Point(10, 10);
            groupBoxInput_NAA.Name = "groupBoxInput_NAA";
            groupBoxInput_NAA.Size = new Size(574, 126);
            groupBoxInput_NAA.TabIndex = 1;
            groupBoxInput_NAA.TabStop = false;
            groupBoxInput_NAA.Text = "Входные данные";
            // 
            // labelFiltration_NAA
            // 
            labelFiltration_NAA.AutoSize = true;
            labelFiltration_NAA.Location = new Point(328, 33);
            labelFiltration_NAA.Name = "labelFiltration_NAA";
            labelFiltration_NAA.Size = new Size(94, 20);
            labelFiltration_NAA.TabIndex = 4;
            labelFiltration_NAA.Text = "Фильтрация";
            // 
            // comboBoxSort_NAA
            // 
            comboBoxSort_NAA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort_NAA.FormattingEnabled = true;
            comboBoxSort_NAA.ImeMode = ImeMode.NoControl;
            comboBoxSort_NAA.Items.AddRange(new object[] { "Нет", "Быстрее", "Медленнее" });
            comboBoxSort_NAA.Location = new Point(328, 64);
            comboBoxSort_NAA.Name = "comboBoxSort_NAA";
            comboBoxSort_NAA.Size = new Size(151, 28);
            comboBoxSort_NAA.TabIndex = 3;
            // 
            // buttonSearch_NAA
            // 
            buttonSearch_NAA.Image = (Image)resources.GetObject("buttonSearch_NAA.Image");
            buttonSearch_NAA.Location = new Point(510, 33);
            buttonSearch_NAA.Name = "buttonSearch_NAA";
            buttonSearch_NAA.Size = new Size(45, 42);
            buttonSearch_NAA.TabIndex = 2;
            buttonSearch_NAA.UseVisualStyleBackColor = true;
            buttonSearch_NAA.Click += buttonSearch_NAA_Click;
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
            groupBoxInputTable_NAA.Size = new Size(551, 231);
            groupBoxInputTable_NAA.TabIndex = 0;
            groupBoxInputTable_NAA.TabStop = false;
            groupBoxInputTable_NAA.Text = "Все маршруты";
            // 
            // dataGridViewAllRoutes_NAA
            // 
            dataGridViewAllRoutes_NAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllRoutes_NAA.ColumnHeadersVisible = false;
            dataGridViewAllRoutes_NAA.Dock = DockStyle.Fill;
            dataGridViewAllRoutes_NAA.Location = new Point(3, 23);
            dataGridViewAllRoutes_NAA.Name = "dataGridViewAllRoutes_NAA";
            dataGridViewAllRoutes_NAA.RowHeadersVisible = false;
            dataGridViewAllRoutes_NAA.RowHeadersWidth = 51;
            dataGridViewAllRoutes_NAA.Size = new Size(545, 205);
            dataGridViewAllRoutes_NAA.TabIndex = 0;
            // 
            // openFileDialogRoutes
            // 
            openFileDialogRoutes.FileName = "None";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 166);
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
            panelDataGridViewsAndCharts_NAA.Location = new Point(0, 170);
            panelDataGridViewsAndCharts_NAA.Name = "panelDataGridViewsAndCharts_NAA";
            panelDataGridViewsAndCharts_NAA.Size = new Size(1123, 600);
            panelDataGridViewsAndCharts_NAA.TabIndex = 9;
            // 
            // panelCharts_NAA
            // 
            panelCharts_NAA.Controls.Add(groupBoxToChart_NAA);
            panelCharts_NAA.Controls.Add(splitter5);
            panelCharts_NAA.Controls.Add(groupBoxFromChart_NAA);
            panelCharts_NAA.Dock = DockStyle.Fill;
            panelCharts_NAA.Location = new Point(575, 0);
            panelCharts_NAA.Name = "panelCharts_NAA";
            panelCharts_NAA.Padding = new Padding(10);
            panelCharts_NAA.Size = new Size(548, 600);
            panelCharts_NAA.TabIndex = 2;
            // 
            // groupBoxToChart_NAA
            // 
            groupBoxToChart_NAA.Controls.Add(chartToStation_NAA);
            groupBoxToChart_NAA.Dock = DockStyle.Fill;
            groupBoxToChart_NAA.Location = new Point(10, 245);
            groupBoxToChart_NAA.Name = "groupBoxToChart_NAA";
            groupBoxToChart_NAA.Size = new Size(528, 345);
            groupBoxToChart_NAA.TabIndex = 2;
            groupBoxToChart_NAA.TabStop = false;
            groupBoxToChart_NAA.Text = "Маршруты до остановки";
            // 
            // chartToStation_NAA
            // 
            chartArea1.Name = "ChartArea1";
            chartToStation_NAA.ChartAreas.Add(chartArea1);
            chartToStation_NAA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartToStation_NAA.Legends.Add(legend1);
            chartToStation_NAA.Location = new Point(3, 23);
            chartToStation_NAA.Name = "chartToStation_NAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartToStation_NAA.Series.Add(series1);
            chartToStation_NAA.Size = new Size(522, 319);
            chartToStation_NAA.TabIndex = 0;
            chartToStation_NAA.Text = "chart2";
            // 
            // splitter5
            // 
            splitter5.Dock = DockStyle.Top;
            splitter5.Location = new Point(10, 241);
            splitter5.Name = "splitter5";
            splitter5.Size = new Size(528, 4);
            splitter5.TabIndex = 1;
            splitter5.TabStop = false;
            // 
            // groupBoxFromChart_NAA
            // 
            groupBoxFromChart_NAA.Controls.Add(chartFromStation_NAA);
            groupBoxFromChart_NAA.Dock = DockStyle.Top;
            groupBoxFromChart_NAA.Location = new Point(10, 10);
            groupBoxFromChart_NAA.Name = "groupBoxFromChart_NAA";
            groupBoxFromChart_NAA.Size = new Size(528, 231);
            groupBoxFromChart_NAA.TabIndex = 0;
            groupBoxFromChart_NAA.TabStop = false;
            groupBoxFromChart_NAA.Text = "Маршруты от остановки";
            // 
            // chartFromStation_NAA
            // 
            chartArea2.Name = "ChartArea1";
            chartFromStation_NAA.ChartAreas.Add(chartArea2);
            chartFromStation_NAA.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFromStation_NAA.Legends.Add(legend2);
            chartFromStation_NAA.Location = new Point(3, 23);
            chartFromStation_NAA.Name = "chartFromStation_NAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValuesPerPoint = 2;
            chartFromStation_NAA.Series.Add(series2);
            chartFromStation_NAA.Size = new Size(522, 205);
            chartFromStation_NAA.TabIndex = 0;
            chartFromStation_NAA.Text = "chart1";
            // 
            // splitter2
            // 
            splitter2.Location = new Point(571, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 600);
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
            panelDataGridViews_NAA.Size = new Size(571, 600);
            panelDataGridViews_NAA.TabIndex = 0;
            // 
            // groupBoxOutputTable_NAA
            // 
            groupBoxOutputTable_NAA.Controls.Add(dataGridViewFilteredRoutes_NAA);
            groupBoxOutputTable_NAA.Dock = DockStyle.Fill;
            groupBoxOutputTable_NAA.Location = new Point(10, 245);
            groupBoxOutputTable_NAA.Name = "groupBoxOutputTable_NAA";
            groupBoxOutputTable_NAA.Size = new Size(551, 345);
            groupBoxOutputTable_NAA.TabIndex = 3;
            groupBoxOutputTable_NAA.TabStop = false;
            groupBoxOutputTable_NAA.Text = "Подходящие маршруты";
            // 
            // dataGridViewFilteredRoutes_NAA
            // 
            dataGridViewFilteredRoutes_NAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilteredRoutes_NAA.ColumnHeadersVisible = false;
            dataGridViewFilteredRoutes_NAA.Dock = DockStyle.Fill;
            dataGridViewFilteredRoutes_NAA.Location = new Point(3, 23);
            dataGridViewFilteredRoutes_NAA.Name = "dataGridViewFilteredRoutes_NAA";
            dataGridViewFilteredRoutes_NAA.RowHeadersVisible = false;
            dataGridViewFilteredRoutes_NAA.RowHeadersWidth = 51;
            dataGridViewFilteredRoutes_NAA.Size = new Size(545, 319);
            dataGridViewFilteredRoutes_NAA.TabIndex = 0;
            // 
            // splitter3
            // 
            splitter3.Dock = DockStyle.Top;
            splitter3.Location = new Point(10, 241);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(551, 4);
            splitter3.TabIndex = 2;
            splitter3.TabStop = false;
            // 
            // FormGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 770);
            Controls.Add(panelDataGridViewsAndCharts_NAA);
            Controls.Add(splitter1);
            Controls.Add(panelInputAndOutput_NAA);
            MinimumSize = new Size(1141, 817);
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
            ((System.ComponentModel.ISupportInitialize)chartToStation_NAA).EndInit();
            groupBoxFromChart_NAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFromStation_NAA).EndInit();
            panelDataGridViews_NAA.ResumeLayout(false);
            groupBoxOutputTable_NAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilteredRoutes_NAA).EndInit();
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
        private Button buttonSearch_NAA;
        private ComboBox comboBoxSort_NAA;
        private Label labelFiltration_NAA;
    }
}