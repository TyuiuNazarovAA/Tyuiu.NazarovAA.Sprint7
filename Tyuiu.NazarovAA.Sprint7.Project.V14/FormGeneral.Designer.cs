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
            components = new System.ComponentModel.Container();
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
            panelUserInterface_NAA = new Panel();
            panelAddAndRemove_NAA = new Panel();
            groupBoxRemoveRoute_NAA = new GroupBox();
            buttonRemoveRoute_NAA = new Button();
            labelRemoveTo_NAA = new Label();
            textBoxRemoveNumber_NAA = new TextBox();
            textBoxRemoveFrom_NAA = new TextBox();
            labelRemoveFrom_NAA = new Label();
            textBoxRemoveTo_NAA = new TextBox();
            labelRemoveNumber_NAA = new Label();
            groupBoxAddRoute_NAA = new GroupBox();
            buttonAddRoute_NAA = new Button();
            labelAddTime_NAA = new Label();
            labelAddTo_NAA = new Label();
            labelAddFrom_NAA = new Label();
            labelAddNumber_NAA = new Label();
            textBoxAddTime_NAA = new TextBox();
            textBoxAddTo_NAA = new TextBox();
            textBoxAddFrom_NAA = new TextBox();
            textBoxAddNumber_NAA = new TextBox();
            panelSearchAndDatabase_NAA = new Panel();
            groupBoxDatabase_NAA = new GroupBox();
            labelDatabasePath_NAA = new Label();
            textBoxDatabaseSource_NAA = new TextBox();
            buttonSaveDatabaseFile_NAA = new Button();
            buttonDatabaseFile_NAA = new Button();
            groupBoxInput_NAA = new GroupBox();
            labelSort_NAA = new Label();
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
            toolTipGeneral = new ToolTip(components);
            saveFileDialogRoutes = new SaveFileDialog();
            panelInputAndOutput_NAA.SuspendLayout();
            panelUserInterface_NAA.SuspendLayout();
            panelAddAndRemove_NAA.SuspendLayout();
            groupBoxRemoveRoute_NAA.SuspendLayout();
            groupBoxAddRoute_NAA.SuspendLayout();
            panelSearchAndDatabase_NAA.SuspendLayout();
            groupBoxDatabase_NAA.SuspendLayout();
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
            panelInputAndOutput_NAA.Controls.Add(panelUserInterface_NAA);
            panelInputAndOutput_NAA.Dock = DockStyle.Top;
            panelInputAndOutput_NAA.Location = new Point(0, 0);
            panelInputAndOutput_NAA.Name = "panelInputAndOutput_NAA";
            panelInputAndOutput_NAA.Padding = new Padding(10);
            panelInputAndOutput_NAA.Size = new Size(1142, 289);
            panelInputAndOutput_NAA.TabIndex = 1;
            // 
            // panelUserInterface_NAA
            // 
            panelUserInterface_NAA.Controls.Add(panelAddAndRemove_NAA);
            panelUserInterface_NAA.Controls.Add(panelSearchAndDatabase_NAA);
            panelUserInterface_NAA.Dock = DockStyle.Fill;
            panelUserInterface_NAA.Location = new Point(10, 10);
            panelUserInterface_NAA.Name = "panelUserInterface_NAA";
            panelUserInterface_NAA.Padding = new Padding(10);
            panelUserInterface_NAA.Size = new Size(1122, 269);
            panelUserInterface_NAA.TabIndex = 3;
            // 
            // panelAddAndRemove_NAA
            // 
            panelAddAndRemove_NAA.Controls.Add(groupBoxRemoveRoute_NAA);
            panelAddAndRemove_NAA.Controls.Add(groupBoxAddRoute_NAA);
            panelAddAndRemove_NAA.Dock = DockStyle.Fill;
            panelAddAndRemove_NAA.Location = new Point(10, 160);
            panelAddAndRemove_NAA.Name = "panelAddAndRemove_NAA";
            panelAddAndRemove_NAA.Size = new Size(1102, 99);
            panelAddAndRemove_NAA.TabIndex = 5;
            // 
            // groupBoxRemoveRoute_NAA
            // 
            groupBoxRemoveRoute_NAA.Controls.Add(buttonRemoveRoute_NAA);
            groupBoxRemoveRoute_NAA.Controls.Add(labelRemoveTo_NAA);
            groupBoxRemoveRoute_NAA.Controls.Add(textBoxRemoveNumber_NAA);
            groupBoxRemoveRoute_NAA.Controls.Add(textBoxRemoveFrom_NAA);
            groupBoxRemoveRoute_NAA.Controls.Add(labelRemoveFrom_NAA);
            groupBoxRemoveRoute_NAA.Controls.Add(textBoxRemoveTo_NAA);
            groupBoxRemoveRoute_NAA.Controls.Add(labelRemoveNumber_NAA);
            groupBoxRemoveRoute_NAA.Dock = DockStyle.Fill;
            groupBoxRemoveRoute_NAA.Location = new Point(572, 0);
            groupBoxRemoveRoute_NAA.Name = "groupBoxRemoveRoute_NAA";
            groupBoxRemoveRoute_NAA.Size = new Size(530, 99);
            groupBoxRemoveRoute_NAA.TabIndex = 1;
            groupBoxRemoveRoute_NAA.TabStop = false;
            groupBoxRemoveRoute_NAA.Text = "Удалить маршрут";
            // 
            // buttonRemoveRoute_NAA
            // 
            buttonRemoveRoute_NAA.Image = (Image)resources.GetObject("buttonRemoveRoute_NAA.Image");
            buttonRemoveRoute_NAA.Location = new Point(399, 37);
            buttonRemoveRoute_NAA.Name = "buttonRemoveRoute_NAA";
            buttonRemoveRoute_NAA.Size = new Size(50, 50);
            buttonRemoveRoute_NAA.TabIndex = 2;
            toolTipGeneral.SetToolTip(buttonRemoveRoute_NAA, "Удалить маршрут");
            buttonRemoveRoute_NAA.UseVisualStyleBackColor = true;
            buttonRemoveRoute_NAA.Click += buttonRemoveRoute_NAA_Click;
            // 
            // labelRemoveTo_NAA
            // 
            labelRemoveTo_NAA.AutoSize = true;
            labelRemoveTo_NAA.Location = new Point(234, 37);
            labelRemoveTo_NAA.Name = "labelRemoveTo_NAA";
            labelRemoveTo_NAA.Size = new Size(41, 20);
            labelRemoveTo_NAA.TabIndex = 1;
            labelRemoveTo_NAA.Text = "Куда";
            labelRemoveTo_NAA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxRemoveNumber_NAA
            // 
            textBoxRemoveNumber_NAA.Location = new Point(28, 60);
            textBoxRemoveNumber_NAA.Name = "textBoxRemoveNumber_NAA";
            textBoxRemoveNumber_NAA.Size = new Size(70, 27);
            textBoxRemoveNumber_NAA.TabIndex = 0;
            // 
            // textBoxRemoveFrom_NAA
            // 
            textBoxRemoveFrom_NAA.Location = new Point(116, 60);
            textBoxRemoveFrom_NAA.Name = "textBoxRemoveFrom_NAA";
            textBoxRemoveFrom_NAA.Size = new Size(97, 27);
            textBoxRemoveFrom_NAA.TabIndex = 0;
            // 
            // labelRemoveFrom_NAA
            // 
            labelRemoveFrom_NAA.AutoSize = true;
            labelRemoveFrom_NAA.Location = new Point(116, 37);
            labelRemoveFrom_NAA.Name = "labelRemoveFrom_NAA";
            labelRemoveFrom_NAA.Size = new Size(56, 20);
            labelRemoveFrom_NAA.TabIndex = 1;
            labelRemoveFrom_NAA.Text = "Откуда";
            labelRemoveFrom_NAA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxRemoveTo_NAA
            // 
            textBoxRemoveTo_NAA.Location = new Point(234, 60);
            textBoxRemoveTo_NAA.Name = "textBoxRemoveTo_NAA";
            textBoxRemoveTo_NAA.Size = new Size(97, 27);
            textBoxRemoveTo_NAA.TabIndex = 0;
            // 
            // labelRemoveNumber_NAA
            // 
            labelRemoveNumber_NAA.AutoSize = true;
            labelRemoveNumber_NAA.Location = new Point(28, 37);
            labelRemoveNumber_NAA.Name = "labelRemoveNumber_NAA";
            labelRemoveNumber_NAA.Size = new Size(26, 20);
            labelRemoveNumber_NAA.TabIndex = 1;
            labelRemoveNumber_NAA.Text = "№";
            labelRemoveNumber_NAA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxAddRoute_NAA
            // 
            groupBoxAddRoute_NAA.Controls.Add(buttonAddRoute_NAA);
            groupBoxAddRoute_NAA.Controls.Add(labelAddTime_NAA);
            groupBoxAddRoute_NAA.Controls.Add(labelAddTo_NAA);
            groupBoxAddRoute_NAA.Controls.Add(labelAddFrom_NAA);
            groupBoxAddRoute_NAA.Controls.Add(labelAddNumber_NAA);
            groupBoxAddRoute_NAA.Controls.Add(textBoxAddTime_NAA);
            groupBoxAddRoute_NAA.Controls.Add(textBoxAddTo_NAA);
            groupBoxAddRoute_NAA.Controls.Add(textBoxAddFrom_NAA);
            groupBoxAddRoute_NAA.Controls.Add(textBoxAddNumber_NAA);
            groupBoxAddRoute_NAA.Dock = DockStyle.Left;
            groupBoxAddRoute_NAA.Location = new Point(0, 0);
            groupBoxAddRoute_NAA.Name = "groupBoxAddRoute_NAA";
            groupBoxAddRoute_NAA.Size = new Size(572, 99);
            groupBoxAddRoute_NAA.TabIndex = 0;
            groupBoxAddRoute_NAA.TabStop = false;
            groupBoxAddRoute_NAA.Text = "Добавить маршрут";
            // 
            // buttonAddRoute_NAA
            // 
            buttonAddRoute_NAA.Image = (Image)resources.GetObject("buttonAddRoute_NAA.Image");
            buttonAddRoute_NAA.Location = new Point(467, 37);
            buttonAddRoute_NAA.Name = "buttonAddRoute_NAA";
            buttonAddRoute_NAA.Size = new Size(50, 50);
            buttonAddRoute_NAA.TabIndex = 2;
            toolTipGeneral.SetToolTip(buttonAddRoute_NAA, "Добавить маршрут");
            buttonAddRoute_NAA.UseVisualStyleBackColor = true;
            buttonAddRoute_NAA.Click += buttonAddRoute_NAA_Click;
            // 
            // labelAddTime_NAA
            // 
            labelAddTime_NAA.AutoSize = true;
            labelAddTime_NAA.Location = new Point(348, 37);
            labelAddTime_NAA.Name = "labelAddTime_NAA";
            labelAddTime_NAA.Size = new Size(100, 20);
            labelAddTime_NAA.TabIndex = 1;
            labelAddTime_NAA.Text = "Время (мин.)";
            labelAddTime_NAA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAddTo_NAA
            // 
            labelAddTo_NAA.AutoSize = true;
            labelAddTo_NAA.Location = new Point(227, 37);
            labelAddTo_NAA.Name = "labelAddTo_NAA";
            labelAddTo_NAA.Size = new Size(41, 20);
            labelAddTo_NAA.TabIndex = 1;
            labelAddTo_NAA.Text = "Куда";
            labelAddTo_NAA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAddFrom_NAA
            // 
            labelAddFrom_NAA.AutoSize = true;
            labelAddFrom_NAA.Location = new Point(109, 37);
            labelAddFrom_NAA.Name = "labelAddFrom_NAA";
            labelAddFrom_NAA.Size = new Size(56, 20);
            labelAddFrom_NAA.TabIndex = 1;
            labelAddFrom_NAA.Text = "Откуда";
            labelAddFrom_NAA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAddNumber_NAA
            // 
            labelAddNumber_NAA.AutoSize = true;
            labelAddNumber_NAA.Location = new Point(21, 37);
            labelAddNumber_NAA.Name = "labelAddNumber_NAA";
            labelAddNumber_NAA.Size = new Size(26, 20);
            labelAddNumber_NAA.TabIndex = 1;
            labelAddNumber_NAA.Text = "№";
            labelAddNumber_NAA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAddTime_NAA
            // 
            textBoxAddTime_NAA.Location = new Point(348, 60);
            textBoxAddTime_NAA.Name = "textBoxAddTime_NAA";
            textBoxAddTime_NAA.Size = new Size(68, 27);
            textBoxAddTime_NAA.TabIndex = 0;
            // 
            // textBoxAddTo_NAA
            // 
            textBoxAddTo_NAA.Location = new Point(227, 60);
            textBoxAddTo_NAA.Name = "textBoxAddTo_NAA";
            textBoxAddTo_NAA.Size = new Size(97, 27);
            textBoxAddTo_NAA.TabIndex = 0;
            // 
            // textBoxAddFrom_NAA
            // 
            textBoxAddFrom_NAA.Location = new Point(109, 60);
            textBoxAddFrom_NAA.Name = "textBoxAddFrom_NAA";
            textBoxAddFrom_NAA.Size = new Size(97, 27);
            textBoxAddFrom_NAA.TabIndex = 0;
            // 
            // textBoxAddNumber_NAA
            // 
            textBoxAddNumber_NAA.Location = new Point(21, 60);
            textBoxAddNumber_NAA.Name = "textBoxAddNumber_NAA";
            textBoxAddNumber_NAA.Size = new Size(70, 27);
            textBoxAddNumber_NAA.TabIndex = 0;
            // 
            // panelSearchAndDatabase_NAA
            // 
            panelSearchAndDatabase_NAA.Controls.Add(groupBoxDatabase_NAA);
            panelSearchAndDatabase_NAA.Controls.Add(groupBoxInput_NAA);
            panelSearchAndDatabase_NAA.Dock = DockStyle.Top;
            panelSearchAndDatabase_NAA.Location = new Point(10, 10);
            panelSearchAndDatabase_NAA.Name = "panelSearchAndDatabase_NAA";
            panelSearchAndDatabase_NAA.Size = new Size(1102, 150);
            panelSearchAndDatabase_NAA.TabIndex = 4;
            // 
            // groupBoxDatabase_NAA
            // 
            groupBoxDatabase_NAA.Controls.Add(labelDatabasePath_NAA);
            groupBoxDatabase_NAA.Controls.Add(textBoxDatabaseSource_NAA);
            groupBoxDatabase_NAA.Controls.Add(buttonSaveDatabaseFile_NAA);
            groupBoxDatabase_NAA.Controls.Add(buttonDatabaseFile_NAA);
            groupBoxDatabase_NAA.Dock = DockStyle.Fill;
            groupBoxDatabase_NAA.Location = new Point(572, 0);
            groupBoxDatabase_NAA.Name = "groupBoxDatabase_NAA";
            groupBoxDatabase_NAA.Size = new Size(530, 150);
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
            textBoxDatabaseSource_NAA.Location = new Point(92, 64);
            textBoxDatabaseSource_NAA.Multiline = true;
            textBoxDatabaseSource_NAA.Name = "textBoxDatabaseSource_NAA";
            textBoxDatabaseSource_NAA.ReadOnly = true;
            textBoxDatabaseSource_NAA.Size = new Size(417, 67);
            textBoxDatabaseSource_NAA.TabIndex = 1;
            textBoxDatabaseSource_NAA.Text = "Не выбран";
            // 
            // buttonSaveDatabaseFile_NAA
            // 
            buttonSaveDatabaseFile_NAA.Image = (Image)resources.GetObject("buttonSaveDatabaseFile_NAA.Image");
            buttonSaveDatabaseFile_NAA.Location = new Point(31, 84);
            buttonSaveDatabaseFile_NAA.Name = "buttonSaveDatabaseFile_NAA";
            buttonSaveDatabaseFile_NAA.Size = new Size(53, 47);
            buttonSaveDatabaseFile_NAA.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonSaveDatabaseFile_NAA, "Сохранить базу данных");
            buttonSaveDatabaseFile_NAA.UseVisualStyleBackColor = true;
            buttonSaveDatabaseFile_NAA.Click += buttonSaveDatabaseFile_NAA_Click;
            // 
            // buttonDatabaseFile_NAA
            // 
            buttonDatabaseFile_NAA.Image = (Image)resources.GetObject("buttonDatabaseFile_NAA.Image");
            buttonDatabaseFile_NAA.Location = new Point(31, 31);
            buttonDatabaseFile_NAA.Name = "buttonDatabaseFile_NAA";
            buttonDatabaseFile_NAA.Size = new Size(53, 47);
            buttonDatabaseFile_NAA.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonDatabaseFile_NAA, "Подключить базу данных");
            buttonDatabaseFile_NAA.UseVisualStyleBackColor = true;
            buttonDatabaseFile_NAA.Click += buttonDatabaseFile_NAA_Click;
            // 
            // groupBoxInput_NAA
            // 
            groupBoxInput_NAA.Controls.Add(labelSort_NAA);
            groupBoxInput_NAA.Controls.Add(comboBoxSort_NAA);
            groupBoxInput_NAA.Controls.Add(buttonSearch_NAA);
            groupBoxInput_NAA.Controls.Add(labelTo_NAA);
            groupBoxInput_NAA.Controls.Add(labelFrom_NAA);
            groupBoxInput_NAA.Controls.Add(textBoxFromStation_NAA);
            groupBoxInput_NAA.Controls.Add(textBoxToStation_NAA);
            groupBoxInput_NAA.Dock = DockStyle.Left;
            groupBoxInput_NAA.Location = new Point(0, 0);
            groupBoxInput_NAA.Name = "groupBoxInput_NAA";
            groupBoxInput_NAA.Size = new Size(572, 150);
            groupBoxInput_NAA.TabIndex = 1;
            groupBoxInput_NAA.TabStop = false;
            groupBoxInput_NAA.Text = "Поиск маршрута";
            // 
            // labelSort_NAA
            // 
            labelSort_NAA.AutoSize = true;
            labelSort_NAA.Location = new Point(328, 33);
            labelSort_NAA.Name = "labelSort_NAA";
            labelSort_NAA.Size = new Size(92, 20);
            labelSort_NAA.TabIndex = 4;
            labelSort_NAA.Text = "Сортировка";
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
            toolTipGeneral.SetToolTip(comboBoxSort_NAA, "Параметр фильтра");
            // 
            // buttonSearch_NAA
            // 
            buttonSearch_NAA.Image = (Image)resources.GetObject("buttonSearch_NAA.Image");
            buttonSearch_NAA.Location = new Point(510, 33);
            buttonSearch_NAA.Name = "buttonSearch_NAA";
            buttonSearch_NAA.Size = new Size(45, 42);
            buttonSearch_NAA.TabIndex = 2;
            toolTipGeneral.SetToolTip(buttonSearch_NAA, "Найти маршруты");
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
            groupBoxInputTable_NAA.Size = new Size(551, 337);
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
            dataGridViewAllRoutes_NAA.Size = new Size(545, 311);
            dataGridViewAllRoutes_NAA.TabIndex = 0;
            // 
            // openFileDialogRoutes
            // 
            openFileDialogRoutes.FileName = "None";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 289);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1142, 4);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // panelDataGridViewsAndCharts_NAA
            // 
            panelDataGridViewsAndCharts_NAA.Controls.Add(panelCharts_NAA);
            panelDataGridViewsAndCharts_NAA.Controls.Add(splitter2);
            panelDataGridViewsAndCharts_NAA.Controls.Add(panelDataGridViews_NAA);
            panelDataGridViewsAndCharts_NAA.Dock = DockStyle.Fill;
            panelDataGridViewsAndCharts_NAA.Location = new Point(0, 293);
            panelDataGridViewsAndCharts_NAA.Name = "panelDataGridViewsAndCharts_NAA";
            panelDataGridViewsAndCharts_NAA.Size = new Size(1142, 739);
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
            panelCharts_NAA.Size = new Size(567, 739);
            panelCharts_NAA.TabIndex = 2;
            // 
            // groupBoxToChart_NAA
            // 
            groupBoxToChart_NAA.Controls.Add(chartToStation_NAA);
            groupBoxToChart_NAA.Dock = DockStyle.Fill;
            groupBoxToChart_NAA.Location = new Point(10, 351);
            groupBoxToChart_NAA.Name = "groupBoxToChart_NAA";
            groupBoxToChart_NAA.Size = new Size(547, 378);
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
            chartToStation_NAA.Size = new Size(541, 352);
            chartToStation_NAA.TabIndex = 0;
            chartToStation_NAA.Text = "chart2";
            // 
            // splitter5
            // 
            splitter5.Dock = DockStyle.Top;
            splitter5.Location = new Point(10, 347);
            splitter5.Name = "splitter5";
            splitter5.Size = new Size(547, 4);
            splitter5.TabIndex = 1;
            splitter5.TabStop = false;
            // 
            // groupBoxFromChart_NAA
            // 
            groupBoxFromChart_NAA.Controls.Add(chartFromStation_NAA);
            groupBoxFromChart_NAA.Dock = DockStyle.Top;
            groupBoxFromChart_NAA.Location = new Point(10, 10);
            groupBoxFromChart_NAA.Name = "groupBoxFromChart_NAA";
            groupBoxFromChart_NAA.Size = new Size(547, 337);
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
            chartFromStation_NAA.Size = new Size(541, 311);
            chartFromStation_NAA.TabIndex = 0;
            chartFromStation_NAA.Text = "chart1";
            // 
            // splitter2
            // 
            splitter2.Location = new Point(571, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 739);
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
            panelDataGridViews_NAA.Size = new Size(571, 739);
            panelDataGridViews_NAA.TabIndex = 0;
            // 
            // groupBoxOutputTable_NAA
            // 
            groupBoxOutputTable_NAA.Controls.Add(dataGridViewFilteredRoutes_NAA);
            groupBoxOutputTable_NAA.Dock = DockStyle.Fill;
            groupBoxOutputTable_NAA.Location = new Point(10, 351);
            groupBoxOutputTable_NAA.Name = "groupBoxOutputTable_NAA";
            groupBoxOutputTable_NAA.Size = new Size(551, 378);
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
            dataGridViewFilteredRoutes_NAA.Size = new Size(545, 352);
            dataGridViewFilteredRoutes_NAA.TabIndex = 0;
            // 
            // splitter3
            // 
            splitter3.Dock = DockStyle.Top;
            splitter3.Location = new Point(10, 347);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(551, 4);
            splitter3.TabIndex = 2;
            splitter3.TabStop = false;
            // 
            // toolTipGeneral
            // 
            toolTipGeneral.ToolTipIcon = ToolTipIcon.Info;
            toolTipGeneral.ToolTipTitle = "Подсказка";
            // 
            // FormGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 1032);
            Controls.Add(panelDataGridViewsAndCharts_NAA);
            Controls.Add(splitter1);
            Controls.Add(panelInputAndOutput_NAA);
            MinimumSize = new Size(1160, 1079);
            Name = "FormGeneral";
            Text = "Основная программа";
            panelInputAndOutput_NAA.ResumeLayout(false);
            panelUserInterface_NAA.ResumeLayout(false);
            panelAddAndRemove_NAA.ResumeLayout(false);
            groupBoxRemoveRoute_NAA.ResumeLayout(false);
            groupBoxRemoveRoute_NAA.PerformLayout();
            groupBoxAddRoute_NAA.ResumeLayout(false);
            groupBoxAddRoute_NAA.PerformLayout();
            panelSearchAndDatabase_NAA.ResumeLayout(false);
            groupBoxDatabase_NAA.ResumeLayout(false);
            groupBoxDatabase_NAA.PerformLayout();
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
        private Panel panelUserInterface_NAA;
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
        private Label labelSort_NAA;
        private ToolTip toolTipGeneral;
        private Panel panelSearchAndDatabase_NAA;
        private Panel panelAddAndRemove_NAA;
        private GroupBox groupBoxRemoveRoute_NAA;
        private GroupBox groupBoxAddRoute_NAA;
        private Button buttonSaveDatabaseFile_NAA;
        private TextBox textBoxAddTime_NAA;
        private TextBox textBoxAddTo_NAA;
        private TextBox textBoxAddFrom_NAA;
        private TextBox textBoxAddNumber_NAA;
        private Label labelAddTime_NAA;
        private Label labelAddTo_NAA;
        private Label labelAddFrom_NAA;
        private Label labelAddNumber_NAA;
        private Button buttonRemoveRoute_NAA;
        private Label labelRemoveTo_NAA;
        private TextBox textBoxRemoveNumber_NAA;
        private TextBox textBoxRemoveFrom_NAA;
        private Label labelRemoveFrom_NAA;
        private TextBox textBoxRemoveTo_NAA;
        private Label labelRemoveNumber_NAA;
        private Button buttonAddRoute_NAA;
        private SaveFileDialog saveFileDialogRoutes;
    }
}