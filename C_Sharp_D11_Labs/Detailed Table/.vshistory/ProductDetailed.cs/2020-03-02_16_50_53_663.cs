﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ProductDetailed_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = products;

            productBindingSource.AddingNew += (Sender, E) =>
             E.NewObject = new Product() { State = EntityState.Added };
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
            if (int.TryParse(row["ProductID"]?.ToString() ?? "-1", out int TempInt))
                product.ProductID = TempInt;
            productBindingNavigator.PositionItem.Text
        }

        private void discontinuedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
