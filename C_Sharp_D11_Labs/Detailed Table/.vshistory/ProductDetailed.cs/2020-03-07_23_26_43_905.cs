using System;
using System.Diagnostics;
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
            productIDLabel1.Text = (ProductsManager.getLastProductID() + 1).ToString();
            ProductsManager.InsertProduct(productNameTextBox.Text);
        }
    }
}
