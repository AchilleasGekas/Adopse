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
            this.aDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WP9_SearchBar_EK.Database1DataSet();
            this.aDSTableAdapter = new WP9_SearchBar_EK.Database1DataSetTableAdapters.ADSTableAdapter();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.aDTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSERTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCOUNTPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AdsGV
            // 
            this.AdsGV.AutoGenerateColumns = false;
            this.AdsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDTITLEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.iNSERTDATEDataGridViewTextBoxColumn,
            this.aREAIDDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.dISCOUNTPRICEDataGridViewTextBoxColumn});
            this.AdsGV.DataSource = this.aDSBindingSource;
            this.AdsGV.Location = new System.Drawing.Point(1, 70);
            this.AdsGV.Name = "AdsGV";
            this.AdsGV.Size = new System.Drawing.Size(744, 203);
            this.AdsGV.TabIndex = 0;
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
            // aDSTableAdapter
            // 
            this.aDSTableAdapter.ClearBeforeFill = true;
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
            // aDTITLEDataGridViewTextBoxColumn
            // 
            this.aDTITLEDataGridViewTextBoxColumn.DataPropertyName = "AD_TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.Name = "aDTITLEDataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // iNSERTDATEDataGridViewTextBoxColumn
            // 
            this.iNSERTDATEDataGridViewTextBoxColumn.DataPropertyName = "INSERT_DATE";
            this.iNSERTDATEDataGridViewTextBoxColumn.HeaderText = "INSERT DATE";
            this.iNSERTDATEDataGridViewTextBoxColumn.Name = "iNSERTDATEDataGridViewTextBoxColumn";
            // 
            // aREAIDDataGridViewTextBoxColumn
            // 
            this.aREAIDDataGridViewTextBoxColumn.DataPropertyName = "AREA_ID";
            this.aREAIDDataGridViewTextBoxColumn.HeaderText = "AREA_ID";
            this.aREAIDDataGridViewTextBoxColumn.Name = "aREAIDDataGridViewTextBoxColumn";
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USER";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdsGV;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource aDSBindingSource;
        private Database1DataSetTableAdapters.ADSTableAdapter aDSTableAdapter;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSERTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTPRICEDataGridViewTextBoxColumn;
    }
}

