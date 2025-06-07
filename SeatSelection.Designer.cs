namespace MovieTicketBookingManagementSystem
{
    partial class SeatSelection
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
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.lblScreen = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.valTotal = new System.Windows.Forms.Label();
            this.valTicket = new System.Windows.Forms.Label();
            this.valTime = new System.Windows.Forms.Label();
            this.valDuration = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSold = new System.Windows.Forms.Label();
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.pnlAvailable = new System.Windows.Forms.Panel();
            this.pnlSold = new System.Windows.Forms.Panel();
            this.btn_buyTicket = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumberTickets = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.seatsTableLayoutPanel = new System.Windows.Forms.Panel();
            this.seatSelection_back_btn = new System.Windows.Forms.Button();
            this.panelSeat = new System.Windows.Forms.Panel();
            this.pnlScreen.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.seatsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScreen.Controls.Add(this.lblScreen);
            this.pnlScreen.Location = new System.Drawing.Point(193, 1);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(222, 76);
            this.pnlScreen.TabIndex = 0;
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.Location = new System.Drawing.Point(70, 23);
            this.lblScreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(87, 26);
            this.lblScreen.TabIndex = 0;
            this.lblScreen.Text = "Screen";
            this.lblScreen.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoSize = true;
            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.valTotal);
            this.pnlDetails.Controls.Add(this.valTicket);
            this.pnlDetails.Controls.Add(this.valTime);
            this.pnlDetails.Controls.Add(this.valDuration);
            this.pnlDetails.Controls.Add(this.lblAvailable);
            this.pnlDetails.Controls.Add(this.lblSelected);
            this.pnlDetails.Controls.Add(this.lblSold);
            this.pnlDetails.Controls.Add(this.pnlSelected);
            this.pnlDetails.Controls.Add(this.pnlAvailable);
            this.pnlDetails.Controls.Add(this.pnlSold);
            this.pnlDetails.Controls.Add(this.btn_buyTicket);
            this.pnlDetails.Controls.Add(this.lblTotal);
            this.pnlDetails.Controls.Add(this.lblNumberTickets);
            this.pnlDetails.Controls.Add(this.lblTime);
            this.pnlDetails.Controls.Add(this.lblDuration);
            this.pnlDetails.Controls.Add(this.lblMovieName);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(569, 0);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(232, 482);
            this.pnlDetails.TabIndex = 45;
            // 
            // valTotal
            // 
            this.valTotal.AutoSize = true;
            this.valTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valTotal.Location = new System.Drawing.Point(83, 207);
            this.valTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valTotal.Name = "valTotal";
            this.valTotal.Size = new System.Drawing.Size(42, 15);
            this.valTotal.TabIndex = 65;
            this.valTotal.Text = "50000";
            // 
            // valTicket
            // 
            this.valTicket.AutoSize = true;
            this.valTicket.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valTicket.Location = new System.Drawing.Point(83, 167);
            this.valTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valTicket.Name = "valTicket";
            this.valTicket.Size = new System.Drawing.Size(14, 15);
            this.valTicket.TabIndex = 64;
            this.valTicket.Text = "5";
            // 
            // valTime
            // 
            this.valTime.AutoSize = true;
            this.valTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valTime.Location = new System.Drawing.Point(83, 127);
            this.valTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valTime.Name = "valTime";
            this.valTime.Size = new System.Drawing.Size(107, 15);
            this.valTime.TabIndex = 63;
            this.valTime.Text = "6/1/2025 10:00 AM";
            // 
            // valDuration
            // 
            this.valDuration.AutoSize = true;
            this.valDuration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valDuration.Location = new System.Drawing.Point(83, 90);
            this.valDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valDuration.Name = "valDuration";
            this.valDuration.Size = new System.Drawing.Size(76, 15);
            this.valDuration.TabIndex = 62;
            this.valDuration.Text = "120 minutes";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(54, 449);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(56, 15);
            this.lblAvailable.TabIndex = 61;
            this.lblAvailable.Text = "Available";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(54, 422);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(55, 15);
            this.lblSelected.TabIndex = 60;
            this.lblSelected.Text = "Selected";
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSold.Location = new System.Drawing.Point(54, 394);
            this.lblSold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(32, 15);
            this.lblSold.TabIndex = 59;
            this.lblSold.Text = "Sold";
            // 
            // pnlSelected
            // 
            this.pnlSelected.BackColor = System.Drawing.Color.Lime;
            this.pnlSelected.Location = new System.Drawing.Point(28, 422);
            this.pnlSelected.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(15, 15);
            this.pnlSelected.TabIndex = 58;
            // 
            // pnlAvailable
            // 
            this.pnlAvailable.BackColor = System.Drawing.Color.White;
            this.pnlAvailable.Location = new System.Drawing.Point(28, 450);
            this.pnlAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAvailable.Name = "pnlAvailable";
            this.pnlAvailable.Size = new System.Drawing.Size(15, 15);
            this.pnlAvailable.TabIndex = 58;
            // 
            // pnlSold
            // 
            this.pnlSold.BackColor = System.Drawing.Color.Red;
            this.pnlSold.Location = new System.Drawing.Point(28, 394);
            this.pnlSold.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSold.Name = "pnlSold";
            this.pnlSold.Size = new System.Drawing.Size(15, 15);
            this.pnlSold.TabIndex = 57;
            // 
            // btn_buyTicket
            // 
            this.btn_buyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buyTicket.Location = new System.Drawing.Point(52, 253);
            this.btn_buyTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buyTicket.Name = "btn_buyTicket";
            this.btn_buyTicket.Size = new System.Drawing.Size(117, 33);
            this.btn_buyTicket.TabIndex = 56;
            this.btn_buyTicket.Text = "Book now";
            this.btn_buyTicket.UseVisualStyleBackColor = true;
            this.btn_buyTicket.Click += new System.EventHandler(this.btn_buyTicket_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(26, 207);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total :";
            // 
            // lblNumberTickets
            // 
            this.lblNumberTickets.AutoSize = true;
            this.lblNumberTickets.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTickets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumberTickets.Location = new System.Drawing.Point(26, 167);
            this.lblNumberTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberTickets.Name = "lblNumberTickets";
            this.lblNumberTickets.Size = new System.Drawing.Size(52, 15);
            this.lblNumberTickets.TabIndex = 4;
            this.lblNumberTickets.Text = "Tickets :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(26, 127);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 15);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time :";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDuration.Location = new System.Drawing.Point(26, 90);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(60, 15);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration :";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoEllipsis = true;
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMovieName.Location = new System.Drawing.Point(47, 19);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(141, 26);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "Movie name";
            // 
            // seatsTableLayoutPanel
            // 
            this.seatsTableLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatsTableLayoutPanel.Controls.Add(this.seatSelection_back_btn);
            this.seatsTableLayoutPanel.Controls.Add(this.panelSeat);
            this.seatsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.seatsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.seatsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.seatsTableLayoutPanel.Name = "seatsTableLayoutPanel";
            this.seatsTableLayoutPanel.Size = new System.Drawing.Size(569, 482);
            this.seatsTableLayoutPanel.TabIndex = 1;
            // 
            // seatSelection_back_btn
            // 
            this.seatSelection_back_btn.BackColor = System.Drawing.Color.Gray;
            this.seatSelection_back_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.seatSelection_back_btn.FlatAppearance.BorderSize = 0;
            this.seatSelection_back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seatSelection_back_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.seatSelection_back_btn.ForeColor = System.Drawing.Color.White;
            this.seatSelection_back_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.returnwhite;
            this.seatSelection_back_btn.Location = new System.Drawing.Point(0, 0);
            this.seatSelection_back_btn.Margin = new System.Windows.Forms.Padding(0);
            this.seatSelection_back_btn.Name = "seatSelection_back_btn";
            this.seatSelection_back_btn.Size = new System.Drawing.Size(41, 43);
            this.seatSelection_back_btn.TabIndex = 39;
            this.seatSelection_back_btn.UseVisualStyleBackColor = false;
            this.seatSelection_back_btn.Click += new System.EventHandler(this.seatSelection_back_btn_Click);
            // 
            // panelSeat
            // 
            this.panelSeat.Location = new System.Drawing.Point(50, 101);
            this.panelSeat.Name = "panelSeat";
            this.panelSeat.Size = new System.Drawing.Size(503, 298);
            this.panelSeat.TabIndex = 40;
            // 
            // SeatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlScreen);
            this.Controls.Add(this.seatsTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeatSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatSelection";
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.seatsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlSelected;
        private System.Windows.Forms.Panel pnlAvailable;
        private System.Windows.Forms.Panel pnlSold;
        private System.Windows.Forms.Button btn_buyTicket;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumberTickets;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Panel seatsTableLayoutPanel;
        private System.Windows.Forms.Button seatSelection_back_btn;
        private System.Windows.Forms.Panel panelSeat;
        private System.Windows.Forms.Label valDuration;
        private System.Windows.Forms.Label valTotal;
        private System.Windows.Forms.Label valTicket;
        private System.Windows.Forms.Label valTime;
    }
}