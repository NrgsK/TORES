namespace ReservationRequest
{
    partial class NewRequestForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxRooms = new System.Windows.Forms.ComboBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.btnRoomFeatures = new System.Windows.Forms.Button();
            this.lblHeadingTop = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblHedingBottom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpMeetingDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartEnd = new System.Windows.Forms.Label();
            this.cbxMeetingStart = new System.Windows.Forms.ComboBox();
            this.cbxMeetingEnd = new System.Windows.Forms.ComboBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetailsOptional = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(515, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxRooms
            // 
            this.cbxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRooms.FormattingEnabled = true;
            this.cbxRooms.Location = new System.Drawing.Point(162, 93);
            this.cbxRooms.Name = "cbxRooms";
            this.cbxRooms.Size = new System.Drawing.Size(231, 33);
            this.cbxRooms.TabIndex = 3;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(42, 96);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(73, 25);
            this.lblRooms.TabIndex = 4;
            this.lblRooms.Text = "Rooms";
            // 
            // btnRoomFeatures
            // 
            this.btnRoomFeatures.Location = new System.Drawing.Point(449, 77);
            this.btnRoomFeatures.Name = "btnRoomFeatures";
            this.btnRoomFeatures.Size = new System.Drawing.Size(109, 62);
            this.btnRoomFeatures.TabIndex = 5;
            this.btnRoomFeatures.Text = "Room Features";
            this.btnRoomFeatures.UseVisualStyleBackColor = true;
            this.btnRoomFeatures.Click += new System.EventHandler(this.btnRoomFeatures_Click);
            // 
            // lblHeadingTop
            // 
            this.lblHeadingTop.AutoSize = true;
            this.lblHeadingTop.Location = new System.Drawing.Point(12, 9);
            this.lblHeadingTop.Name = "lblHeadingTop";
            this.lblHeadingTop.Size = new System.Drawing.Size(180, 25);
            this.lblHeadingTop.TabIndex = 6;
            this.lblHeadingTop.Text = "TORES v1.0 User :";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(198, 9);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(291, 25);
            this.lblUserInfo.TabIndex = 7;
            this.lblUserInfo.Text = "<Name Surname - Department>";
            // 
            // lblHedingBottom
            // 
            this.lblHedingBottom.AutoSize = true;
            this.lblHedingBottom.Location = new System.Drawing.Point(12, 640);
            this.lblHedingBottom.Name = "lblHedingBottom";
            this.lblHedingBottom.Size = new System.Drawing.Size(614, 25);
            this.lblHedingBottom.TabIndex = 8;
            this.lblHedingBottom.Text = "NOVAS WORKS - TOPLANTI ODALARI REZERVASYON SİSTEMİ";
            this.lblHedingBottom.Click += new System.EventHandler(this.lblHedingBottom_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(42, 166);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // dtpMeetingDate
            // 
            this.dtpMeetingDate.Location = new System.Drawing.Point(162, 166);
            this.dtpMeetingDate.Name = "dtpMeetingDate";
            this.dtpMeetingDate.Size = new System.Drawing.Size(396, 30);
            this.dtpMeetingDate.TabIndex = 10;
            // 
            // lblStartEnd
            // 
            this.lblStartEnd.AutoSize = true;
            this.lblStartEnd.Location = new System.Drawing.Point(42, 228);
            this.lblStartEnd.Name = "lblStartEnd";
            this.lblStartEnd.Size = new System.Drawing.Size(104, 25);
            this.lblStartEnd.TabIndex = 11;
            this.lblStartEnd.Text = "Start / End";
            // 
            // cbxMeetingStart
            // 
            this.cbxMeetingStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeetingStart.FormattingEnabled = true;
            this.cbxMeetingStart.Location = new System.Drawing.Point(162, 228);
            this.cbxMeetingStart.Name = "cbxMeetingStart";
            this.cbxMeetingStart.Size = new System.Drawing.Size(175, 33);
            this.cbxMeetingStart.TabIndex = 12;
            // 
            // cbxMeetingEnd
            // 
            this.cbxMeetingEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeetingEnd.FormattingEnabled = true;
            this.cbxMeetingEnd.Location = new System.Drawing.Point(385, 228);
            this.cbxMeetingEnd.Name = "cbxMeetingEnd";
            this.cbxMeetingEnd.Size = new System.Drawing.Size(173, 33);
            this.cbxMeetingEnd.TabIndex = 13;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(47, 301);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(76, 25);
            this.lblDetails.TabIndex = 14;
            this.lblDetails.Text = "Details ";
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(162, 295);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(396, 140);
            this.txtDetails.TabIndex = 15;
            // 
            // lblDetailsOptional
            // 
            this.lblDetailsOptional.AutoSize = true;
            this.lblDetailsOptional.Location = new System.Drawing.Point(47, 326);
            this.lblDetailsOptional.Name = "lblDetailsOptional";
            this.lblDetailsOptional.Size = new System.Drawing.Size(99, 25);
            this.lblDetailsOptional.TabIndex = 16;
            this.lblDetailsOptional.Text = "(Optional)";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(459, 462);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(99, 69);
            this.btnSendRequest.TabIndex = 17;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // NewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 674);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblDetailsOptional);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cbxMeetingEnd);
            this.Controls.Add(this.cbxMeetingStart);
            this.Controls.Add(this.lblStartEnd);
            this.Controls.Add(this.dtpMeetingDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHedingBottom);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblHeadingTop);
            this.Controls.Add(this.btnRoomFeatures);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.cbxRooms);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resevation Request";
            this.Load += new System.EventHandler(this.NewRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Button btnRoomFeatures;
        private System.Windows.Forms.Label lblHeadingTop;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblHedingBottom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpMeetingDate;
        private System.Windows.Forms.Label lblStartEnd;
        private System.Windows.Forms.ComboBox cbxMeetingStart;
        private System.Windows.Forms.ComboBox cbxMeetingEnd;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetailsOptional;
        private System.Windows.Forms.Button btnSendRequest;
    }
}

