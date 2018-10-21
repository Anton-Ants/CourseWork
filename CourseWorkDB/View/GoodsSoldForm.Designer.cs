namespace CourseWorkDB.View
{
    partial class GoodsSoldForm
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
            this.btnSold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesDBDataSet = new CourseWorkDB.StoresDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvGoodsSold = new System.Windows.Forms.DataGridView();
            this.goodsSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new CourseWorkDB.StoresDBDataSetTableAdapters.ProductsTableAdapter();
            this.storesTableAdapter = new CourseWorkDB.StoresDBDataSetTableAdapters.StoresTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHowMuch = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSoldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSold
            // 
            this.btnSold.Location = new System.Drawing.Point(365, 359);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(220, 80);
            this.btnSold.TabIndex = 0;
            this.btnSold.Text = "Sold";
            this.btnSold.UseVisualStyleBackColor = true;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select product";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DataSource = this.productsBindingSource;
            this.comboBoxProduct.DisplayMember = "Name";
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(123, 358);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(236, 24);
            this.comboBoxProduct.TabIndex = 2;
            this.comboBoxProduct.ValueMember = "Id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.storesDBDataSetBindingSource;
            // 
            // storesDBDataSetBindingSource
            // 
            this.storesDBDataSetBindingSource.DataSource = this.storesDBDataSet;
            this.storesDBDataSetBindingSource.Position = 0;
            // 
            // storesDBDataSet
            // 
            this.storesDBDataSet.DataSetName = "StoresDBDataSet";
            this.storesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select store";
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DataSource = this.storesBindingSource;
            this.comboBoxStore.DisplayMember = "Name";
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(123, 388);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(236, 24);
            this.comboBoxStore.TabIndex = 4;
            this.comboBoxStore.ValueMember = "Id";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.storesDBDataSet;
            // 
            // dgvGoodsSold
            // 
            this.dgvGoodsSold.AutoGenerateColumns = false;
            this.dgvGoodsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn,
            this.productsDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.storeIdDataGridViewTextBoxColumn});
            this.dgvGoodsSold.DataSource = this.goodsSoldBindingSource;
            this.dgvGoodsSold.Location = new System.Drawing.Point(12, 12);
            this.dgvGoodsSold.Name = "dgvGoodsSold";
            this.dgvGoodsSold.RowTemplate.Height = 24;
            this.dgvGoodsSold.Size = new System.Drawing.Size(1116, 340);
            this.dgvGoodsSold.TabIndex = 5;
            // 
            // goodsSoldBindingSource
            // 
            this.goodsSoldBindingSource.DataSource = typeof(CourseWorkDB.Model.Entity.GoodsSold);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "How much";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHowMuch
            // 
            this.txtHowMuch.Location = new System.Drawing.Point(123, 418);
            this.txtHowMuch.Name = "txtHowMuch";
            this.txtHowMuch.Size = new System.Drawing.Size(236, 22);
            this.txtHowMuch.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // storeDataGridViewTextBoxColumn
            // 
            this.storeDataGridViewTextBoxColumn.DataPropertyName = "Store";
            this.storeDataGridViewTextBoxColumn.HeaderText = "Store";
            this.storeDataGridViewTextBoxColumn.Name = "storeDataGridViewTextBoxColumn";
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "Products";
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            this.storeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // GoodsSoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.txtHowMuch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGoodsSold);
            this.Controls.Add(this.comboBoxStore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSold);
            this.Name = "GoodsSoldForm";
            this.Text = "GoodsSoldForm";
            this.Load += new System.EventHandler(this.GoodsSoldForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSoldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.DataGridView dgvGoodsSold;
        private StoresDBDataSet storesDBDataSet;
        private System.Windows.Forms.BindingSource storesDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource goodsSoldBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private StoresDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private StoresDBDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHowMuch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
    }
}