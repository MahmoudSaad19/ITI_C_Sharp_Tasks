namespace ProductSearchForms
{
    partial class Form3
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
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label categoryLabel;
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unitsInStockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ckBoxDiscontinued = new System.Windows.Forms.CheckBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.ckBoxUnitsInStock = new System.Windows.Forms.CheckBox();
            this.ckBoxUnitPrice = new System.Windows.Forms.CheckBox();
            this.ckBoxCategory = new System.Windows.Forms.CheckBox();
            this.ckBoxSupplier = new System.Windows.Forms.CheckBox();
            this.ckBoxProductName = new System.Windows.Forms.CheckBox();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.comboBoxunitsInStock = new System.Windows.Forms.ComboBox();
            this.comboBoxUnitPrice = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            discontinuedLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInStockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(28, 67);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(72, 13);
            discontinuedLabel.TabIndex = 1;
            discontinuedLabel.Text = "Discontinued:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(28, 95);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 5;
            productNameLabel.Text = "Product Name:";
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.Location = new System.Drawing.Point(28, 167);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(0, 13);
            reorderLevelLabel.TabIndex = 9;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(28, 118);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 11;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(28, 144);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(77, 13);
            unitsInStockLabel.TabIndex = 13;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(422, 33);
            label1.TabIndex = 17;
            label1.Text = "Product Advanced Search ";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Location = new System.Drawing.Point(41, 207);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(48, 13);
            supplierLabel.TabIndex = 18;
            supplierLabel.Text = "Supplier:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(41, 183);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 20;
            categoryLabel.Text = "Category:";
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(124, 62);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(120, 24);
            this.discontinuedCheckBox.TabIndex = 2;
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(124, 92);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.productNameTextBox.TabIndex = 6;
            // 
            // unitPriceNumericUpDown
            // 
            this.unitPriceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitPrice", true));
            this.unitPriceNumericUpDown.Location = new System.Drawing.Point(175, 119);
            this.unitPriceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.unitPriceNumericUpDown.Name = "unitPriceNumericUpDown";
            this.unitPriceNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.unitPriceNumericUpDown.TabIndex = 12;
            // 
            // unitsInStockNumericUpDown
            // 
            this.unitsInStockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitsInStock", true));
            this.unitsInStockNumericUpDown.Location = new System.Drawing.Point(175, 145);
            this.unitsInStockNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.unitsInStockNumericUpDown.Name = "unitsInStockNumericUpDown";
            this.unitsInStockNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.unitsInStockNumericUpDown.TabIndex = 14;
            // 
            // ckBoxDiscontinued
            // 
            this.ckBoxDiscontinued.AutoSize = true;
            this.ckBoxDiscontinued.Location = new System.Drawing.Point(279, 66);
            this.ckBoxDiscontinued.Name = "ckBoxDiscontinued";
            this.ckBoxDiscontinued.Size = new System.Drawing.Size(94, 17);
            this.ckBoxDiscontinued.TabIndex = 18;
            this.ckBoxDiscontinued.Text = "Add to Search";
            this.ckBoxDiscontinued.UseVisualStyleBackColor = true;
            this.ckBoxDiscontinued.CheckedChanged += new System.EventHandler(this.ckBoxDiscontinued_CheckedChanged);
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Supplier", true));
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(123, 207);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(121, 21);
            this.supplierComboBox.TabIndex = 19;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Category", true));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(123, 180);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 21;
            // 
            // ckBoxUnitsInStock
            // 
            this.ckBoxUnitsInStock.AutoSize = true;
            this.ckBoxUnitsInStock.Location = new System.Drawing.Point(279, 145);
            this.ckBoxUnitsInStock.Name = "ckBoxUnitsInStock";
            this.ckBoxUnitsInStock.Size = new System.Drawing.Size(94, 17);
            this.ckBoxUnitsInStock.TabIndex = 22;
            this.ckBoxUnitsInStock.Text = "Add to Search";
            this.ckBoxUnitsInStock.UseVisualStyleBackColor = true;
            this.ckBoxUnitsInStock.CheckedChanged += new System.EventHandler(this.ckBoxUnitsInStock_CheckedChanged);
            // 
            // ckBoxUnitPrice
            // 
            this.ckBoxUnitPrice.AutoSize = true;
            this.ckBoxUnitPrice.Location = new System.Drawing.Point(279, 119);
            this.ckBoxUnitPrice.Name = "ckBoxUnitPrice";
            this.ckBoxUnitPrice.Size = new System.Drawing.Size(94, 17);
            this.ckBoxUnitPrice.TabIndex = 23;
            this.ckBoxUnitPrice.Text = "Add to Search";
            this.ckBoxUnitPrice.UseVisualStyleBackColor = true;
            this.ckBoxUnitPrice.CheckedChanged += new System.EventHandler(this.ckBoxUnitPrice_CheckedChanged);
            // 
            // ckBoxCategory
            // 
            this.ckBoxCategory.AutoSize = true;
            this.ckBoxCategory.Location = new System.Drawing.Point(279, 182);
            this.ckBoxCategory.Name = "ckBoxCategory";
            this.ckBoxCategory.Size = new System.Drawing.Size(94, 17);
            this.ckBoxCategory.TabIndex = 25;
            this.ckBoxCategory.Text = "Add to Search";
            this.ckBoxCategory.UseVisualStyleBackColor = true;
            // 
            // ckBoxSupplier
            // 
            this.ckBoxSupplier.AutoSize = true;
            this.ckBoxSupplier.Location = new System.Drawing.Point(279, 211);
            this.ckBoxSupplier.Name = "ckBoxSupplier";
            this.ckBoxSupplier.Size = new System.Drawing.Size(94, 17);
            this.ckBoxSupplier.TabIndex = 26;
            this.ckBoxSupplier.Text = "Add to Search";
            this.ckBoxSupplier.UseVisualStyleBackColor = true;
            // 
            // ckBoxProductName
            // 
            this.ckBoxProductName.AutoSize = true;
            this.ckBoxProductName.Location = new System.Drawing.Point(279, 94);
            this.ckBoxProductName.Name = "ckBoxProductName";
            this.ckBoxProductName.Size = new System.Drawing.Size(94, 17);
            this.ckBoxProductName.TabIndex = 27;
            this.ckBoxProductName.Text = "Add to Search";
            this.ckBoxProductName.UseVisualStyleBackColor = true;
            this.ckBoxProductName.CheckedChanged += new System.EventHandler(this.ckBoxProductName_CheckedChanged);
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(169, 243);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(75, 28);
            this.btnAdvSearch.TabIndex = 28;
            this.btnAdvSearch.Text = "Search";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // comboBoxunitsInStock
            // 
            this.comboBoxunitsInStock.FormattingEnabled = true;
            this.comboBoxunitsInStock.Location = new System.Drawing.Point(123, 143);
            this.comboBoxunitsInStock.Name = "comboBoxunitsInStock";
            this.comboBoxunitsInStock.Size = new System.Drawing.Size(46, 21);
            this.comboBoxunitsInStock.TabIndex = 29;
            // 
            // comboBoxUnitPrice
            // 
            this.comboBoxUnitPrice.FormattingEnabled = true;
            this.comboBoxUnitPrice.Location = new System.Drawing.Point(123, 119);
            this.comboBoxUnitPrice.Name = "comboBoxUnitPrice";
            this.comboBoxUnitPrice.Size = new System.Drawing.Size(46, 21);
            this.comboBoxUnitPrice.TabIndex = 30;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ProductSearchForms.Product);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 286);
            this.Controls.Add(this.comboBoxUnitPrice);
            this.Controls.Add(this.comboBoxunitsInStock);
            this.Controls.Add(this.btnAdvSearch);
            this.Controls.Add(this.ckBoxProductName);
            this.Controls.Add(this.ckBoxSupplier);
            this.Controls.Add(this.ckBoxCategory);
            this.Controls.Add(this.ckBoxUnitPrice);
            this.Controls.Add(this.ckBoxUnitsInStock);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(supplierLabel);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.ckBoxDiscontinued);
            this.Controls.Add(label1);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.discontinuedCheckBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(reorderLevelLabel);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceNumericUpDown);
            this.Controls.Add(unitsInStockLabel);
            this.Controls.Add(this.unitsInStockNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInStockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.CheckBox discontinuedCheckBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.NumericUpDown unitPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown unitsInStockNumericUpDown;
        private System.Windows.Forms.CheckBox ckBoxDiscontinued;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.CheckBox ckBoxUnitsInStock;
        private System.Windows.Forms.CheckBox ckBoxUnitPrice;
        private System.Windows.Forms.CheckBox ckBoxCategory;
        private System.Windows.Forms.CheckBox ckBoxSupplier;
        private System.Windows.Forms.CheckBox ckBoxProductName;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.ComboBox comboBoxunitsInStock;
        private System.Windows.Forms.ComboBox comboBoxUnitPrice;
    }
}