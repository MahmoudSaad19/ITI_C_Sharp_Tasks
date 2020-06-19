﻿using MetroFramework.Forms;
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
using System.Configuration;
using Twilio;
using System.Data.Entity;

namespace Hotel_Manager
{
    public partial class Frontend : MetroForm
    {
        string AccountSid = "ACcb86dacb791bef978628a2e16b1f7a24";
        string AuthToken = "3f344a07336d2e0ac5e467f72a1e650d";
        string RecvPhoneNumber = "";
        DataBaseFrontEndContextManager datacontextManager;
        public Frontend()
        {
            InitializeComponent();
            CenterToScreen();
            entryDatePicker.MinDate = DateTime.Today;
            depDatePicker.MinDate = DateTime.Today.AddDays(1);
            datacontextManager = new DataBaseFrontEndContextManager();
            datacontextManager.reservations.Load();

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            this.roomOccupiedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomOccupiedListBox.DrawItem += new DrawItemEventHandler(this.roomOccupiedListBox_DrawItem);
            this.roomReservedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomReservedListBox.DrawItem += new DrawItemEventHandler(this.roomReservedListBox_DrawItem);
        }

        private void roomOccupiedListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.roomOccupiedListBox.IntegralHeight = false;
            this.roomOccupiedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomOccupiedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }
        
        private void roomReservedListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.roomReservedListBox.IntegralHeight = false;
            this.roomReservedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomReservedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);
        }

        private string getval;

        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;

        private void MainTab_Load(object sender, EventArgs e)
        {
            foodSupplyCheckBox.Enabled = false;           
        }

        public void foodMenuButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakfastCheckBox.Checked = true;
                    food_menu.breakfastQTY.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.lunchCheckBox.Checked = true;

                    food_menu.lunchQTY.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.dinnerCheckBox.Checked = true;
                    food_menu.dinnerQTY.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.cleaningCheckBox.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.towelsCheckBox.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.surpriseCheckBox.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }
     
        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomTypeComboBox.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                floorComboBox.SelectedItem = "4";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                floorComboBox.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(qtGuestComboBox.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = qtGuestComboBox.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
            entryDatePicker.MinDate = new DateTime(2014, 4, 1);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Format = DateTimePickerFormat.Custom;

            depDatePicker.MinDate = new DateTime(2014, 4, 1);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Format = DateTimePickerFormat.Custom;

            submitButton.Visible = false;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }
        
        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            {
                foodSupplyCheckBox.Checked = true;
            }
            updateButton.Enabled = true;

            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.phoneNComboBox.Text = FCnumber;
                finalizebil.monthComboBox.SelectedItem = FcardExpOne;
                finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
                finalizebil.cvcComboBox.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;

            if (!editClicked)
            {
                submitButton.Visible = true;
            }
        }

        private void SendSMS(int secondUserID)
        {
            //creating an instance of twilio rest
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            string name = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            string end_num = paymentCardNumber.Substring(paymentCardNumber.Length - Math.Min(4, paymentCardNumber.Length));

            if (smsCheckBox.Checked)
            {
                //building message for twilio
                string buildMesage = "Hello " + name + "! Your unique ID# " + secondUserID + " Total bill of $" + finalizedTotalAmount + " is charged on your card # ending-" + end_num;
                //creating message 
                var message = twilio.SendMessage("+12034562736", RecvPhoneNumber, buildMesage, "");
                //sending message
                Console.WriteLine(message.Sid);
                smsCheckBox.Text = "SMS Sent";
            }
        }
      
        private void submitButton_Click(object sender, EventArgs e)
        {
            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            Int32 getIDBack = 0;
            int getID = datacontextManager.reservations.Select(r => r.Id).ToList().LastOrDefault() + 1;
            reservation res = new reservation()
            {
                Id = getID,
                first_name = firstNameTextBox.Text,
                last_name = lastNameTextBox.Text,
                birth_day = birthday,
                gender = genderComboBox.SelectedItem?.ToString() ?? string.Empty,
                phone_number = phoneNumberTextBox.Text,
                email_address = emailTextBox.Text,
                number_guest = qtGuestComboBox.SelectedIndex + 1,
                street_address = addLabel.Text,
                apt_suite = aptTextBox.Text,
                city = cityTextBox.Text,
                state = stateComboBox.SelectedItem?.ToString() ?? string.Empty,
                zip_code = zipComboBox.Text,
                room_type = roomTypeComboBox.SelectedItem?.ToString() ?? string.Empty,
                room_floor = floorComboBox.SelectedItem?.ToString() ?? string.Empty,
                room_number = roomNComboBox.SelectedItem?.ToString() ?? string.Empty,
                total_bill = finalizedTotalAmount,
                payment_type = paymentType,
                card_type = CardType,
                card_number = paymentCardNumber,
                card_exp = MM_YY_Of_Card,
                card_cvc = CVC_Of_Card,
                arrival_time = entryDatePicker.Value,
                leaving_time = depDatePicker.Value,
                check_in = checkin == 1 ? true : false,
                break_fast = breakfast,
                lunch = lunch,
                dinner = dinner,
                supply_status = foodStatus == 1 ? true : false,
                cleaning = cleaning?.ToLower()  == "true" ? true : false,
                towel = towel?.ToLower() == "true" ? true : false,
                s_surprise = surprise?.ToLower() == "false" ? false : true,
                food_bill = foodBill,                
            };
            datacontextManager.reservations.Add(res);
            try
            {   
                string userID = Convert.ToString(getIDBack);
                SendSMS(getIDBack);
                datacontextManager.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
                    "Provide this unique ID to the customer." + "\n\n" +
                "USER UNIQUE ID: " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            submitButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
            reset_frontend();
        }

        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }

        public void ClearAllComboBox(Control controls){
            foreach(Control control in controls.Controls){
                if (control == roomTypeComboBox)
                {
                    continue;
                }
                else if(control is ComboBox){
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren) {
                    ClearAllComboBox(control);
                }
            }
        }

        private void reset_frontend()
        {
            try
            {

                resEditButton.Items.Clear();
                checkinCheckBox.Checked = false;
                foodSupplyCheckBox.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (primartyID > 1000)
            {
                var data = datacontextManager.reservations.Find(primartyID);
                datacontextManager.reservations.Remove(data);
                try
                {
                    datacontextManager.SaveChanges();

                    MetroFramework.MetroMessageBox.Show(this, "Reservation For the UNIQUE USER ID of: " + "\n\n" +
                " " + primartyID + " is DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist." + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            var res = datacontextManager.reservations.Find(primartyID);
            res.first_name = firstNameTextBox.Text;
            res.last_name = lastNameTextBox.Text;
            res.birth_day = birthday;
            res.gender = genderComboBox.SelectedItem?.ToString() ?? string.Empty;
            res.phone_number = phoneNumberTextBox.Text;
            res.email_address = emailTextBox.Text;
            res.number_guest = qtGuestComboBox.SelectedIndex + 1;
            res.street_address = addLabel.Text;
            res.apt_suite = aptTextBox.Text;
            res.city = cityTextBox.Text;
            res.state = stateComboBox.SelectedItem?.ToString() ?? string.Empty;
            res.zip_code = zipComboBox.Text;
            res.room_type = roomTypeComboBox.SelectedItem?.ToString() ?? string.Empty;
            res.room_floor = floorComboBox.SelectedItem?.ToString() ?? string.Empty;
            res.room_number = roomNComboBox.SelectedItem?.ToString() ?? string.Empty;
            res.total_bill = finalizedTotalAmount;
            res.payment_type = paymentType;
            res.card_type = CardType;
            res.card_number = paymentCardNumber;
            res.card_exp = MM_YY_Of_Card;
            res.card_cvc = CVC_Of_Card;
            res.arrival_time = entryDatePicker.Value;
            res.leaving_time = depDatePicker.Value;
            res.check_in = checkin == 1 ? true : false;
            res.break_fast = breakfast;
            res.lunch = lunch;
            res.dinner = dinner;
            res.supply_status = foodStatus == 1 ? true : false;
            res.cleaning = cleaning?.ToLower() == "true" ? true : false;
            res.towel = towel?.ToLower() == "true" ? true : false;
            res.s_surprise = surprise?.ToLower() == "false" ? false : true;
            res.food_bill = foodBill;
            try
            {
                string userID = Convert.ToString(primartyID);
                datacontextManager.SaveChanges();

                MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                SendSMS(primartyID);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();

            reset_frontend();
            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinCheckBox.Checked)
            {
                checkinCheckBox.Text = "Checked in";
                checkin = 1;
            }
            else
            {
                checkin = 0;
                checkinCheckBox.Text = "Check in ?";
            }
        }

        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            getChecked();
            string getQuerystring = resEditButton.Text.Substring(0, 4).Replace(" ", string.Empty);
            int selectedID = int.TryParse(getQuerystring, out int id) ? id : 0;
            var res = datacontextManager.reservations.Find(selectedID);

            try
            {
                taskFinder = true;
                string ID = res.Id.ToString();
                string first_name = res.first_name.ToString();
                string last_name = res.last_name.ToString();
                string birth_day = res.birth_day.ToString();
                string gender = res.gender.ToString();
                string phone_number = res.phone_number.ToString();
                string email_address = res.email_address.ToString();
                string number_guest = res.number_guest.ToString();
                string street_address = res.street_address.ToString();
                string apt_suite = res.apt_suite.ToString();
                string city = res.city.ToString();
                string state = res.state.ToString();
                string zip_code = res.zip_code.ToString();

                string room_type = res.room_type.ToString();
                string room_floor = res.room_floor.ToString();
                string room_number = res.room_number.ToString();

                string payment_type = res.payment_type.ToString();
                string card_number = res.card_number.ToString();
                string card_exp = res.card_exp.ToString();
                string card_cvc = res.card_cvc.ToString();

                string _cleaning = res.cleaning.ToString();
                string _towel = res.towel.ToString();
                string _surprise = res.s_surprise.ToString();
                if (_cleaning == "True")
                {
                    cleaning = "1";
                }
                else { cleaning = "0"; }

                if (_towel == "True")
                {
                    towel = "1";
                }
                else { towel = "0"; }
                if (_surprise == "True")
                {
                    surprise = "1";
                }
                else
                {
                    surprise = "0";
                }
                roomNComboBox.Items.Add(room_number);
                roomNComboBox.SelectedItem = room_number;

                FPayment = payment_type; FCnumber = card_number;
                FCardCVC = card_cvc; FcardExpOne = card_exp.Substring(0, card_exp.IndexOf('/'));
                FcardExpTwo = card_exp.Substring(card_exp.Length - Math.Min(2, card_exp.Length));
                string check_in = res.check_in.ToString();

                string supply_status = res.supply_status.ToString();
                string food_billD = res.food_bill.ToString();

                string arrival_date = Convert.ToDateTime(res.arrival_time).ToString("MM-dd-yyyy").Replace(" ", string.Empty);
                entryDatePicker.Value = Convert.ToDateTime(arrival_date);

                string leaving_date = Convert.ToDateTime(res.leaving_time).ToString("MM-dd-yyyy").Replace(" ", string.Empty);
                depDatePicker.Value = Convert.ToDateTime(leaving_date);
                entryDatePicker.Value.ToShortDateString();
                depDatePicker.Value.ToShortDateString();

                string _breakfast = res.break_fast.ToString();
                string _lunch = res.lunch.ToString();
                string _dinner = res.dinner.ToString();

                double Num;
                bool isNum = double.TryParse(_lunch, out Num);
                if (isNum)
                {
                    lunch = Int32.Parse(_lunch);
                }
                else
                {
                    lunch = 0;
                }
                isNum = double.TryParse(_breakfast, out Num);
                if (isNum)
                {
                    breakfast = Int32.Parse(_breakfast);
                }
                else
                {
                    breakfast = 0;
                }
                isNum = double.TryParse(_dinner, out Num);
                if (isNum)
                {
                    dinner = Int32.Parse(_dinner);
                }
                else
                {
                    dinner = 0;
                }



                foodBill = Convert.ToInt32(food_billD);

                if (supply_status == "True")
                {
                    foodSupplyCheckBox.Checked = true;
                }
                else
                {
                    foodSupplyCheckBox.Checked = false;
                }


                firstNameTextBox.Text = first_name;
                lastNameTextBox.Text = last_name;
                phoneNumberTextBox.Text = phone_number;
                genderComboBox.SelectedItem = gender;

                monthComboBox.SelectedItem = birth_day.Substring(0, birth_day.IndexOf('-'));
                dayComboBox.SelectedItem = birth_day.Substring(birth_day.IndexOf('-') + 1, 2);
                yearTextBox.Text = birth_day.Substring(birth_day.Length - Math.Min(4, birth_day.Length));

                emailTextBox.Text = email_address;
                qtGuestComboBox.SelectedItem = number_guest;
                addLabel.Text = street_address;
                aptTextBox.Text = apt_suite;
                cityTextBox.Text = city;
                stateComboBox.SelectedItem = state;
                zipComboBox.Text = zip_code;
                roomTypeComboBox.SelectedItem = room_type.Replace(" ", string.Empty);
                floorComboBox.SelectedItem = room_floor.Replace(" ", string.Empty);
                roomNComboBox.SelectedItem = room_number.Replace(" ", string.Empty);

                if (check_in == "True")
                {
                    checkinCheckBox.Checked = true;
                }
                else
                {
                    checkinCheckBox.Checked = false;
                }


                primartyID = Convert.ToInt32(ID);

            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }

        private void ComboBoxItemsFromDataBase()
        {
            var res = datacontextManager.reservations.ToList();
            try
            {
                foreach (var i in res)
                {
                    string ID = i.Id.ToString();
                    string first_name = i.first_name.ToString();
                    string last_name = i.last_name.ToString();
                    string phone_number = i.phone_number.ToString();
                    resEditButton.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadForDataGridView()
        {           
            try
            {
                resTotalDataGridView.DataSource = datacontextManager.reservations.ToList();                
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            }
        }

        private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (foodSupplyCheckBox.Checked)
            {
                foodSupplyCheckBox.Text = "Food/Supply: Complete";
                foodStatus = 1;
            }
            else
            {
                foodStatus = 0;
                foodSupplyCheckBox.Text = "Food/Supply status?";
            }
        }

        private void GetOccupiedRoom()
        {
            roomOccupiedListBox.Items.Clear();            
            try
            {
                var res = datacontextManager.reservations.Where(r => r.check_in == true).ToList();
                foreach (var i in res)               
                {
                    string room_number = i.room_number.ToString();
                    string room_type = i.room_type.ToString();
                    string ID = i.Id.ToString();
                    string first_name = i.first_name.ToString();
                    string last_name = i.last_name.ToString();
                    string phone_number = i.phone_number.ToString();
                    string arrival_time = i.arrival_time.ToString();
                    string dep_time = i.leaving_time.ToString();
                    roomOccupiedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + "[" + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) + "]" +
                        " " + phone_number.Replace(" ", string.Empty));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReservedRoom()
        {
            roomReservedListBox.Items.Clear();
            var res = datacontextManager.reservations.Where(r => r.check_in == false).ToList();

            try
            {
                foreach (var i in res)                
                {
                    string room_number = i.room_number.ToString();
                    string room_type = i.room_type.ToString();
                    string ID = i.Id.ToString();
                    string first_name = i.first_name.ToString();
                    string last_name = i.last_name.ToString();
                    string phone_number = i.phone_number.ToString();

                    string arrival_date = Convert.ToDateTime(i.arrival_time).ToString("MM-dd-yyyy");
                    string leaving_date = Convert.ToDateTime(i.leaving_time).ToString("MM-dd-yyy");

                    roomReservedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) +
                        " " + phone_number.Replace(" ", string.Empty) +
                        " " + arrival_date.Replace(" ", string.Empty) +
                        " " + leaving_date.Replace(" ", string.Empty));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void getChecked()
        {
            List<string> TakenRoomList = new List<string>();
            var res = datacontextManager.reservations.Where(r => r.check_in == true).ToList();

            try
            {
                foreach (var i in res)
                {
                    string room_number = i.room_number.ToString();
                    TakenRoomList.Add(room_number.Replace(" ", string.Empty));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (string roomList in TakenRoomList)
            {
                if (roomNComboBox.Items.Contains(roomList))
                {

                    int temp = roomNComboBox.Items.IndexOf(roomList);
                    roomNComboBox.Items.RemoveAt(temp);
                }
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            RecvPhoneNumber = "+1"+phoneNumberTextBox.Text.Replace(" ", string.Empty);
            long getphn = Convert.ToInt64(phoneNumberTextBox.Text);
            string formatString = String.Format("{0:(000)000-0000}", getphn);
            phoneNumberTextBox.Text = formatString;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var res = datacontextManager.reservations.Where(r => r.Id.ToString().Contains(searchTextBox.Text)
            || r.last_name.Contains(searchTextBox.Text) || r.first_name.Contains(searchTextBox.Text) || r.gender.Contains(searchTextBox.Text) || r.state.Contains(searchTextBox.Text) || r.city.Contains(searchTextBox.Text) || r.room_number.Contains(searchTextBox.Text) || r.room_type.Contains(searchTextBox.Text) || r.email_address.Contains(searchTextBox.Text) || r.phone_number.Contains(searchTextBox.Text));

            searchDataGridView.DataSource = res.ToList();

            if (res.Count() > 0)
            {
                searchButton.Location = new Point(752, 7);
                searchTextBox.Location = new Point(68, 7);
                searchDataGridView.Visible = true;
                SearchError.Visible = false;
            }
            else
            {
                searchDataGridView.Visible = false;
                SearchError.Visible = true;
                SearchError.Text = "SORRY DUDE :(" + "\n"
                    + "I ran out of gas trying to search for " + searchTextBox.Text + "\n"
                + "I sure will find it next time.";
            }
        }
    }

}
