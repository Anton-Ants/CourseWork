namespace CourseWorkDB.View
{
    partial class ProductTypeForm
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductType = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesDBDataSet = new CourseWorkDB.StoresDBDataSet();
            this.productTypesTableAdapter = new CourseWorkDB.StoresDBDataSetTableAdapters.ProductTypesTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(15, 112);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(163, 22);
            this.txtType.TabIndex = 0;
            this.txtType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a new product type";
            // 
            // dgvProductType
            // 
            this.dgvProductType.AutoGenerateColumns = false;
            this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvProductType.DataSource = this.productTypesBindingSource;
            this.dgvProductType.Location = new System.Drawing.Point(241, 9);
            this.dgvProductType.Name = "dgvProductType";
            this.dgvProductType.RowTemplate.Height = 24;
            this.dgvProductType.Size = new System.Drawing.Size(322, 324);
            this.dgvProductType.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // productTypesBindingSource
            // 
            this.productTypesBindingSource.DataMember = "ProductTypes";
            this.productTypesBindingSource.DataSource = this.storesDBDataSet;
            // 
            // storesDBDataSet
            // 
            this.storesDBDataSet.DataSetName = "StoresDBDataSet";
            this.storesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTypesTableAdapter
            // 
            this.productTypesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 345);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProductType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Name = "ProductTypeForm";
            this.Text = "ProductTypeForm1";
            this.Load += new System.EventHandler(this.ProductTypeForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductType;
        private StoresDBDataSet storesDBDataSet;
        private System.Windows.Forms.BindingSource productTypesBindingSource;
        private StoresDBDataSetTableAdapters.ProductTypesTableAdapter productTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}