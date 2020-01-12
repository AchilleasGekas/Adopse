namespace WindowsFormsApp1
{
    partial class Prosfores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prosfores));
            this.panel5 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCOUNTPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLocal = new WindowsFormsApp1.DatabaseLocal();
            this.discount_PriceTableAdapter = new WindowsFormsApp1.DatabaseLocalTableAdapters.Discount_PriceTableAdapter();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.close);
            this.panel5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(801, 32);
            this.panel5.TabIndex = 91;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.close.Cursor = System.Windows.Forms.Cursors.Default;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(774, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 13;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDTITLEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dISCOUNTPRICEDataGridViewTextBoxColumn,
            this.aREADataGridViewTextBoxColumn,
            this.tELEPHONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.discountPriceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 403);
            this.dataGridView1.TabIndex = 92;
            // 
            // aDTITLEDataGridViewTextBoxColumn
            // 
            this.aDTITLEDataGridViewTextBoxColumn.DataPropertyName = "AD_TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.HeaderText = "AD_TITLE";
            this.aDTITLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDTITLEDataGridViewTextBoxColumn.Name = "aDTITLEDataGridViewTextBoxColumn";
            this.aDTITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dISCOUNTPRICEDataGridViewTextBoxColumn
            // 
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT_PRICE";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.HeaderText = "DISCOUNT_PRICE";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.Name = "dISCOUNTPRICEDataGridViewTextBoxColumn";
            this.dISCOUNTPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aREADataGridViewTextBoxColumn
            // 
            this.aREADataGridViewTextBoxColumn.DataPropertyName = "AREA";
            this.aREADataGridViewTextBoxColumn.HeaderText = "AREA";
            this.aREADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aREADataGridViewTextBoxColumn.Name = "aREADataGridViewTextBoxColumn";
            this.aREADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEPHONEDataGridViewTextBoxColumn
            // 
            this.tELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.HeaderText = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tELEPHONEDataGridViewTextBoxColumn.Name = "tELEPHONEDataGridViewTextBoxColumn";
            this.tELEPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountPriceBindingSource
            // 
            this.discountPriceBindingSource.DataMember = "Discount_Price";
            this.discountPriceBindingSource.DataSource = this.databaseLocal;
            // 
            // databaseLocal
            // 
            this.databaseLocal.DataSetName = "DatabaseLocal";
            this.databaseLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discount_PriceTableAdapter
            // 
            this.discount_PriceTableAdapter.ClearBeforeFill = true;
            // 
            // Prosfores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prosfores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prosfores";
            this.Load += new System.EventHandler(this.Prosfores_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseLocal databaseLocal;
        private System.Windows.Forms.BindingSource discountPriceBindingSource;
        private DatabaseLocalTableAdapters.Discount_PriceTableAdapter discount_PriceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONEDataGridViewTextBoxColumn;
    }
}