namespace form1
{
    partial class garments_view
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
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.store1DataSet = new form1.store1DataSet();
            this.garmentsTableAdapter = new form1.store1DataSetTableAdapters.garmentsTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.store1DataSet1 = new form1.store1DataSet1();
            this.foodTableAdapter = new form1.store1DataSet1TableAdapters.foodTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.store1DataSet2 = new form1.store1DataSet2();
            this.homeappliancesTableAdapter = new form1.store1DataSet2TableAdapters.homeappliancesTableAdapter();
            this.bk = new System.Windows.Forms.Button();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.store1DataSet5 = new form1.store1DataSet5();
            this.food1TableAdapter = new form1.store1DataSet5TableAdapters.food1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.garmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // garmentsBindingSource
            // 
            this.garmentsBindingSource.DataMember = "garments";
            this.garmentsBindingSource.DataSource = this.store1DataSet;
            this.garmentsBindingSource.CurrentChanged += new System.EventHandler(this.garmentsBindingSource_CurrentChanged);
            // 
            // store1DataSet
            // 
            this.store1DataSet.DataSetName = "store1DataSet";
            this.store1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // garmentsTableAdapter
            // 
            this.garmentsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "food";
            this.bindingSource1.DataSource = this.store1DataSet1;
            // 
            // store1DataSet1
            // 
            this.store1DataSet1.DataSetName = "store1DataSet1";
            this.store1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "homeappliances";
            this.bindingSource2.DataSource = this.store1DataSet2;
            // 
            // store1DataSet2
            // 
            this.store1DataSet2.DataSetName = "store1DataSet2";
            this.store1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeappliancesTableAdapter
            // 
            this.homeappliancesTableAdapter.ClearBeforeFill = true;
            // 
            // bk
            // 
            this.bk.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk.Location = new System.Drawing.Point(97, 235);
            this.bk.Name = "bk";
            this.bk.Size = new System.Drawing.Size(75, 23);
            this.bk.TabIndex = 1;
            this.bk.Text = "Back";
            this.bk.UseVisualStyleBackColor = true;
            this.bk.Click += new System.EventHandler(this.bk_Click);
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "food1";
            this.bindingSource3.DataSource = this.store1DataSet5;
            // 
            // store1DataSet5
            // 
            this.store1DataSet5.DataSetName = "store1DataSet5";
            this.store1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // food1TableAdapter
            // 
            this.food1TableAdapter.ClearBeforeFill = true;
            // 
            // garments_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bk);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "garments_view";
            this.Text = "view ";
            this.Load += new System.EventHandler(this.garments_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1DataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private store1DataSet store1DataSet;
        private System.Windows.Forms.BindingSource garmentsBindingSource;
        private store1DataSetTableAdapters.garmentsTableAdapter garmentsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private store1DataSet1 store1DataSet1;
        private store1DataSet1TableAdapters.foodTableAdapter foodTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private store1DataSet2 store1DataSet2;
        private store1DataSet2TableAdapters.homeappliancesTableAdapter homeappliancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bk;
        private System.Windows.Forms.BindingSource bindingSource3;
        private store1DataSet5 store1DataSet5;
        private store1DataSet5TableAdapters.food1TableAdapter food1TableAdapter;
    }
}