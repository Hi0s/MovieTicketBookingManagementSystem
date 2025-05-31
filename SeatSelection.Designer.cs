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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button41 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumberTickets = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.seatsTableLayoutPanel = new System.Windows.Forms.Panel();
            this.seatSelection_back_btn = new System.Windows.Forms.Button();
            this.panelSeat = new System.Windows.Forms.Panel();
            this.valDuration = new System.Windows.Forms.Label();
            this.valTime = new System.Windows.Forms.Label();
            this.valTicket = new System.Windows.Forms.Label();
            this.valTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.seatsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(193, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.valTotal);
            this.panel2.Controls.Add(this.valTicket);
            this.panel2.Controls.Add(this.valTime);
            this.panel2.Controls.Add(this.valDuration);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button41);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblNumberTickets);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDuration);
            this.panel2.Controls.Add(this.lblMovieName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(569, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 522);
            this.panel2.TabIndex = 45;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(57, 490);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 61;
            this.label23.Text = "Available";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(57, 460);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "Selected";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(57, 430);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "Sold";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Location = new System.Drawing.Point(28, 457);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 16);
            this.panel4.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(28, 487);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 16);
            this.panel5.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(28, 427);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 16);
            this.panel3.TabIndex = 57;
            // 
            // button41
            // 
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(52, 274);
            this.button41.Margin = new System.Windows.Forms.Padding(2);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(117, 36);
            this.button41.TabIndex = 56;
            this.button41.Text = "Book now";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(26, 224);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total :";
            // 
            // lblNumberTickets
            // 
            this.lblNumberTickets.AutoSize = true;
            this.lblNumberTickets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumberTickets.Location = new System.Drawing.Point(26, 181);
            this.lblNumberTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberTickets.Name = "lblNumberTickets";
            this.lblNumberTickets.Size = new System.Drawing.Size(48, 13);
            this.lblNumberTickets.TabIndex = 4;
            this.lblNumberTickets.Text = "Tickets :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(26, 138);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time :";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDuration.Location = new System.Drawing.Point(26, 98);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration :";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMovieName.Location = new System.Drawing.Point(48, 43);
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
            this.seatsTableLayoutPanel.Size = new System.Drawing.Size(569, 522);
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
            this.seatSelection_back_btn.Size = new System.Drawing.Size(41, 47);
            this.seatSelection_back_btn.TabIndex = 39;
            this.seatSelection_back_btn.UseVisualStyleBackColor = false;
            this.seatSelection_back_btn.Click += new System.EventHandler(this.seatSelection_back_btn_Click);
            // 
            // panelSeat
            // 
            this.panelSeat.Location = new System.Drawing.Point(50, 109);
            this.panelSeat.Name = "panelSeat";
            this.panelSeat.Size = new System.Drawing.Size(503, 323);
            this.panelSeat.TabIndex = 40;
            // 
            // valDuration
            // 
            this.valDuration.AutoSize = true;
            this.valDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valDuration.Location = new System.Drawing.Point(83, 98);
            this.valDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valDuration.Name = "valDuration";
            this.valDuration.Size = new System.Drawing.Size(64, 13);
            this.valDuration.TabIndex = 62;
            this.valDuration.Text = "120 minutes";
            // 
            // valTime
            // 
            this.valTime.AutoSize = true;
            this.valTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valTime.Location = new System.Drawing.Point(83, 138);
            this.valTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valTime.Name = "valTime";
            this.valTime.Size = new System.Drawing.Size(102, 13);
            this.valTime.TabIndex = 63;
            this.valTime.Text = "6/1/2025 10:00 AM";
            // 
            // valTicket
            // 
            this.valTicket.AutoSize = true;
            this.valTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valTicket.Location = new System.Drawing.Point(83, 181);
            this.valTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valTicket.Name = "valTicket";
            this.valTicket.Size = new System.Drawing.Size(13, 13);
            this.valTicket.TabIndex = 64;
            this.valTicket.Text = "5";
            // 
            // valTotal
            // 
            this.valTotal.AutoSize = true;
            this.valTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valTotal.Location = new System.Drawing.Point(83, 224);
            this.valTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valTotal.Name = "valTotal";
            this.valTotal.Size = new System.Drawing.Size(37, 13);
            this.valTotal.TabIndex = 65;
            this.valTotal.Text = "50000";
            // 
            // SeatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.seatsTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeatSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatSelection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.seatsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumberTickets;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel seatsTableLayoutPanel;
        private System.Windows.Forms.Button seatSelection_back_btn;
        private System.Windows.Forms.Panel panelSeat;
        private System.Windows.Forms.Label valDuration;
        private System.Windows.Forms.Label valTotal;
        private System.Windows.Forms.Label valTicket;
        private System.Windows.Forms.Label valTime;
    }
}