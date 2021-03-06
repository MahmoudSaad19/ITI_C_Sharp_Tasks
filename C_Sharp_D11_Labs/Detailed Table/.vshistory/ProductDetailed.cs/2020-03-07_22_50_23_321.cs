﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using BLL;

namespace Detailed_Table
{
    public partial class ProductDetailed : Form
    {
        public ProductDetailed()
        {
            InitializeComponent();
        }

        ProductsList products = ProductsManager.SelectAllProducts();

        private void ProductDetailed_Load(object sender , EventArgs e)
        {
            productBindingSource.DataSource = products;

            //productBindingSource.AddingNew += (Sender , E) =>
            // E.NewObject = new Product() { State = EntityState.Added };
        }

        private void productBindingNavigatorSaveItem_Click(object sender , EventArgs e)
        {
            productBindingSource.EndEdit();
            foreach (var item in products)
            {
                Trace.WriteLine($"{item.ProductID} ) {item.State}");
            }
            //dBManager.ExecuteNonQuery2("UPDATE [Products] SET [ProductName] = " + productNameTextBox.Text + " ,[SupplierID] = " + supplierIDLabel1.Text + " ,[CategoryID] = " + categoryIDLabel1.Text + " ,[QuantityPerUnit] = " + quantityPerUnitTextBox.Text + " ,[UnitPrice] = " + unitPriceNumericUpDown.Value + " ,[UnitsInStock] = " + unitsInStockNumericUpDown.Value + " ,[UnitsOnOrder] = " + unitsOnOrderNumericUpDown.Value + " ,[ReorderLevel] = " + reorderLevelNumericUpDown.Value + " ,[Discontinued] = " + discontinuedCheckBox.Checked + "WHERE [ProductID] = " + productIDLabel1.Text);
        }

        private void btnDelete_Click(object sender , EventArgs e)
        {
            int ProductID = int.TryParse(productIDLabel1.Text, out int p) ? p : 0;
            ProductsManager.DeleteProductByProductID(ProductID);
            productBindingSource.Remove(productBindingSource.Current);
            productBindingSource.EndEdit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ProductsManager.InsertProduct(productNameTextBox.Text
               //int.TryParse(supplierIDLabel1.Text, out int s) ? s : 1,
               //int.TryParse(categoryIDLabel1.Text, out int c) ? c : 1,

               );
            productIDLabel1.Text = (products.Last().ProductID +1 ).ToString();
        }
    }
}
