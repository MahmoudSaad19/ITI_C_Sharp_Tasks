using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Hotel_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Manager
{
    public partial class Kitchen : MetroForm
    {
        string cleaning, towel, surprise;
        int breakfast, lunch, dinner, foodBill;
        public Int32 primaryID;
        double totalBill;
        bool supply_status = false;
        
        public Kitchen()
        {
            InitializeComponent();
            contextFrontEndManager = new FRONTEND_RESERVATIONContext();
        }

        FRONTEND_RESERVATIONContext contextFrontEndManager;

        private void kitchen_Load(object sender, EventArgs e)
        {
            contextFrontEndManager.Reservation.Load();
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void LoadForDataGridView()
        {
            try
            {
                overviewDataGridView.DataSource =
                     contextFrontEndManager.Reservation.Where(r => r.CheckIn == true && r.SupplyStatus == false).Select(r => new { Id = r.Id, first_name = r.FirstName, last_name = r.LastName, phone_number = r.PhoneNumber, room_type = r.RoomType, room_floor = r.RoomFloor, room_number = r.RoomNumber, break_fast = r.BreakFast, lunch = r.Lunch, dinner = r.Dinner, cleaning = r.Cleaning, towel = r.Towel, s_surprise = r.SSurprise, supply_status = r.SupplyStatus, food_bill = r.FoodBill }).ToList();
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
                var data = contextFrontEndManager.Reservation.Where(r => r.CheckIn == true && r.SupplyStatus == false).ToList();
                foreach (var i in data)
                    queueListBox.Items.Add($"{i.Id} | {i.FirstName} | {i.LastName} | {i.PhoneNumber}");      
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

            var res = contextFrontEndManager.Reservation.Find(selectedID);
            //res is the result Set 
            try
            {
                string ID = res.Id.ToString();
                string first_name = res.FirstName.ToString();
                string last_name = res.LastName.ToString();
                string phone_number = res.PhoneNumber.ToString();
                string foodBillD = res.FoodBill.ToString();
                string total_bill = res.TotalBill.ToString().Replace(" ", string.Empty);
                string room_type = res.RoomType.ToString();
                string room_floor = res.RoomFloor.ToString();
                string room_number = res.RoomNumber.ToString();
                string _cleaning = res.Cleaning.ToString();
                string _towel = res.Towel.ToString();
                string _surprise = res.SSurprise.ToString();

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

                string supply_status = res.SupplyStatus.ToString();
                string food_billD = res.FoodBill.ToString();
                string _breakfast = res.BreakFast.ToString();
                string _lunch = res.Lunch.ToString();
                string _dinner = res.Dinner.ToString();

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
                primaryID = int.TryParse(ID, out int id) ? id : 0;
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
            if (primaryID > 1000)
            {
                var res = contextFrontEndManager.Reservation.Where(r => r.Id == primaryID);
                foreach (var i in res)
                {
                    i.TotalBill = totalBill + foodBill;
                    i.BreakFast = breakfast;
                    i.Lunch = lunch;
                    i.Dinner = dinner;
                    i.SupplyStatus = supply_status;
                    i.Cleaning = Convert.ToInt32(cleaning) == 0 ? false : true;
                    i.Towel = Convert.ToInt32(towel) == 0 ? false : true;
                    i.SSurprise = Convert.ToInt32(surprise) == 0 ? false : true;
                    i.FoodBill = foodBill;
                }

                try
                {
                    string userID = Convert.ToString(primaryID);
                    contextFrontEndManager.SaveChanges();

                    MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                    " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

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
