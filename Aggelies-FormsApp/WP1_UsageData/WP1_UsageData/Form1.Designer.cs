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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WP1_UsageData.Database1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sEARCHEDTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WP1_UsageData.Database1DataSet();
            this.sEARCHEDDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEARCHED_DATATableAdapter = new WP1_UsageData.Database1DataSetTableAdapters.SEARCHED_DATATableAdapter();
            this.fillBySearchnCountToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBySearchnCountToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.query1TableAdapter = new WP1_UsageData.Database1DataSetTableAdapters.Query1TableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHEDDATABindingSource)).BeginInit();
            this.fillBySearchnCountToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEARCHEDTEXTDataGridViewTextBoxColumn,
            this.TIMES});
            this.dataGridView1.DataSource = this.query1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sEARCHEDTEXTDataGridViewTextBoxColumn
            // 
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.DataPropertyName = "SEARCHED_TEXT";
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.HeaderText = "SEARCHED_TEXT";
            this.sEARCHEDTEXTDataGridViewTextBoxColumn.Name = "sEARCHEDTEXTDataGridViewTextBoxColumn";
            // 
            // TIMES
            // 
            this.TIMES.DataPropertyName = "TIMES";
            this.TIMES.HeaderText = "TIMES";
            this.TIMES.Name = "TIMES";
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
            // fillBySearchnCountToolStrip
            // 
            this.fillBySearchnCountToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBySearchnCountToolStripButton});
            this.fillBySearchnCountToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBySearchnCountToolStrip.Name = "fillBySearchnCountToolStrip";
            this.fillBySearchnCountToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillBySearchnCountToolStrip.TabIndex = 1;
            this.fillBySearchnCountToolStrip.Text = "fillBySearchnCountToolStrip";
            // 
            // fillBySearchnCountToolStripButton
            // 
            this.fillBySearchnCountToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBySearchnCountToolStripButton.Name = "fillBySearchnCountToolStripButton";
            this.fillBySearchnCountToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillBySearchnCountToolStripButton.Text = "FillBySearchnCount";
            this.fillBySearchnCountToolStripButton.Click += new System.EventHandler(this.fillBySearchnCountToolStripButton_Click);
            // 
            // query1TableAdapter
            // 
            this.query1TableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(500, 109);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.fillBySearchnCountToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHEDDATABindingSource)).EndInit();
            this.fillBySearchnCountToolStrip.ResumeLayout(false);
            this.fillBySearchnCountToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource aDSBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sEARCHEDDATABindingSource;
        private Database1DataSetTableAdapters.SEARCHED_DATATableAdapter sEARCHED_DATATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEARCHEDTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBySearchnCountToolStrip;
        private System.Windows.Forms.ToolStripButton fillBySearchnCountToolStripButton;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource query1BindingSource;
        private Database1DataSetTableAdapters.Query1TableAdapter query1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMES;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}

