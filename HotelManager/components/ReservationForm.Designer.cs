namespace HotelManager.components
{
    partial class ReservationForm
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
            this.guestFormButton = new System.Windows.Forms.Button();
            this.guestLabel = new System.Windows.Forms.Label();
            this.cancelGuestButton = new System.Windows.Forms.Button();
            this.deleteGuestButton = new System.Windows.Forms.Button();
            this.closeReservationFormBtn = new FontAwesome.Sharp.IconButton();
            this.roomNumberTextBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ageTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addressTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneNumberTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.arriveTimeDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PriceTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guestIDTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.employeeIDTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // guestFormButton
            // 
            this.guestFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.guestFormButton.FlatAppearance.BorderSize = 0;
            this.guestFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guestFormButton.ForeColor = System.Drawing.Color.White;
            this.guestFormButton.Location = new System.Drawing.Point(404, 805);
            this.guestFormButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guestFormButton.Name = "guestFormButton";
            this.guestFormButton.Size = new System.Drawing.Size(248, 62);
            this.guestFormButton.TabIndex = 64;
            this.guestFormButton.Text = "Add";
            this.guestFormButton.UseVisualStyleBackColor = false;
            this.guestFormButton.Click += new System.EventHandler(this.guestFormButton_Click);
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.guestLabel.ForeColor = System.Drawing.Color.White;
            this.guestLabel.Location = new System.Drawing.Point(578, 48);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(120, 32);
            this.guestLabel.TabIndex = 63;
            this.guestLabel.Text = "ADD Bill";
            this.guestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guestLabel.Click += new System.EventHandler(this.guestLabel_Click);
            // 
            // cancelGuestButton
            // 
            this.cancelGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.cancelGuestButton.FlatAppearance.BorderSize = 0;
            this.cancelGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelGuestButton.ForeColor = System.Drawing.Color.White;
            this.cancelGuestButton.Location = new System.Drawing.Point(674, 805);
            this.cancelGuestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelGuestButton.Name = "cancelGuestButton";
            this.cancelGuestButton.Size = new System.Drawing.Size(248, 62);
            this.cancelGuestButton.TabIndex = 59;
            this.cancelGuestButton.Text = "Cancel";
            this.cancelGuestButton.UseVisualStyleBackColor = false;
            // 
            // deleteGuestButton
            // 
            this.deleteGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.deleteGuestButton.FlatAppearance.BorderSize = 0;
            this.deleteGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteGuestButton.ForeColor = System.Drawing.Color.White;
            this.deleteGuestButton.Location = new System.Drawing.Point(402, 892);
            this.deleteGuestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteGuestButton.Name = "deleteGuestButton";
            this.deleteGuestButton.Size = new System.Drawing.Size(519, 62);
            this.deleteGuestButton.TabIndex = 73;
            this.deleteGuestButton.Text = "Delete";
            this.deleteGuestButton.UseVisualStyleBackColor = false;
            // 
            // closeReservationFormBtn
            // 
            this.closeReservationFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeReservationFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.closeReservationFormBtn.FlatAppearance.BorderSize = 0;
            this.closeReservationFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeReservationFormBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeReservationFormBtn.IconColor = System.Drawing.Color.White;
            this.closeReservationFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeReservationFormBtn.IconSize = 32;
            this.closeReservationFormBtn.Location = new System.Drawing.Point(1315, 2);
            this.closeReservationFormBtn.Name = "closeReservationFormBtn";
            this.closeReservationFormBtn.Size = new System.Drawing.Size(63, 57);
            this.closeReservationFormBtn.TabIndex = 58;
            this.closeReservationFormBtn.UseVisualStyleBackColor = false;
            this.closeReservationFormBtn.Click += new System.EventHandler(this.closeReservationFormBtn_Click);
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.roomNumberTextBox.BorderRadius = 3;
            this.roomNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.roomNumberTextBox.Items = new string[0];
            this.roomNumberTextBox.Location = new System.Drawing.Point(876, 151);
            this.roomNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.roomNumberTextBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.roomNumberTextBox.selectedIndex = -1;
            this.roomNumberTextBox.Size = new System.Drawing.Size(388, 54);
            this.roomNumberTextBox.TabIndex = 74;
            this.roomNumberTextBox.onItemSelected += new System.EventHandler(this.roomNumberTextBox_onItemSelected);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(701, 160);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(152, 23);
            this.bunifuCustomLabel7.TabIndex = 115;
            this.bunifuCustomLabel7.Text = "Room Number";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.Color.White;
            this.ageTextBox.HintForeColor = System.Drawing.Color.White;
            this.ageTextBox.HintText = "";
            this.ageTextBox.isPassword = false;
            this.ageTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.ageTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.ageTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.ageTextBox.LineThickness = 4;
            this.ageTextBox.Location = new System.Drawing.Point(244, 374);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(365, 80);
            this.ageTextBox.TabIndex = 121;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ageTextBox.OnValueChanged += new System.EventHandler(this.ageTextBox_OnValueChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.White;
            this.addressTextBox.HintForeColor = System.Drawing.SystemColors.Window;
            this.addressTextBox.HintText = "";
            this.addressTextBox.isPassword = false;
            this.addressTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.addressTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.addressTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.addressTextBox.LineThickness = 4;
            this.addressTextBox.Location = new System.Drawing.Point(244, 502);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(365, 80);
            this.addressTextBox.TabIndex = 120;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.HintForeColor = System.Drawing.Color.White;
            this.nameTextBox.HintText = "";
            this.nameTextBox.isPassword = false;
            this.nameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.nameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.nameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.nameTextBox.LineThickness = 4;
            this.nameTextBox.Location = new System.Drawing.Point(244, 251);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(365, 80);
            this.nameTextBox.TabIndex = 122;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.HintForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.HintText = "";
            this.phoneNumberTextBox.isPassword = false;
            this.phoneNumberTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.phoneNumberTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneNumberTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.phoneNumberTextBox.LineThickness = 4;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(244, 622);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(367, 80);
            this.phoneNumberTextBox.TabIndex = 123;
            this.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // arriveTimeDatepicker
            // 
            this.arriveTimeDatepicker.BackColor = System.Drawing.Color.SeaGreen;
            this.arriveTimeDatepicker.BorderRadius = 0;
            this.arriveTimeDatepicker.ForeColor = System.Drawing.Color.White;
            this.arriveTimeDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.arriveTimeDatepicker.FormatCustom = null;
            this.arriveTimeDatepicker.Location = new System.Drawing.Point(876, 391);
            this.arriveTimeDatepicker.Margin = new System.Windows.Forms.Padding(6);
            this.arriveTimeDatepicker.Name = "arriveTimeDatepicker";
            this.arriveTimeDatepicker.Size = new System.Drawing.Size(388, 63);
            this.arriveTimeDatepicker.TabIndex = 124;
            this.arriveTimeDatepicker.Value = new System.DateTime(2023, 10, 14, 14, 34, 33, 79);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(701, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 125;
            this.label2.Text = "Arrive Time";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(701, 517);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(135, 23);
            this.bunifuCustomLabel8.TabIndex = 139;
            this.bunifuCustomLabel8.Text = "Employee ID";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(67, 160);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(87, 23);
            this.bunifuCustomLabel10.TabIndex = 127;
            this.bunifuCustomLabel10.Text = "GuestID";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(67, 272);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 23);
            this.bunifuCustomLabel2.TabIndex = 128;
            this.bunifuCustomLabel2.Text = "Name";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(67, 402);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(51, 23);
            this.bunifuCustomLabel3.TabIndex = 129;
            this.bunifuCustomLabel3.Text = "Age";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(67, 517);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 23);
            this.bunifuCustomLabel4.TabIndex = 130;
            this.bunifuCustomLabel4.Text = "Address";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(67, 650);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(157, 23);
            this.bunifuCustomLabel5.TabIndex = 131;
            this.bunifuCustomLabel5.Text = "Phone Number";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.ForeColor = System.Drawing.Color.White;
            this.PriceTextBox.HintForeColor = System.Drawing.Color.White;
            this.PriceTextBox.HintText = "";
            this.PriceTextBox.isPassword = false;
            this.PriceTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.PriceTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.PriceTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.PriceTextBox.LineThickness = 4;
            this.PriceTextBox.Location = new System.Drawing.Point(876, 251);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(388, 80);
            this.PriceTextBox.TabIndex = 132;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guestIDTxt
            // 
            this.guestIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guestIDTxt.Enabled = false;
            this.guestIDTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDTxt.ForeColor = System.Drawing.Color.White;
            this.guestIDTxt.HintForeColor = System.Drawing.Color.White;
            this.guestIDTxt.HintText = "";
            this.guestIDTxt.isPassword = false;
            this.guestIDTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.guestIDTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.guestIDTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.guestIDTxt.LineThickness = 4;
            this.guestIDTxt.Location = new System.Drawing.Point(244, 125);
            this.guestIDTxt.Margin = new System.Windows.Forms.Padding(6);
            this.guestIDTxt.Name = "guestIDTxt";
            this.guestIDTxt.Size = new System.Drawing.Size(367, 80);
            this.guestIDTxt.TabIndex = 126;
            this.guestIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(701, 272);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(57, 23);
            this.bunifuCustomLabel6.TabIndex = 135;
            this.bunifuCustomLabel6.Text = "Price";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeIDTextBox.Enabled = false;
            this.employeeIDTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextBox.ForeColor = System.Drawing.Color.White;
            this.employeeIDTextBox.HintForeColor = System.Drawing.Color.White;
            this.employeeIDTextBox.HintText = "";
            this.employeeIDTextBox.isPassword = false;
            this.employeeIDTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.employeeIDTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.employeeIDTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.employeeIDTextBox.LineThickness = 4;
            this.employeeIDTextBox.Location = new System.Drawing.Point(876, 502);
            this.employeeIDTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(388, 80);
            this.employeeIDTextBox.TabIndex = 136;
            this.employeeIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1377, 1020);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.guestIDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arriveTimeDatepicker);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.deleteGuestButton);
            this.Controls.Add(this.guestFormButton);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.cancelGuestButton);
            this.Controls.Add(this.closeReservationFormBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guestFormButton;
        private System.Windows.Forms.Label guestLabel;
        private System.Windows.Forms.Button cancelGuestButton;
        private FontAwesome.Sharp.IconButton closeReservationFormBtn;
        private System.Windows.Forms.Button deleteGuestButton;
        private Bunifu.Framework.UI.BunifuDropdown roomNumberTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ageTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneNumberTextBox;
        private Bunifu.Framework.UI.BunifuDatepicker arriveTimeDatepicker;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox guestIDTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox employeeIDTextBox;
    }
}