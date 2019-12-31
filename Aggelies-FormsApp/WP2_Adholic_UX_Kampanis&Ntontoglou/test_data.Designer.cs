namespace WindowsFormsApp1
{
    partial class test_data
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
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDSTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ADSTableAdapter();
            this.aDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSERTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINISHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODIFYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCOUNTPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).BeginInit();
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
            this.iNSERTDATEDataGridViewTextBoxColumn,
            this.fINISHDATEDataGridViewTextBoxColumn,
            this.mODIFYDATEDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.aREAIDDataGridViewTextBoxColumn,
            this.dISCOUNTPRICEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aDSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // aDSBindingSource
            // 
            this.aDSBindingSource.DataMember = "ADS";
            this.aDSBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // aDSTableAdapter
            // 
            this.aDSTableAdapter.ClearBeforeFill = true;
            // 
            // aDIDDataGridViewTextBoxColumn
            // 
            this.aDIDDataGridViewTextBoxColumn.DataPropertyName = "AD_ID";
            this.aDIDDataGridViewTextBoxColumn.HeaderText = "AD_ID";
            this.aDIDDataGridViewTextBoxColumn.Name = "aDIDDataGridViewTextBoxColumn";
            // 
            // aDTITLEDataGridViewTextBoxColumn
            // 
            this.aDTITLEDataGridViewTextBoxColumn.DataPropertyName = "AD_TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.HeaderText = "AD_TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.Name = "aDTITLEDataGridViewTextBoxColumn";
            // 
            // cATEGORYIDDataGridViewTextBoxColumn
            // 
            this.cATEGORYIDDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn.HeaderText = "CATEGORY_ID";
            this.cATEGORYIDDataGridViewTextBoxColumn.Name = "cATEGORYIDDataGridViewTextBoxColumn";
            // 
            // iNSERTDATEDataGridViewTextBoxColumn
            // 
            this.iNSERTDATEDataGridViewTextBoxColumn.DataPropertyName = "INSERT_DATE";
            this.iNSERTDATEDataGridViewTextBoxColumn.HeaderText = "INSERT_DATE";
            this.iNSERTDATEDataGridViewTextBoxColumn.Name = "iNSERTDATEDataGridViewTextBoxColumn";
            // 
            // fINISHDATEDataGridViewTextBoxColumn
            // 
            this.fINISHDATEDataGridViewTextBoxColumn.DataPropertyName = "FINISH_DATE";
            this.fINISHDATEDataGridViewTextBoxColumn.HeaderText = "FINISH_DATE";
            this.fINISHDATEDataGridViewTextBoxColumn.Name = "fINISHDATEDataGridViewTextBoxColumn";
            // 
            // mODIFYDATEDataGridViewTextBoxColumn
            // 
            this.mODIFYDATEDataGridViewTextBoxColumn.DataPropertyName = "MODIFY_DATE";
            this.mODIFYDATEDataGridViewTextBoxColumn.HeaderText = "MODIFY_DATE";
            this.mODIFYDATEDataGridViewTextBoxColumn.Name = "mODIFYDATEDataGridViewTextBoxColumn";
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            // 
            // aREAIDDataGridViewTextBoxColumn
            // 
            this.aREAIDDataGridViewTextBoxColumn.DataPropertyName = "AREA_ID";
            this.aREAIDDataGridViewTextBoxColumn.HeaderText = "AREA_ID";
            this.aREAIDDataGridViewTextBoxColumn.Name = "aREAIDDataGridViewTextBoxColumn";
            // 
            // dISCOUNTPRICEDataGridViewTextBoxColumn
            // 
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT PRICE";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.HeaderText = "DISCOUNT PRICE";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.Name = "dISCOUNTPRICEDataGridViewTextBoxColumn";
            // 
            // test_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "test_data";
            this.Text = "test_data";
            this.Load += new System.EventHandler(this.test_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource aDSBindingSource;
        private Database1DataSetTableAdapters.ADSTableAdapter aDSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSERTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINISHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODIFYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTPRICEDataGridViewTextBoxColumn;
    }
}