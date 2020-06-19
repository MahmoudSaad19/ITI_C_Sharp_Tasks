using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Hotel_Manager
{
    public partial class Kitchen : MetroForm
    {
        string cleaning, towel, surprise, queryString;
        int breakfast, lunch, dinner, foodBill;
        public Int32 primaryID;
        double totalBill;
        bool supply_status = false;

        SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
        SqlCommand query;
        //SqlDataReader reader;
        
        public Kitchen()
        {
            InitializeComponent();
            contextFrontEndManager = new DataBaseFrontEndContextManager();
        }

        DataBaseFrontEndContextManager contextFrontEndManager;

        private void kitchen_Load(object sender, EventArgs e)
        {
            contextFrontEndManager.reservations.Load();
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void LoadForDataGridView()
        {
            try
            {
                overviewDataGridView.DataSource =
                     contextFrontEndManager.reservations.Where(r => r.check_in == true && r.supply_status == false).Select(r => new { Id = r.Id, first_name = r.first_name, last_name = r.last_name, phone_number = r.phone_number, room_type = r.room_type, room_floor = r.room_floor, room_number = r.room_number, break_fast = r.break_fast, lunch = r.lunch, dinner = r.dinner, cleaning = r.cleaning, towel = r.towel, s_surprise = r.s_surprise, supply_status = r.supply_status, food_bill = r.food_bill }).ToList();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            }         
        }

        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }

        private void listBoxFromDataBase()
        {
            try
            {
                queueListBox.Items.Clear();
                var data = contextFrontEndManager.reservations.Where(r => r.check_in == true && r.supply_status == false).ToList();
                foreach (var i in data)
                    queueListBox.Items.Add($"{i.Id} | {i.first_name} | {i.last_name} | {i.phone_number}");      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }

        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                resetEntries(this);
                string getQuerystring = queueListBox.Text.Substring(0, 4).Replace(" ", string.Empty);
                int selectedID = int.Parse(getQuerystring);
                

                var res = contextFrontEndManager.reservations.Find(selectedID);
            try
            {
                string ID = res.Id.ToString();
                string first_name = res.first_name.ToString();
                string last_name = res.last_name.ToString();
                string phone_number = res.phone_number.ToString();
                string foodBillD = res.food_bill.ToString();
                string total_bill = res.total_bill.ToString().Replace(" ", string.Empty);
                string room_type = res.room_type.ToString();
                string room_floor = res.room_floor.ToString();
                string room_number = res.room_number.ToString();
                string _cleaning = res.cleaning.ToString();
                string _towel = res.towel.ToString();
                string _surprise = res.s_surprise.ToString();

                if (_cleaning == "True")
                {
                    cleaning = "1";
                    cleaningCheckBox.Checked = true;
                }
                else { cleaning = "0"; }

                if (_towel == "True")
                {
                    towel = "1";
                    towelCheckBox.Checked = true;
                }
                else { towel = "0"; }
                if (_surprise == "True")
                {
                    surprise = "1";
                    surpriseCheckBox.Checked = true;
                }
                else
                {
                    surprise = "0";
                }

                string supply_status = res.supply_status.ToString();
                string food_billD = res.food_bill.ToString();
                string _breakfast = res.break_fast.ToString();
                string _lunch = res.lunch.ToString();
                string _dinner = res.dinner.ToString();

                double Num;
                bool isNum = double.TryParse(_lunch, out Num);
                if (isNum)
                {
                    lunch = Int32.Parse(_lunch);
                    lunchTextBox.Text = Convert.ToString(lunch);
                }
                else
                {
                    lunch = 0;
                    lunchTextBox.Text = "NONE";
                }
                isNum = double.TryParse(_breakfast, out Num);
                if (isNum)
                {
                    breakfast = Int32.Parse(_breakfast);
                    breakfastTextBox.Text = Convert.ToString(breakfast);
                }
                else
                {
                    breakfast = 0;
                    breakfastTextBox.Text = "NONE";
                }
                isNum = double.TryParse(_dinner, out Num);
                if (isNum)
                {
                    dinner = Int32.Parse(_dinner);
                    dinnerTextBox.Text = Convert.ToString(dinner);
                }
                else
                {
                    dinner = 0;
                    dinnerTextBox.Text = "NONE";
                }

                if (supply_status == "True")
                {
                    supplyCheckBox.Checked = true;
                }
                else
                {
                    supplyCheckBox.Checked = false;
                }

                firstNameTextBox.Text = first_name;
                lastNameTextBox.Text = last_name;
                phoneNTextBox.Text = phone_number;
                roomTypeTextBox.Text = room_type;
                floorNTextBox.Text = room_floor;
                roomNTextBox.Text = room_number;
                totalBill = Convert.ToDouble(total_bill);
                foodBill = Convert.ToInt32(foodBillD);
                totalBill -= foodBill;
                primaryID = Convert.ToInt32(ID);


            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
            
        }

        private void foodSelectionButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            food_menu.needPanel.Visible = false;

            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            int bfast= 0, Lnch= 0, di_ner = 0;
            if (breakfast > 0)
            {
                bfast = 7 * breakfast;
            } if (lunch > 0)
            {
                Lnch = 15 * lunch;
            } if (dinner > 0)
            {
                di_ner = 15 * dinner;
            }
            foodBill += (bfast + Lnch + di_ner);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                if (primaryID > 1000)
                {
                    queryString = "update reservation set total_bill='" + totalBill + foodBill + "', break_fast='" + breakfast + "', lunch= '" + lunch + "', dinner='" + dinner + "', supply_status='" + supply_status + "',cleaning='" + Convert.ToInt32(cleaning) + "',towel='" + Convert.ToInt32(towel) + "',s_surprise='" + Convert.ToInt32(surprise) + "',food_bill='" + foodBill + "' WHERE Id = '" + primaryID + "';";

                    query = new SqlCommand(queryString, connection);
                    try
                    {
                        connection.Open();
                        string userID = Convert.ToString(primaryID);
                        //reader = query.ExecuteReader();

                        MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                        " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        connection.Close();
                        listBoxFromDataBase();
                        LoadForDataGridView();
                        resetEntries(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cleaningCheckBox.Checked = false;
            cleaningCheckBox.Text = "Cleaned";
            towelCheckBox.Checked = false;
            towelCheckBox.Text = "Toweled";
            surpriseCheckBox.Checked = false;
            surpriseCheckBox.Text = "Surprised";
            supply_status = true;
        }
        private void kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
