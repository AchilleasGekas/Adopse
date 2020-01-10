namespace WP1_UsageData
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.aDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WP1_UsageData.Database1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sEARCHEDTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WP1_UsageData.Database1DataSet();
            this.sEARCHEDDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEARCHED_DATATableAdapter = new WP1_UsageData.Database1DataSetTableAdapters.SEARCHED_DATATableAdapter();
            this.query1TableAdapter = new WP1_UsageData.Database1DataSetTableAdapters.Query1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.query1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aCTIVITYUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCTIVITY_USERTableAdapter = new WP1_UsageData.Database1DataSetTableAdapters.ACTIVITY_USERTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMESTAMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIONPERFORMEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHEDDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYUSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDSBindingSource
            // 
            this.aDSBindingSource.DataMember = "ADS";
            this.aDSBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEARCHEDTEXTDataGridViewTextBoxColumn,
            this.TIMES});
            this.dataGridView1.DataSource = this.query1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(265, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sEARCHEDTEXTDataGridViewTextBoxColumn
            // 
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.DataPropertyName = "SEARCHED_TEXT";
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.HeaderText = "SEARCHED_TEXT";
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.Name = "sEARCHEDTEXTDataGridViewTextBoxColumn";
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TIMES
            // 
            this.TIMES.DataPropertyName = "TIMES";
            this.TIMES.HeaderText = "TIMES";
            this.TIMES.Name = "TIMES";
            this.TIMES.ReadOnly = true;
            // 
            // query1BindingSource
            // 
            this.query1BindingSource.DataMember = "Query1";
            this.query1BindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEARCHEDDATABindingSource
            // 
            this.sEARCHEDDATABindingSource.DataMember = "SEARCHED_DATA";
            this.sEARCHEDDATABindingSource.DataSource = this.database1DataSet;
            // 
            // sEARCHED_DATATableAdapter
            // 
            this.sEARCHED_DATATableAdapter.ClearBeforeFill = true;
            // 
            // query1TableAdapter
            // 
            this.query1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // query1BindingSource1
            // 
            this.query1BindingSource1.DataMember = "Query1";
            this.query1BindingSource1.DataSource = this.database1DataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 452);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Searced Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Activity Tracker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(274, 6);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(514, 327);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.tIMESTAMPDataGridViewTextBoxColumn,
            this.aCTIONPERFORMEDDataGridViewTextBoxColumn,
            this.iPADDRESSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.aCTIVITYUSERBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(569, 157);
            this.dataGridView2.TabIndex = 0;
            // 
            // aCTIVITYUSERBindingSource
            // 
            this.aCTIVITYUSERBindingSource.DataMember = "ACTIVITY_USER";
            this.aCTIVITYUSERBindingSource.DataSource = this.database1DataSet;
            // 
            // aCTIVITY_USERTableAdapter
            // 
            this.aCTIVITY_USERTableAdapter.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHEDDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYUSERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource aDSBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sEARCHEDDATABindingSource;
        private Database1DataSetTableAdapters.SEARCHED_DATATableAdapter sEARCHED_DATATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEARCHEDTEXTDataGridViewTextBoxColumn;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource query1BindingSource;
        private Database1DataSetTableAdapters.Query1TableAdapter query1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource query1BindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource aCTIVITYUSERBindingSource;
        private Database1DataSetTableAdapters.ACTIVITY_USERTableAdapter aCTIVITY_USERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMESTAMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIONPERFORMEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPADDRESSDataGridViewTextBoxColumn;
    }
}

