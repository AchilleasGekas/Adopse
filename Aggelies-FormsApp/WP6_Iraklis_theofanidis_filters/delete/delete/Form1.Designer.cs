namespace delete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new delete.Database1DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.aDSTableAdapter1 = new delete.Database1DataSet1TableAdapters.ADSTableAdapter();
            this.database1DataSet = new delete.Database1DataSet();
            this.aDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDSTableAdapter = new delete.Database1DataSetTableAdapters.ADSTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDIDDataGridViewTextBoxColumn,
            this.aDTITLEDataGridViewTextBoxColumn,
            this.cATEGORYIDDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.delete});
            this.dataGridView1.DataSource = this.aDSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(717, 109);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aDSBindingSource1
            // 
            this.aDSBindingSource1.DataMember = "ADS";
            this.aDSBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // aDSTableAdapter1
            // 
            this.aDSTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDSBindingSource
            // 
            this.aDSBindingSource.DataMember = "ADS";
            this.aDSBindingSource.DataSource = this.database1DataSet;
            // 
            // aDSTableAdapter
            // 
            this.aDSTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Διαγραφή για τον admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Διαγραφή για τον User";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE2});
            this.dataGridView2.Location = new System.Drawing.Point(12, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(704, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // aDIDDataGridViewTextBoxColumn
            // 
            this.aDIDDataGridViewTextBoxColumn.DataPropertyName = "AD_ID";
            this.aDIDDataGridViewTextBoxColumn.HeaderText = "AD_ID";
            this.aDIDDataGridViewTextBoxColumn.Name = "aDIDDataGridViewTextBoxColumn";
            this.aDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDTITLEDataGridViewTextBoxColumn
            // 
            this.aDTITLEDataGridViewTextBoxColumn.DataPropertyName = "AD_TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.HeaderText = "AD_TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.Name = "aDTITLEDataGridViewTextBoxColumn";
            this.aDTITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORYIDDataGridViewTextBoxColumn
            // 
            this.cATEGORYIDDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn.HeaderText = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn.Name = "cATEGORYIDDataGridViewTextBoxColumn";
            this.cATEGORYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "DELETE";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Διαγραφή αγγελίας";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // DELETE2
            // 
            this.DELETE2.HeaderText = "DELETE";
            this.DELETE2.Name = "DELETE2";
            this.DELETE2.Text = "Διαγραφή αγγελίας";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource aDSBindingSource;
        private Database1DataSetTableAdapters.ADSTableAdapter aDSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource aDSBindingSource1;
        private Database1DataSet1TableAdapters.ADSTableAdapter aDSTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE2;
    }
}

