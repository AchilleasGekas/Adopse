namespace WindowsFormsApp1
{
    partial class Usage_Data
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.usage_DataTC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.search_dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.load_GraphBtn = new System.Windows.Forms.Button();
            this.search_DataGV = new System.Windows.Forms.DataGridView();
            this.sEARCHEDTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLocal = new WindowsFormsApp1.DatabaseLocal();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.load_GraphsBtn = new System.Windows.Forms.Button();
            this.choose_graph = new System.Windows.Forms.ComboBox();
            this.donateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.actionsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.user_ActivityGV = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMESTAMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIONPERFORMEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVITYUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.query1TableAdapter = new WindowsFormsApp1.DatabaseLocalTableAdapters.Query1TableAdapter();
            this.aCTIVITY_USERTableAdapter = new WindowsFormsApp1.DatabaseLocalTableAdapters.ACTIVITY_USERTableAdapter();
            this.usage_DataTC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_dataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_DataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ActivityGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYUSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usage_DataTC
            // 
            this.usage_DataTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usage_DataTC.Controls.Add(this.tabPage1);
            this.usage_DataTC.Controls.Add(this.tabPage2);
            this.usage_DataTC.Location = new System.Drawing.Point(-7, 3);
            this.usage_DataTC.Name = "usage_DataTC";
            this.usage_DataTC.SelectedIndex = 0;
            this.usage_DataTC.Size = new System.Drawing.Size(1015, 466);
            this.usage_DataTC.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.search_dataChart);
            this.tabPage1.Controls.Add(this.load_GraphBtn);
            this.tabPage1.Controls.Add(this.search_DataGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // search_dataChart
            // 
            this.search_dataChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.search_dataChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.search_dataChart.Legends.Add(legend4);
            this.search_dataChart.Location = new System.Drawing.Point(419, 10);
            this.search_dataChart.Name = "search_dataChart";
            this.search_dataChart.Size = new System.Drawing.Size(582, 427);
            this.search_dataChart.TabIndex = 2;
            this.search_dataChart.Text = "chart1";
            // 
            // load_GraphBtn
            // 
            this.load_GraphBtn.Location = new System.Drawing.Point(187, 156);
            this.load_GraphBtn.Name = "load_GraphBtn";
            this.load_GraphBtn.Size = new System.Drawing.Size(115, 23);
            this.load_GraphBtn.TabIndex = 1;
            this.load_GraphBtn.Text = "Load Graph";
            this.load_GraphBtn.UseVisualStyleBackColor = true;
            this.load_GraphBtn.Click += new System.EventHandler(this.load_GraphBtn_Click);
            // 
            // search_DataGV
            // 
            this.search_DataGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_DataGV.AutoGenerateColumns = false;
            this.search_DataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.search_DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEARCHEDTEXTDataGridViewTextBoxColumn,
            this.tIMESDataGridViewTextBoxColumn});
            this.search_DataGV.DataSource = this.query1BindingSource;
            this.search_DataGV.Location = new System.Drawing.Point(6, 0);
            this.search_DataGV.Name = "search_DataGV";
            this.search_DataGV.Size = new System.Drawing.Size(296, 150);
            this.search_DataGV.TabIndex = 0;
            // 
            // sEARCHEDTEXTDataGridViewTextBoxColumn
            // 
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.DataPropertyName = "SEARCHED_TEXT";
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.HeaderText = "SEARCHED_TEXT";
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.Name = "sEARCHEDTEXTDataGridViewTextBoxColumn";
            // 
            // tIMESDataGridViewTextBoxColumn
            // 
            this.tIMESDataGridViewTextBoxColumn.DataPropertyName = "TIMES";
            this.tIMESDataGridViewTextBoxColumn.HeaderText = "TIMES";
            this.tIMESDataGridViewTextBoxColumn.Name = "tIMESDataGridViewTextBoxColumn";
            // 
            // query1BindingSource
            // 
            this.query1BindingSource.DataMember = "Query1";
            this.query1BindingSource.DataSource = this.databaseLocal;
            // 
            // databaseLocal
            // 
            this.databaseLocal.DataSetName = "DatabaseLocal";
            this.databaseLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.load_GraphsBtn);
            this.tabPage2.Controls.Add(this.choose_graph);
            this.tabPage2.Controls.Add(this.donateChart);
            this.tabPage2.Controls.Add(this.actionsChart);
            this.tabPage2.Controls.Add(this.user_ActivityGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Activity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // load_GraphsBtn
            // 
            this.load_GraphsBtn.Location = new System.Drawing.Point(176, 175);
            this.load_GraphsBtn.Name = "load_GraphsBtn";
            this.load_GraphsBtn.Size = new System.Drawing.Size(75, 23);
            this.load_GraphsBtn.TabIndex = 4;
            this.load_GraphsBtn.Text = "Load  Graphs";
            this.load_GraphsBtn.UseVisualStyleBackColor = true;
            this.load_GraphsBtn.Click += new System.EventHandler(this.load_GraphsBtn_Click);
            // 
            // choose_graph
            // 
            this.choose_graph.FormattingEnabled = true;
            this.choose_graph.Items.AddRange(new object[] {
            "NumberofActions",
            "UsersLogedByDate",
            "DonationPressed"});
            this.choose_graph.Location = new System.Drawing.Point(6, 175);
            this.choose_graph.Name = "choose_graph";
            this.choose_graph.Size = new System.Drawing.Size(121, 21);
            this.choose_graph.TabIndex = 3;
            // 
            // donateChart
            // 
            chartArea5.Name = "ChartArea1";
            this.donateChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.donateChart.Legends.Add(legend5);
            this.donateChart.Location = new System.Drawing.Point(6, 237);
            this.donateChart.Name = "donateChart";
            this.donateChart.Size = new System.Drawing.Size(435, 288);
            this.donateChart.TabIndex = 2;
            this.donateChart.Text = "donateChart";
            // 
            // actionsChart
            // 
            chartArea6.Name = "ChartArea1";
            this.actionsChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.actionsChart.Legends.Add(legend6);
            this.actionsChart.Location = new System.Drawing.Point(483, 237);
            this.actionsChart.Name = "actionsChart";
            this.actionsChart.Size = new System.Drawing.Size(550, 300);
            this.actionsChart.TabIndex = 1;
            this.actionsChart.Text = "actionsChart";
            // 
            // user_ActivityGV
            // 
            this.user_ActivityGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_ActivityGV.AutoGenerateColumns = false;
            this.user_ActivityGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_ActivityGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_ActivityGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.tIMESTAMPDataGridViewTextBoxColumn,
            this.aCTIONPERFORMEDDataGridViewTextBoxColumn,
            this.iPADDRESSDataGridViewTextBoxColumn});
            this.user_ActivityGV.DataSource = this.aCTIVITYUSERBindingSource;
            this.user_ActivityGV.Location = new System.Drawing.Point(0, 3);
            this.user_ActivityGV.Name = "user_ActivityGV";
            this.user_ActivityGV.Size = new System.Drawing.Size(1048, 150);
            this.user_ActivityGV.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "iD";
            this.iDDataGridViewTextBoxColumn.HeaderText = "iD";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // tIMESTAMPDataGridViewTextBoxColumn
            // 
            this.tIMESTAMPDataGridViewTextBoxColumn.DataPropertyName = "TIMESTAMP";
            this.tIMESTAMPDataGridViewTextBoxColumn.HeaderText = "TIMESTAMP";
            this.tIMESTAMPDataGridViewTextBoxColumn.Name = "tIMESTAMPDataGridViewTextBoxColumn";
            // 
            // aCTIONPERFORMEDDataGridViewTextBoxColumn
            // 
            this.aCTIONPERFORMEDDataGridViewTextBoxColumn.DataPropertyName = "ACTIONPERFORMED";
            this.aCTIONPERFORMEDDataGridViewTextBoxColumn.HeaderText = "ACTIONPERFORMED";
            this.aCTIONPERFORMEDDataGridViewTextBoxColumn.Name = "aCTIONPERFORMEDDataGridViewTextBoxColumn";
            // 
            // iPADDRESSDataGridViewTextBoxColumn
            // 
            this.iPADDRESSDataGridViewTextBoxColumn.DataPropertyName = "IP_ADDRESS";
            this.iPADDRESSDataGridViewTextBoxColumn.HeaderText = "IP_ADDRESS";
            this.iPADDRESSDataGridViewTextBoxColumn.Name = "iPADDRESSDataGridViewTextBoxColumn";
            // 
            // aCTIVITYUSERBindingSource
            // 
            this.aCTIVITYUSERBindingSource.DataMember = "ACTIVITY_USER";
            this.aCTIVITYUSERBindingSource.DataSource = this.databaseLocal;
            // 
            // query1TableAdapter
            // 
            this.query1TableAdapter.ClearBeforeFill = true;
            // 
            // aCTIVITY_USERTableAdapter
            // 
            this.aCTIVITY_USERTableAdapter.ClearBeforeFill = true;
            // 
            // Usage_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 469);
            this.Controls.Add(this.usage_DataTC);
            this.Name = "Usage_Data";
            this.Text = "Usage_Data";
            this.Load += new System.EventHandler(this.Usage_Data_Load);
            this.usage_DataTC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_dataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_DataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ActivityGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYUSERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl usage_DataTC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart search_dataChart;
        private System.Windows.Forms.Button load_GraphBtn;
        private System.Windows.Forms.DataGridView search_DataGV;
        private DatabaseLocal databaseLocal;
        private System.Windows.Forms.BindingSource query1BindingSource;
        private DatabaseLocalTableAdapters.Query1TableAdapter query1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEARCHEDTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView user_ActivityGV;
        private System.Windows.Forms.BindingSource aCTIVITYUSERBindingSource;
        private DatabaseLocalTableAdapters.ACTIVITY_USERTableAdapter aCTIVITY_USERTableAdapter;
        private System.Windows.Forms.Button load_GraphsBtn;
        private System.Windows.Forms.ComboBox choose_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart donateChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart actionsChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMESTAMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIONPERFORMEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPADDRESSDataGridViewTextBoxColumn;
    }
}