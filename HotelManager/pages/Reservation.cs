using Bunifu.Framework.UI;
using HotelManager.components;
using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.pages
{
    public partial class Reservation : Form
    {
        private string selectAllCommand = ("SELECT " +
                "BillID AS N'Bill ID', " +
                "Name AS Name, " +
                "PhoneNumber AS N'Phone Number', " +
                "RoomNumber AS N'Room Number', " +
                "ArriveTime AS 'Arrive Time', " +
                "LeaveTime AS 'Leave Time', " +
                "ServerName AS N'Server Name' FROM ReservationView");
        private string activeFilterTab = "ALL";
        DBQuery db = new DBQuery();
        public Reservation()
        {
            InitializeComponent();

        }

        private void FocusOnClick(object sender, EventArgs e)
        {
            reservationSearchTextBox.Focus();
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
         
            (new ReservationForm(db.RenderID("select dbo.CreateMaHD()"))).ShowDialog();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            allFilterButton.IdleFillColor = Color.SeaGreen;
            allFilterButton.IdleForecolor = Color.White;
            DataTable dt = new DataTable();

            dt = db.GetData(selectAllCommand);
            reservationDataGridView.DataSource = dt;
        }

        // CELL CLICK 
        private void reservationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTable dt = new DataTable();
          
            string billID = reservationDataGridView.CurrentRow.Cells[0].Value.ToString();
            dt = db.GetData("SELECT GuestID, EmployeeID, Age, Address FROM ReservationView WHERE BillID = '"+ billID + "'");
                        
            string guestID = dt.Rows[0].Field<string>("GuestID");
            string name = reservationDataGridView.CurrentRow.Cells[1].Value.ToString();
            int age = dt.Rows[0].Field<int>("Age");
            string address = dt.Rows[0].Field<string>("Address");
            string phoneNumber = reservationDataGridView.CurrentRow.Cells[2].Value.ToString();
            string roomNumber = reservationDataGridView.CurrentRow.Cells[3].Value.ToString();
            DateTime arriveTime = (DateTime)reservationDataGridView.CurrentRow.Cells[4].Value;
            string employeeID = dt.Rows[0].Field<string>("EmployeeID");
            if (activeFilterTab == "CHECKIN")
            {
                (new ReservationCheckOut(billID,guestID, name, age, address, phoneNumber, roomNumber, arriveTime, employeeID)).ShowDialog();
            }
            else
            {
            (new ReservationForm(billID,guestID, name, age, address, phoneNumber, roomNumber, arriveTime, employeeID)).ShowDialog();
            }
        

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void ActiveFilterGuestButton(object sender)
        {
            List<BunifuThinButton2> buttonList = new List<BunifuThinButton2>()
            {
                allFilterButton,
                checkinFilterButton,
                checkoutFilterButton
            };

            BunifuThinButton2 button = sender as BunifuThinButton2;
            foreach (BunifuThinButton2 b in buttonList)
            {
                if (button.Name == b.Name)
                {
                    b.IdleFillColor = Color.SeaGreen;
                    b.IdleForecolor = Color.White;
                }
                else
                {
                    b.IdleFillColor = Color.White;
                    b.IdleForecolor = Color.SeaGreen;
                }
            }
        }

        private void checkinFilterButton_Click(object sender, EventArgs e)
        {
            activeFilterTab = "CHECKIN";
            ActiveFilterGuestButton(sender);

        
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData($"{selectAllCommand} WHERE LeaveTime IS NULL");
                reservationDataGridView.DataSource = dt;
            }
            catch (Exception ex) { }
        }
  
        private void checkoutFilterButton_Click_1(object sender, EventArgs e)
        {
            activeFilterTab = "CHECKOUT";
            ActiveFilterGuestButton(sender);

            
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData($"{selectAllCommand}  WHERE LeaveTime IS NOT NULL");
                reservationDataGridView.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void allFilterButton_Click_1(object sender, EventArgs e)
        {
            activeFilterTab = "ALL";
            ActiveFilterGuestButton(sender);
           
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData(selectAllCommand);
                reservationDataGridView.DataSource = dt;
            }
            catch (Exception ex) { }
        }
    }
}
