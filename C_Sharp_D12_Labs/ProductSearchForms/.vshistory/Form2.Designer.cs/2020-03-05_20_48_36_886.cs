namespace ProductSearchForms
{
    partial class Form2
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label unitsOnOrderLabel;
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.productIDLabel1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.unitPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unitsInStockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unitsOnOrderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            unitsOnOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reorderLevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInStockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsOnOrderNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(2, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(378, 33);
            label1.TabIndex = 23;
            label1.Text = "Product Detailed View ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(229, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(60, 61);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel.TabIndex = 24;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "CategoryID", true));
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(156, 58);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryIDComboBox.TabIndex = 25;
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(60, 90);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(72, 13);
            discontinuedLabel.TabIndex = 26;
            discontinuedLabel.Text = "Discontinued:";
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(156, 85);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(121, 24);
            this.discontinuedCheckBox.TabIndex = 27;
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(60, 112);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 28;
            productIDLabel.Text = "Product ID:";
            // 
            // productIDLabel1
            // 
            this.productIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDLabel1.Location = new System.Drawing.Point(156, 112);
            this.productIDLabel1.Name = "productIDLabel1";
            this.productIDLabel1.Size = new System.Drawing.Size(121, 23);
            this.productIDLabel1.TabIndex = 29;
            this.productIDLabel1.Text = "label2";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(60, 141);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 30;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(156, 138);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.productNameTextBox.TabIndex = 31;
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.Location = new System.Drawing.Point(60, 167);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(90, 13);
            quantityPerUnitLabel.TabIndex = 32;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "QuantityPerUnit", true));
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(156, 164);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityPerUnitTextBox.TabIndex = 33;
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.Location = new System.Drawing.Point(60, 190);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(77, 13);
            reorderLevelLabel.TabIndex = 34;
            reorderLevelLabel.Text = "Reorder Level:";
            // 
            // reorderLevelNumericUpDown
            // 
            this.reorderLevelNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ReorderLevel", true));
            this.reorderLevelNumericUpDown.Location = new System.Drawing.Point(156, 190);
            this.reorderLevelNumericUpDown.Name = "reorderLevelNumericUpDown";
            this.reorderLevelNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.reorderLevelNumericUpDown.TabIndex = 35;
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(60, 219);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 36;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SupplierID", true));
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.Location = new System.Drawing.Point(156, 216);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.supplierIDComboBox.TabIndex = 37;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(60, 243);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 38;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitPriceNumericUpDown
            // 
            this.unitPriceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitPrice", true));
            this.unitPriceNumericUpDown.Location = new System.Drawing.Point(156, 243);
            this.unitPriceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.unitPriceNumericUpDown.Name = "unitPriceNumericUpDown";
            this.unitPriceNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.unitPriceNumericUpDown.TabIndex = 39;
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(60, 269);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(77, 13);
            unitsInStockLabel.TabIndex = 40;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // unitsInStockNumericUpDown
            // 
            this.unitsInStockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitsInStock", true));
            this.unitsInStockNumericUpDown.Location = new System.Drawing.Point(156, 269);
            this.unitsInStockNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.unitsInStockNumericUpDown.Name = "unitsInStockNumericUpDown";
            this.unitsInStockNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.unitsInStockNumericUpDown.TabIndex = 41;
            // 
            // unitsOnOrderLabel
            // 
            unitsOnOrderLabel.AutoSize = true;
            unitsOnOrderLabel.Location = new System.Drawing.Point(60, 295);
            unitsOnOrderLabel.Name = "unitsOnOrderLabel";
            unitsOnOrderLabel.Size = new System.Drawing.Size(80, 13);
            unitsOnOrderLabel.TabIndex = 42;
            unitsOnOrderLabel.Text = "Units On Order:";
            // 
            // unitsOnOrderNumericUpDown
            // 
            this.unitsOnOrderNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitsOnOrder", true));
            this.unitsOnOrderNumericUpDown.Location = new System.Drawing.Point(156, 295);
            this.unitsOnOrderNumericUpDown.Name = "unitsOnOrderNumericUpDown";
            this.unitsOnOrderNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.unitsOnOrderNumericUpDown.TabIndex = 43;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ProductSearchForms.Product);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 385);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.discontinuedCheckBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDLabel1);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(quantityPerUnitLabel);
            this.Controls.Add(this.quantityPerUnitTextBox);
            this.Controls.Add(reorderLevelLabel);
            this.Controls.Add(this.reorderLevelNumericUpDown);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDComboBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceNumericUpDown);
            this.Controls.Add(unitsInStockLabel);
            this.Controls.Add(this.unitsInStockNumericUpDown);
            this.Controls.Add(unitsOnOrderLabel);
            this.Controls.Add(this.unitsOnOrderNumericUpDown);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.reorderLevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInStockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsOnOrderNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.BindingSource productBindingSource;
        internal System.Windows.Forms.ComboBox categoryIDComboBox;
        internal System.Windows.Forms.CheckBox discontinuedCheckBox;
        internal System.Windows.Forms.Label productIDLabel1;
        internal System.Windows.Forms.TextBox productNameTextBox;
        internal System.Windows.Forms.TextBox quantityPerUnitTextBox;
        internal System.Windows.Forms.NumericUpDown reorderLevelNumericUpDown;
        internal System.Windows.Forms.ComboBox supplierIDComboBox;
        internal System.Windows.Forms.NumericUpDown unitPriceNumericUpDown;
        internal System.Windows.Forms.NumericUpDown unitsInStockNumericUpDown;
        internal System.Windows.Forms.NumericUpDown unitsOnOrderNumericUpDown;
    }
}