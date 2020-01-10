namespace WP9_SearchBar_EK
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
            this.AdsGV = new System.Windows.Forms.DataGridView();
            this.aDSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WP9_SearchBar_EK.Database1DataSet();
            this.aDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aDSTableAdapter = new WP9_SearchBar_EK.Database1DataSetTableAdapters.ADSTableAdapter();
            this.aCTIVITY_USERTableAdapter = new WP9_SearchBar_EK.Database1DataSetTableAdapters.ACTIVITY_USERTableAdapter();
            this.sEARCHED_DATATableAdapter = new WP9_SearchBar_EK.Database1DataSetTableAdapters.SEARCHED_DATATableAdapter();
            this.aDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.AdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdsGV
            // 
            this.AdsGV.AutoGenerateColumns = false;
            this.AdsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.AdsGV.DataSource = this.aDSBindingSource;
            this.AdsGV.Location = new System.Drawing.Point(1, 70);
            this.AdsGV.Name = "AdsGV";
            this.AdsGV.Size = new System.Drawing.Size(744, 203);
            this.AdsGV.TabIndex = 0;
            // 
            // aDSBindingSource2
            // 
            this.aDSBindingSource2.DataMember = "ADS";
            this.aDSBindingSource2.DataSource = this.database1DataSet;
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
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(1, 28);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(210, 20);
            this.searchTB.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(265, 28);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(87, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search me";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "SEARCHED_DATA";
            this.bindingSource2.DataSource = this.database1DataSet;
            this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ACTIVITY_USER";
            this.bindingSource1.DataSource = this.database1DataSet;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // aDSTableAdapter
            // 
            this.aDSTableAdapter.ClearBeforeFill = true;
            // 
            // aCTIVITY_USERTableAdapter
            // 
            this.aCTIVITY_USERTableAdapter.ClearBeforeFill = true;
            // 
            // sEARCHED_DATATableAdapter
            // 
            this.sEARCHED_DATATableAdapter.ClearBeforeFill = true;
            // 
            // aDSBindingSource1
            // 
            this.aDSBindingSource1.DataMember = "ADS";
            this.aDSBindingSource1.DataSource = this.database1DataSet;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.AdsGV);
            this.Name = "Form1";
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdsGV;
        private System.Windows.Forms.BindingSource aDSBindingSource;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource aDSBindingSource1;
        private System.Windows.Forms.BindingSource aDSBindingSource2;
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
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.ADSTableAdapter aDSTableAdapter;
        private Database1DataSetTableAdapters.ACTIVITY_USERTableAdapter aCTIVITY_USERTableAdapter;
        private Database1DataSetTableAdapters.SEARCHED_DATATableAdapter sEARCHED_DATATableAdapter;
    }
}

