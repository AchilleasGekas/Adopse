namespace WP8_Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCOUNTPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAVORITES = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WP8_Test.Database1DataSet();
            this.fAVORITESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAVORITESTableAdapter = new WP8_Test.Database1DataSetTableAdapters.FAVORITESTableAdapter();
            this.aDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDSTableAdapter = new WP8_Test.Database1DataSetTableAdapters.ADSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAVORITESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "DonateButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDIDDataGridViewTextBoxColumn,
            this.aDTITLEDataGridViewTextBoxColumn,
            this.cATEGORYIDDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.dISCOUNTPRICEDataGridViewTextBoxColumn,
            this.FAVORITES,
            this.delete});
            this.dataGridView1.DataSource = this.aDSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(748, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dISCOUNTPRICEDataGridViewTextBoxColumn
            // 
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT_PRICE";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.HeaderText = "DISCOUNT_PRICE";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.Name = "dISCOUNTPRICEDataGridViewTextBoxColumn";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FAVORITES
            // 
            this.FAVORITES.HeaderText = "FAVORITES";
            this.FAVORITES.Name = "FAVORITES";
            this.FAVORITES.ReadOnly = true;
            this.FAVORITES.Text = "FAVORITES";
            this.FAVORITES.ToolTipText = "ADD TO FAVORITES";
            // 
            // aDSBindingSource1
            // 
            this.aDSBindingSource1.DataMember = "ADS";
            this.aDSBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAVORITESBindingSource
            // 
            this.fAVORITESBindingSource.DataMember = "FAVORITES";
            this.fAVORITESBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // fAVORITESTableAdapter
            // 
            this.fAVORITESTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // delete
            // 
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAVORITESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource fAVORITESBindingSource;
        private Database1DataSetTableAdapters.FAVORITESTableAdapter fAVORITESTableAdapter;
        private System.Windows.Forms.BindingSource aDSBindingSource;
        private Database1DataSetTableAdapters.ADSTableAdapter aDSTableAdapter;
        private System.Windows.Forms.BindingSource aDSBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn FAVORITES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}

