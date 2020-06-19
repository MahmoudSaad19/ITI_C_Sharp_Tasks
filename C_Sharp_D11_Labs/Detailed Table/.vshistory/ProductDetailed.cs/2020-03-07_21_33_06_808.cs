using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Detailed_Table
{
    public partial class ProductDetailed : Form
    {
        public ProductDetailed()
        {
            InitializeComponent();
        }

        ProductsList products = ProductsManager.SelectAllProducts();
        DBManager dBManager = new DBManager();

        private void ProductDetailed_Load(object sender , EventArgs e)
        {
            productBindingSource.DataSource = products;

            productBindingSource.AddingNew += (Sender , E) =>
             E.NewObject = new Product() { State = EntityState.Added };
        }

        private void productBindingNavigatorSaveItem_Click(object sender , EventArgs e)
        {
            productBindingSource.EndEdit();

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
            ProductsManager.InsertProduct(productNameTextBox.Text);
        }
    }
}
