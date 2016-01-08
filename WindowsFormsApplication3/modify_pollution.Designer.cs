namespace WindowsFormsApplication3
{
    partial class modify_pollution
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sitecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.briefdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventdetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthriskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteeventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdsjDataSet3 = new WindowsFormsApplication3.cdsjDataSet3();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.site_code = new System.Windows.Forms.TextBox();
            this.hazard_statement = new System.Windows.Forms.TextBox();
            this.GHS_signal_word = new System.Windows.Forms.TextBox();
            this.flash_point = new System.Windows.Forms.TextBox();
            this.henry_constant = new System.Windows.Forms.TextBox();
            this.refractive_index = new System.Windows.Forms.TextBox();
            this.Kow = new System.Windows.Forms.TextBox();
            this.vapor_pressure = new System.Windows.Forms.TextBox();
            this.solubility_in_water = new System.Windows.Forms.TextBox();
            this.solubility_in_solvent = new System.Windows.Forms.TextBox();
            this.density = new System.Windows.Forms.TextBox();
            this.apperance = new System.Windows.Forms.TextBox();
            this.boiling_point = new System.Windows.Forms.TextBox();
            this.molar_mass = new System.Windows.Forms.TextBox();
            this.formula = new System.Windows.Forms.TextBox();
            this.LD50 = new System.Windows.Forms.TextBox();
            this.CHN_name = new System.Windows.Forms.TextBox();
            this.abs_name = new System.Windows.Forms.TextBox();
            this.CAS_name = new System.Windows.Forms.TextBox();
            this.CAS_code = new System.Windows.Forms.TextBox();
            this.general_type = new System.Windows.Forms.TextBox();
            this.physical_state = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.source_volume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trans_path = new System.Windows.Forms.TextBox();
            this.source_area = new System.Windows.Forms.TextBox();
            this.location_coordinate = new System.Windows.Forms.TextBox();
            this.location_des = new System.Windows.Forms.TextBox();
            this.source_type = new System.Windows.Forms.TextBox();
            this.source_number = new System.Windows.Forms.TextBox();
            this.pollutant_name = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.site_eventTableAdapter = new WindowsFormsApplication3.cdsjDataSet3TableAdapters.site_eventTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteeventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdsjDataSet3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "污染物信息相关表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sitecodeDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.briefdescriptionDataGridViewTextBoxColumn,
            this.eventdetailDataGridViewTextBoxColumn,
            this.healthriskDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siteeventBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(506, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 181);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sitecodeDataGridViewTextBoxColumn
            // 
            this.sitecodeDataGridViewTextBoxColumn.DataPropertyName = "site_code";
            this.sitecodeDataGridViewTextBoxColumn.HeaderText = "场地代码";
            this.sitecodeDataGridViewTextBoxColumn.Name = "sitecodeDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "事故发生时间";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "事故结束时间";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // briefdescriptionDataGridViewTextBoxColumn
            // 
            this.briefdescriptionDataGridViewTextBoxColumn.DataPropertyName = "brief_description";
            this.briefdescriptionDataGridViewTextBoxColumn.HeaderText = "简要描述";
            this.briefdescriptionDataGridViewTextBoxColumn.Name = "briefdescriptionDataGridViewTextBoxColumn";
            // 
            // eventdetailDataGridViewTextBoxColumn
            // 
            this.eventdetailDataGridViewTextBoxColumn.DataPropertyName = "event_detail";
            this.eventdetailDataGridViewTextBoxColumn.HeaderText = "细节描述";
            this.eventdetailDataGridViewTextBoxColumn.Name = "eventdetailDataGridViewTextBoxColumn";
            // 
            // healthriskDataGridViewTextBoxColumn
            // 
            this.healthriskDataGridViewTextBoxColumn.DataPropertyName = "health_risk";
            this.healthriskDataGridViewTextBoxColumn.HeaderText = "健康风险";
            this.healthriskDataGridViewTextBoxColumn.Name = "healthriskDataGridViewTextBoxColumn";
            // 
            // siteeventBindingSource
            // 
            this.siteeventBindingSource.DataMember = "site_event";
            this.siteeventBindingSource.DataSource = this.cdsjDataSet3;
            // 
            // cdsjDataSet3
            // 
            this.cdsjDataSet3.DataSetName = "cdsjDataSet3";
            this.cdsjDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.site_code);
            this.groupBox4.Controls.Add(this.hazard_statement);
            this.groupBox4.Controls.Add(this.GHS_signal_word);
            this.groupBox4.Controls.Add(this.flash_point);
            this.groupBox4.Controls.Add(this.henry_constant);
            this.groupBox4.Controls.Add(this.refractive_index);
            this.groupBox4.Controls.Add(this.Kow);
            this.groupBox4.Controls.Add(this.vapor_pressure);
            this.groupBox4.Controls.Add(this.solubility_in_water);
            this.groupBox4.Controls.Add(this.solubility_in_solvent);
            this.groupBox4.Controls.Add(this.density);
            this.groupBox4.Controls.Add(this.apperance);
            this.groupBox4.Controls.Add(this.boiling_point);
            this.groupBox4.Controls.Add(this.molar_mass);
            this.groupBox4.Controls.Add(this.formula);
            this.groupBox4.Controls.Add(this.LD50);
            this.groupBox4.Controls.Add(this.CHN_name);
            this.groupBox4.Controls.Add(this.abs_name);
            this.groupBox4.Controls.Add(this.CAS_name);
            this.groupBox4.Controls.Add(this.CAS_code);
            this.groupBox4.Controls.Add(this.general_type);
            this.groupBox4.Controls.Add(this.physical_state);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.label57);
            this.groupBox4.Controls.Add(this.label58);
            this.groupBox4.Location = new System.Drawing.Point(8, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 352);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "污染物的理化参数";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "场地代码";
            // 
            // site_code
            // 
            this.site_code.Location = new System.Drawing.Point(101, 22);
            this.site_code.Name = "site_code";
            this.site_code.Size = new System.Drawing.Size(100, 20);
            this.site_code.TabIndex = 39;
            this.site_code.TextChanged += new System.EventHandler(this.site_code_TextChanged);
            // 
            // hazard_statement
            // 
            this.hazard_statement.Location = new System.Drawing.Point(154, 314);
            this.hazard_statement.Name = "hazard_statement";
            this.hazard_statement.Size = new System.Drawing.Size(296, 20);
            this.hazard_statement.TabIndex = 38;
            // 
            // GHS_signal_word
            // 
            this.GHS_signal_word.Location = new System.Drawing.Point(154, 288);
            this.GHS_signal_word.Name = "GHS_signal_word";
            this.GHS_signal_word.Size = new System.Drawing.Size(74, 20);
            this.GHS_signal_word.TabIndex = 37;
            // 
            // flash_point
            // 
            this.flash_point.Location = new System.Drawing.Point(362, 285);
            this.flash_point.Name = "flash_point";
            this.flash_point.Size = new System.Drawing.Size(88, 20);
            this.flash_point.TabIndex = 36;
            // 
            // henry_constant
            // 
            this.henry_constant.Location = new System.Drawing.Point(154, 262);
            this.henry_constant.Name = "henry_constant";
            this.henry_constant.Size = new System.Drawing.Size(74, 20);
            this.henry_constant.TabIndex = 35;
            // 
            // refractive_index
            // 
            this.refractive_index.Location = new System.Drawing.Point(362, 258);
            this.refractive_index.Name = "refractive_index";
            this.refractive_index.Size = new System.Drawing.Size(88, 20);
            this.refractive_index.TabIndex = 34;
            // 
            // Kow
            // 
            this.Kow.Location = new System.Drawing.Point(154, 234);
            this.Kow.Name = "Kow";
            this.Kow.Size = new System.Drawing.Size(74, 20);
            this.Kow.TabIndex = 33;
            // 
            // vapor_pressure
            // 
            this.vapor_pressure.Location = new System.Drawing.Point(355, 233);
            this.vapor_pressure.Name = "vapor_pressure";
            this.vapor_pressure.Size = new System.Drawing.Size(95, 20);
            this.vapor_pressure.TabIndex = 32;
            // 
            // solubility_in_water
            // 
            this.solubility_in_water.Location = new System.Drawing.Point(154, 207);
            this.solubility_in_water.Name = "solubility_in_water";
            this.solubility_in_water.Size = new System.Drawing.Size(74, 20);
            this.solubility_in_water.TabIndex = 31;
            // 
            // solubility_in_solvent
            // 
            this.solubility_in_solvent.Location = new System.Drawing.Point(355, 207);
            this.solubility_in_solvent.Name = "solubility_in_solvent";
            this.solubility_in_solvent.Size = new System.Drawing.Size(95, 20);
            this.solubility_in_solvent.TabIndex = 30;
            // 
            // density
            // 
            this.density.Location = new System.Drawing.Point(154, 178);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(74, 20);
            this.density.TabIndex = 29;
            // 
            // apperance
            // 
            this.apperance.Location = new System.Drawing.Point(101, 151);
            this.apperance.Name = "apperance";
            this.apperance.Size = new System.Drawing.Size(349, 20);
            this.apperance.TabIndex = 28;
            // 
            // boiling_point
            // 
            this.boiling_point.Location = new System.Drawing.Point(355, 178);
            this.boiling_point.Name = "boiling_point";
            this.boiling_point.Size = new System.Drawing.Size(95, 20);
            this.boiling_point.TabIndex = 27;
            // 
            // molar_mass
            // 
            this.molar_mass.Location = new System.Drawing.Point(101, 124);
            this.molar_mass.Name = "molar_mass";
            this.molar_mass.Size = new System.Drawing.Size(100, 20);
            this.molar_mass.TabIndex = 26;
            // 
            // formula
            // 
            this.formula.Location = new System.Drawing.Point(350, 121);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(100, 20);
            this.formula.TabIndex = 25;
            // 
            // LD50
            // 
            this.LD50.Location = new System.Drawing.Point(101, 99);
            this.LD50.Name = "LD50";
            this.LD50.Size = new System.Drawing.Size(100, 20);
            this.LD50.TabIndex = 24;
            // 
            // CHN_name
            // 
            this.CHN_name.Location = new System.Drawing.Point(350, 96);
            this.CHN_name.Name = "CHN_name";
            this.CHN_name.Size = new System.Drawing.Size(100, 20);
            this.CHN_name.TabIndex = 23;
            // 
            // abs_name
            // 
            this.abs_name.Location = new System.Drawing.Point(100, 75);
            this.abs_name.Name = "abs_name";
            this.abs_name.Size = new System.Drawing.Size(100, 20);
            this.abs_name.TabIndex = 22;
            // 
            // CAS_name
            // 
            this.CAS_name.Location = new System.Drawing.Point(350, 73);
            this.CAS_name.Name = "CAS_name";
            this.CAS_name.Size = new System.Drawing.Size(100, 20);
            this.CAS_name.TabIndex = 21;
            // 
            // CAS_code
            // 
            this.CAS_code.Location = new System.Drawing.Point(100, 48);
            this.CAS_code.Name = "CAS_code";
            this.CAS_code.Size = new System.Drawing.Size(100, 20);
            this.CAS_code.TabIndex = 20;
            // 
            // general_type
            // 
            this.general_type.Location = new System.Drawing.Point(350, 48);
            this.general_type.Name = "general_type";
            this.general_type.Size = new System.Drawing.Size(100, 20);
            this.general_type.TabIndex = 19;
            // 
            // physical_state
            // 
            this.physical_state.Location = new System.Drawing.Point(350, 23);
            this.physical_state.Name = "physical_state";
            this.physical_state.Size = new System.Drawing.Size(100, 20);
            this.physical_state.TabIndex = 18;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 317);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(79, 13);
            this.label38.TabIndex = 17;
            this.label38.Text = "危险防范说明";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(254, 289);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(103, 13);
            this.label39.TabIndex = 16;
            this.label39.Text = "污染物的闪点数据";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(225, 101);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(55, 13);
            this.label40.TabIndex = 17;
            this.label40.Text = "中文名称";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 76);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(55, 13);
            this.label41.TabIndex = 16;
            this.label41.Text = "英文缩写";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(9, 291);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(91, 13);
            this.label42.TabIndex = 15;
            this.label42.Text = "污染物的信号词";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 185);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(139, 13);
            this.label43.TabIndex = 6;
            this.label43.Text = "液体和气体污染物的密度";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(7, 154);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 13);
            this.label44.TabIndex = 3;
            this.label44.Text = "物理性状描述";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(9, 127);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 13);
            this.label45.TabIndex = 2;
            this.label45.Text = "摩尔质量";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(234, 262);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(127, 13);
            this.label46.TabIndex = 13;
            this.label46.Text = "气体污染物的折射系数";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(9, 264);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(127, 13);
            this.label47.TabIndex = 12;
            this.label47.Text = "气体污染物的亨利参数";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(238, 236);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(115, 13);
            this.label48.TabIndex = 11;
            this.label48.Text = "污染物的蒸汽压数据";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(9, 238);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(94, 13);
            this.label49.TabIndex = 10;
            this.label49.Text = "辛醇-水分配系数";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(238, 210);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(115, 13);
            this.label50.TabIndex = 9;
            this.label50.Text = "有机溶剂中的溶解度";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(12, 210);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(67, 13);
            this.label51.TabIndex = 8;
            this.label51.Text = "水中溶解度";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(270, 185);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(31, 13);
            this.label52.TabIndex = 7;
            this.label52.Text = "沸点";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(225, 124);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(43, 13);
            this.label53.TabIndex = 5;
            this.label53.Text = "化学式";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 101);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(93, 13);
            this.label54.TabIndex = 4;
            this.label54.Text = "半数致死量LD50";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(225, 75);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(124, 13);
            this.label55.TabIndex = 3;
            this.label55.Text = "CAS系统中中英文名称";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(7, 51);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(88, 13);
            this.label56.TabIndex = 2;
            this.label56.Text = "CAS系统中代码";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(225, 51);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(34, 13);
            this.label57.TabIndex = 1;
            this.label57.Text = "分类·";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(225, 25);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(79, 13);
            this.label58.TabIndex = 0;
            this.label58.Text = "常见物理形态";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.source_volume);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.trans_path);
            this.groupBox3.Controls.Add(this.source_area);
            this.groupBox3.Controls.Add(this.location_coordinate);
            this.groupBox3.Controls.Add(this.location_des);
            this.groupBox3.Controls.Add(this.source_type);
            this.groupBox3.Controls.Add(this.source_number);
            this.groupBox3.Controls.Add(this.pollutant_name);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Location = new System.Drawing.Point(8, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 161);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "污染源";
            // 
            // source_volume
            // 
            this.source_volume.Location = new System.Drawing.Point(168, 126);
            this.source_volume.Name = "source_volume";
            this.source_volume.Size = new System.Drawing.Size(282, 20);
            this.source_volume.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "预估污染土方量或地下水量";
            // 
            // trans_path
            // 
            this.trans_path.Location = new System.Drawing.Point(128, 98);
            this.trans_path.Name = "trans_path";
            this.trans_path.Size = new System.Drawing.Size(322, 20);
            this.trans_path.TabIndex = 7;
            // 
            // source_area
            // 
            this.source_area.Location = new System.Drawing.Point(350, 74);
            this.source_area.Name = "source_area";
            this.source_area.Size = new System.Drawing.Size(100, 20);
            this.source_area.TabIndex = 15;
            // 
            // location_coordinate
            // 
            this.location_coordinate.Location = new System.Drawing.Point(128, 73);
            this.location_coordinate.Name = "location_coordinate";
            this.location_coordinate.Size = new System.Drawing.Size(100, 20);
            this.location_coordinate.TabIndex = 14;
            // 
            // location_des
            // 
            this.location_des.Location = new System.Drawing.Point(350, 48);
            this.location_des.Name = "location_des";
            this.location_des.Size = new System.Drawing.Size(100, 20);
            this.location_des.TabIndex = 13;
            // 
            // source_type
            // 
            this.source_type.Location = new System.Drawing.Point(128, 49);
            this.source_type.Name = "source_type";
            this.source_type.Size = new System.Drawing.Size(100, 20);
            this.source_type.TabIndex = 12;
            // 
            // source_number
            // 
            this.source_number.Location = new System.Drawing.Point(350, 19);
            this.source_number.Name = "source_number";
            this.source_number.Size = new System.Drawing.Size(100, 20);
            this.source_number.TabIndex = 11;
            // 
            // pollutant_name
            // 
            this.pollutant_name.Location = new System.Drawing.Point(128, 23);
            this.pollutant_name.Name = "pollutant_name";
            this.pollutant_name.Size = new System.Drawing.Size(100, 20);
            this.pollutant_name.TabIndex = 10;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(10, 98);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(79, 13);
            this.label37.TabIndex = 8;
            this.label37.Text = "潜在污染途径";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(10, 73);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "污染源坐标位置";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(252, 73);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 13);
            this.label36.TabIndex = 7;
            this.label36.Text = "污染源面积";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(252, 49);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 13);
            this.label34.TabIndex = 7;
            this.label34.Text = "对污染源的描述";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(252, 49);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 13);
            this.label33.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(246, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 8;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "污染源类型";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(252, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "污染源编号";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "污染物的中文名称";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "保存修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // site_eventTableAdapter
            // 
            this.site_eventTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modify_pollution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1185, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Name = "modify_pollution";
            this.Text = "modify_pollution";
            this.Load += new System.EventHandler(this.modify_pollution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteeventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdsjDataSet3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox site_code;
        private System.Windows.Forms.TextBox hazard_statement;
        private System.Windows.Forms.TextBox GHS_signal_word;
        private System.Windows.Forms.TextBox flash_point;
        private System.Windows.Forms.TextBox henry_constant;
        private System.Windows.Forms.TextBox refractive_index;
        private System.Windows.Forms.TextBox Kow;
        private System.Windows.Forms.TextBox vapor_pressure;
        private System.Windows.Forms.TextBox solubility_in_water;
        private System.Windows.Forms.TextBox solubility_in_solvent;
        private System.Windows.Forms.TextBox density;
        private System.Windows.Forms.TextBox apperance;
        private System.Windows.Forms.TextBox boiling_point;
        private System.Windows.Forms.TextBox molar_mass;
        private System.Windows.Forms.TextBox formula;
        private System.Windows.Forms.TextBox LD50;
        private System.Windows.Forms.TextBox CHN_name;
        private System.Windows.Forms.TextBox abs_name;
        private System.Windows.Forms.TextBox CAS_name;
        private System.Windows.Forms.TextBox CAS_code;
        private System.Windows.Forms.TextBox general_type;
        private System.Windows.Forms.TextBox physical_state;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox source_volume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trans_path;
        private System.Windows.Forms.TextBox source_area;
        private System.Windows.Forms.TextBox location_coordinate;
        private System.Windows.Forms.TextBox location_des;
        private System.Windows.Forms.TextBox source_type;
        private System.Windows.Forms.TextBox source_number;
        private System.Windows.Forms.TextBox pollutant_name;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button2;
        private cdsjDataSet3 cdsjDataSet3;
        private System.Windows.Forms.BindingSource siteeventBindingSource;
        private cdsjDataSet3TableAdapters.site_eventTableAdapter site_eventTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn briefdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventdetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthriskDataGridViewTextBoxColumn;
    }
}