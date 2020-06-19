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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label unitsOnOrderLabel;
            System.Windows.Forms.Label label1;
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.productIDLabel1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unitPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unitsInStockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unitsOnOrderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            discontinuedLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            unitsOnOrderLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reorderLevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInStockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsOnOrderNumericUpDown)).BeginInit();
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
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(28, 89);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 3;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(28, 118);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 5;
            productNameLabel.Text = "Product Name:";
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.Location = new System.Drawing.Point(28, 144);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(90, 13);
            quantityPerUnitLabel.TabIndex = 7;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.Location = new System.Drawing.Point(28, 167);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(77, 13);
            reorderLevelLabel.TabIndex = 9;
            reorderLevelLabel.Text = "Reorder Level:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(28, 193);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 11;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(28, 219);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(77, 13);
            unitsInStockLabel.TabIndex = 13;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // unitsOnOrderLabel
            // 
            unitsOnOrderLabel.AutoSize = true;
            unitsOnOrderLabel.Location = new System.Drawing.Point(28, 245);
            unitsOnOrderLabel.Name = "unitsOnOrderLabel";
            unitsOnOrderLabel.Size = new System.Drawing.Size(80, 13);
            unitsOnOrderLabel.TabIndex = 15;
            unitsOnOrderLabel.Text = "Units On Order:";
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(124, 62);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(120, 24);
            this.discontinuedCheckBox.TabIndex = 2;
            this.discontinuedCheckBox.Text = "checkBox1";
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            //
            // productIDLabel1
            // 
            this.productIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDLabel1.Location = new System.Drawing.Point(124, 89);
            this.productIDLabel1.Name = "productIDLabel1";
            this.productIDLabel1.Size = new System.Drawing.Size(120, 23);
            this.productIDLabel1.TabIndex = 4;
            this.productIDLabel1.Text = "label1";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(124, 115);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.productNameTextBox.TabIndex = 6;
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "QuantityPerUnit", true));
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(124, 141);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(120, 20);
            this.quantityPerUnitTextBox.TabIndex = 8;
            // 
            // reorderLevelNumericUpDown
            // 
            this.reorderLevelNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ReorderLevel", true));
            this.reorderLevelNumericUpDown.Location = new System.Drawing.Point(124, 167);
            this.reorderLevelNumericUpDown.Name = "reorderLevelNumericUpDown";
            this.reorderLevelNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.reorderLevelNumericUpDown.TabIndex = 10;
            // 
            // unitPriceNumericUpDown
            // 
            this.unitPriceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitPrice", true));
            this.unitPriceNumericUpDown.Location = new System.Drawing.Point(124, 193);
            this.unitPriceNumericUpDown.Name = "unitPriceNumericUpDown";
            this.unitPriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.unitPriceNumericUpDown.TabIndex = 12;
            // 
            // unitsInStockNumericUpDown
            // 
            this.unitsInStockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitsInStock", true));
            this.unitsInStockNumericUpDown.Location = new System.Drawing.Point(124, 219);
            this.unitsInStockNumericUpDown.Name = "unitsInStockNumericUpDown";
            this.unitsInStockNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.unitsInStockNumericUpDown.TabIndex = 14;
            // 
            // unitsOnOrderNumericUpDown
            // 
            this.unitsOnOrderNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "UnitsOnOrder", true));
            this.unitsOnOrderNumericUpDown.Location = new System.Drawing.Point(124, 245);
            this.unitsOnOrderNumericUpDown.Name = "unitsOnOrderNumericUpDown";
            this.unitsOnOrderNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.unitsOnOrderNumericUpDown.TabIndex = 16;
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ProductSearchForms.Product);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(label1);
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
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceNumericUpDown);
            this.Controls.Add(unitsInStockLabel);
            this.Controls.Add(this.unitsInStockNumericUpDown);
            this.Controls.Add(unitsOnOrderLabel);
            this.Controls.Add(this.unitsOnOrderNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.reorderLevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInStockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsOnOrderNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.CheckBox discontinuedCheckBox;
        private System.Windows.Forms.Label productIDLabel1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox quantityPerUnitTextBox;
        private System.Windows.Forms.NumericUpDown reorderLevelNumericUpDown;
        private System.Windows.Forms.NumericUpDown unitPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown unitsInStockNumericUpDown;
        private System.Windows.Forms.NumericUpDown unitsOnOrderNumericUpDown;
    }
}