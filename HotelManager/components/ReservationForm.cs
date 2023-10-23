using HotelManager.utils;
using System;
using System.Data;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HotelManager.components
{
    public partial class ReservationForm : Form
    {
        private string currentState;

        private string billID, guestID, name, address, phoneNumber, roomNumber, employeeID;
        private int age;
        DateTime arriveTime;
        DBQuery db=new DBQuery();

        private void ageTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guestLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomNumberTextBox_onItemSelected(object sender, EventArgs e)
        {
       
            string price = db.RenderID("SELECT dbo.price('"+roomNumberTextBox.selectedValue.ToString()+"')");
            PriceTextBox.Text= price;
        }

        public ReservationForm()
        {
            currentState = "ADD";
            InitializeComponent();
        }
        public ReservationForm(string guestID)
        {
          this.guestID = guestID;
            currentState = "ADD";
            InitializeComponent();
        }
        public ReservationForm(string billID,string guestID, string name, int age, string address, string phoneNumber, string roomNumber, DateTime arriveTime, string employeeID)
        {
            currentState = "UPDATE";
            this.billID = billID;
            this.guestID = guestID;
            this.name = name;
            this.age = age;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.roomNumber = roomNumber;
            this.arriveTime = arriveTime;
            this.employeeID = employeeID;

            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            if(currentState == "UPDATE")
            {
                guestLabel.Text = "UPDATE BILL";
                guestIDTxt.Text = guestID;
                nameTextBox.Text = name;
                ageTextBox.Text = age.ToString();
                addressTextBox.Text = address;
                phoneNumberTextBox.Text = phoneNumber;
                roomNumberTextBox.Text = roomNumber;
                arriveTimeDatepicker.Value = arriveTime;            
                employeeIDTextBox.Text = employeeID;
            }
            else if(currentState == "ADD"){
                guestFormButton.Text = "ADD BILL";
                guestIDTxt.Text = guestID;
                DataTable dt = db.GetData("select SOPHONG FROM PHONG");
                foreach (DataRow row in dt.Rows)
                {
                    string roomNumber = row["SOPHONG"].ToString();
                    roomNumberTextBox.AddItem(roomNumber);
                }
            }
        }

        private void closeReservationFormBtn_Click(object sender, EventArgs e)
        {
            /*   CustomMessageBox c = new CustomMessageBox("Xác nhận","Bạn có chắc chắn muốn thoát chương trình","Yes","No");
               c.YesClicked += (s, args) =>
               {
                   this.Close();
               };

               c.YesClicked += (s, args) =>
               {
                   return;  
               };
               c.ShowDialog();*/
            this.Close();
        }

        private void guestFormButton_Click(object sender, EventArgs e)
        {
            string guestID = guestIDTxt.Text;
            string name = nameTextBox.Text;
            string age = ageTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string roomNumber = roomNumberTextBox.Text;
            DateTime arriveTime = (DateTime)arriveTimeDatepicker.Value;
         
            string employeeID = employeeIDTextBox.Text;
            

        }


    }
}
