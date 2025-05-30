namespace MovieTicketBookingManagementSystem
{
    partial class AddShowtimeForm
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
            this.addmovie_return_btn = new System.Windows.Forms.Button();
            this.addshowtime_btn = new System.Windows.Forms.Button();
            this.addshowtime_movie_lbl = new System.Windows.Forms.Label();
            this.addmovie_form_lbl = new System.Windows.Forms.Label();
            this.addshowtime_movie_cb = new System.Windows.Forms.ComboBox();
            this.addshowtime_theater_lbl = new System.Windows.Forms.Label();
            this.addshowtime_theater_cb = new System.Windows.Forms.ComboBox();
            this.addshowtime_startdate_lbl = new System.Windows.Forms.Label();
            this.addshowtime_startdate_datepicker = new System.Windows.Forms.DateTimePicker();
            this.addshowtime_enddate_lbl = new System.Windows.Forms.Label();
            this.addshowtime_enddate_datepicker = new System.Windows.Forms.DateTimePicker();
            this.addshowtime_dailytime_lbl = new System.Windows.Forms.Label();
            this.addshowtime_dailytime_lb = new System.Windows.Forms.ListBox();
            this.addshowtime_totalseats_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addmovie_return_btn
            // 
            this.addmovie_return_btn.BackColor = System.Drawing.Color.Gray;
            this.addmovie_return_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.addmovie_return_btn.FlatAppearance.BorderSize = 0;
            this.addmovie_return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addmovie_return_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.addmovie_return_btn.ForeColor = System.Drawing.Color.White;
            this.addmovie_return_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.returnwhite;
            this.addmovie_return_btn.Location = new System.Drawing.Point(0, 0);
            this.addmovie_return_btn.Margin = new System.Windows.Forms.Padding(0);
            this.addmovie_return_btn.Name = "addmovie_return_btn";
            this.addmovie_return_btn.Size = new System.Drawing.Size(41, 43);
            this.addmovie_return_btn.TabIndex = 38;
            this.addmovie_return_btn.UseVisualStyleBackColor = false;
            this.addmovie_return_btn.Click += new System.EventHandler(this.addmovie_return_btn_Click);
            // 
            // addshowtime_btn
            // 
            this.addshowtime_btn.BackColor = System.Drawing.Color.Gray;
            this.addshowtime_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.addshowtime_btn.FlatAppearance.BorderSize = 0;
            this.addshowtime_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.addshowtime_btn.ForeColor = System.Drawing.Color.White;
            this.addshowtime_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addshowtime_btn.Location = new System.Drawing.Point(218, 612);
            this.addshowtime_btn.Margin = new System.Windows.Forms.Padding(0);
            this.addshowtime_btn.Name = "addshowtime_btn";
            this.addshowtime_btn.Size = new System.Drawing.Size(162, 47);
            this.addshowtime_btn.TabIndex = 37;
            this.addshowtime_btn.Text = "Add Showtime";
            this.addshowtime_btn.UseVisualStyleBackColor = false;
            this.addshowtime_btn.Click += new System.EventHandler(this.addshowtime_btn_Click);
            // 
            // addshowtime_movie_lbl
            // 
            this.addshowtime_movie_lbl.AutoSize = true;
            this.addshowtime_movie_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_movie_lbl.ForeColor = System.Drawing.Color.Black;
            this.addshowtime_movie_lbl.Location = new System.Drawing.Point(105, 144);
            this.addshowtime_movie_lbl.Name = "addshowtime_movie_lbl";
            this.addshowtime_movie_lbl.Size = new System.Drawing.Size(59, 18);
            this.addshowtime_movie_lbl.TabIndex = 26;
            this.addshowtime_movie_lbl.Text = "Movie:";
            // 
            // addmovie_form_lbl
            // 
            this.addmovie_form_lbl.AutoSize = true;
            this.addmovie_form_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmovie_form_lbl.ForeColor = System.Drawing.Color.Black;
            this.addmovie_form_lbl.Location = new System.Drawing.Point(199, 47);
            this.addmovie_form_lbl.Name = "addmovie_form_lbl";
            this.addmovie_form_lbl.Size = new System.Drawing.Size(203, 24);
            this.addmovie_form_lbl.TabIndex = 28;
            this.addmovie_form_lbl.Text = "Premiere Schedule";
            // 
            // addshowtime_movie_cb
            // 
            this.addshowtime_movie_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addshowtime_movie_cb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_movie_cb.FormattingEnabled = true;
            this.addshowtime_movie_cb.Location = new System.Drawing.Point(218, 142);
            this.addshowtime_movie_cb.Name = "addshowtime_movie_cb";
            this.addshowtime_movie_cb.Size = new System.Drawing.Size(253, 26);
            this.addshowtime_movie_cb.TabIndex = 39;
            this.addshowtime_movie_cb.SelectedIndexChanged += new System.EventHandler(this.addshowtime_movie_cb_SelectedIndexChanged);
            // 
            // addshowtime_theater_lbl
            // 
            this.addshowtime_theater_lbl.AutoSize = true;
            this.addshowtime_theater_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_theater_lbl.ForeColor = System.Drawing.Color.Black;
            this.addshowtime_theater_lbl.Location = new System.Drawing.Point(105, 196);
            this.addshowtime_theater_lbl.Name = "addshowtime_theater_lbl";
            this.addshowtime_theater_lbl.Size = new System.Drawing.Size(76, 18);
            this.addshowtime_theater_lbl.TabIndex = 26;
            this.addshowtime_theater_lbl.Text = "Theater:";
            // 
            // addshowtime_theater_cb
            // 
            this.addshowtime_theater_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addshowtime_theater_cb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_theater_cb.FormattingEnabled = true;
            this.addshowtime_theater_cb.Location = new System.Drawing.Point(218, 193);
            this.addshowtime_theater_cb.Name = "addshowtime_theater_cb";
            this.addshowtime_theater_cb.Size = new System.Drawing.Size(253, 26);
            this.addshowtime_theater_cb.TabIndex = 39;
            this.addshowtime_theater_cb.SelectedIndexChanged += new System.EventHandler(this.addshowtime_theater_cb_SelectedIndexChanged);
            // 
            // addshowtime_startdate_lbl
            // 
            this.addshowtime_startdate_lbl.AutoSize = true;
            this.addshowtime_startdate_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_startdate_lbl.ForeColor = System.Drawing.Color.Black;
            this.addshowtime_startdate_lbl.Location = new System.Drawing.Point(105, 311);
            this.addshowtime_startdate_lbl.Name = "addshowtime_startdate_lbl";
            this.addshowtime_startdate_lbl.Size = new System.Drawing.Size(95, 18);
            this.addshowtime_startdate_lbl.TabIndex = 26;
            this.addshowtime_startdate_lbl.Text = "Start Date:";
            // 
            // addshowtime_startdate_datepicker
            // 
            this.addshowtime_startdate_datepicker.Font = new System.Drawing.Font("Arial", 12F);
            this.addshowtime_startdate_datepicker.Location = new System.Drawing.Point(218, 305);
            this.addshowtime_startdate_datepicker.Name = "addshowtime_startdate_datepicker";
            this.addshowtime_startdate_datepicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addshowtime_startdate_datepicker.Size = new System.Drawing.Size(253, 26);
            this.addshowtime_startdate_datepicker.TabIndex = 40;
            this.addshowtime_startdate_datepicker.ValueChanged += new System.EventHandler(this.addshowtime_startdate_datepicker_ValueChanged);
            // 
            // addshowtime_enddate_lbl
            // 
            this.addshowtime_enddate_lbl.AutoSize = true;
            this.addshowtime_enddate_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_enddate_lbl.ForeColor = System.Drawing.Color.Black;
            this.addshowtime_enddate_lbl.Location = new System.Drawing.Point(105, 375);
            this.addshowtime_enddate_lbl.Name = "addshowtime_enddate_lbl";
            this.addshowtime_enddate_lbl.Size = new System.Drawing.Size(86, 18);
            this.addshowtime_enddate_lbl.TabIndex = 26;
            this.addshowtime_enddate_lbl.Text = "End Date:";
            // 
            // addshowtime_enddate_datepicker
            // 
            this.addshowtime_enddate_datepicker.Font = new System.Drawing.Font("Arial", 12F);
            this.addshowtime_enddate_datepicker.Location = new System.Drawing.Point(218, 369);
            this.addshowtime_enddate_datepicker.Name = "addshowtime_enddate_datepicker";
            this.addshowtime_enddate_datepicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addshowtime_enddate_datepicker.Size = new System.Drawing.Size(253, 26);
            this.addshowtime_enddate_datepicker.TabIndex = 40;
            this.addshowtime_enddate_datepicker.ValueChanged += new System.EventHandler(this.addshowtime_enddate_datepicker_ValueChanged);
            // 
            // addshowtime_dailytime_lbl
            // 
            this.addshowtime_dailytime_lbl.AutoSize = true;
            this.addshowtime_dailytime_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_dailytime_lbl.ForeColor = System.Drawing.Color.Black;
            this.addshowtime_dailytime_lbl.Location = new System.Drawing.Point(105, 448);
            this.addshowtime_dailytime_lbl.Name = "addshowtime_dailytime_lbl";
            this.addshowtime_dailytime_lbl.Size = new System.Drawing.Size(94, 18);
            this.addshowtime_dailytime_lbl.TabIndex = 26;
            this.addshowtime_dailytime_lbl.Text = "Daily Time:";
            // 
            // addshowtime_dailytime_lb
            // 
            this.addshowtime_dailytime_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addshowtime_dailytime_lb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_dailytime_lb.FormatString = "F";
            this.addshowtime_dailytime_lb.FormattingEnabled = true;
            this.addshowtime_dailytime_lb.ItemHeight = 17;
            this.addshowtime_dailytime_lb.Location = new System.Drawing.Point(218, 448);
            this.addshowtime_dailytime_lb.Name = "addshowtime_dailytime_lb";
            this.addshowtime_dailytime_lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.addshowtime_dailytime_lb.Size = new System.Drawing.Size(184, 87);
            this.addshowtime_dailytime_lb.TabIndex = 41;
            this.addshowtime_dailytime_lb.SelectedIndexChanged += new System.EventHandler(this.addshowtime_dailytime_lb_SelectedIndexChanged);
            // 
            // addshowtime_totalseats_lbl
            // 
            this.addshowtime_totalseats_lbl.AutoSize = true;
            this.addshowtime_totalseats_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addshowtime_totalseats_lbl.ForeColor = System.Drawing.Color.Black;
            this.addshowtime_totalseats_lbl.Location = new System.Drawing.Point(105, 250);
            this.addshowtime_totalseats_lbl.Name = "addshowtime_totalseats_lbl";
            this.addshowtime_totalseats_lbl.Size = new System.Drawing.Size(99, 18);
            this.addshowtime_totalseats_lbl.TabIndex = 26;
            this.addshowtime_totalseats_lbl.Text = "TotalSeats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(105, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Note: Hold CTRL to select multiple times";
            // 
            // AddShowtimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 741);
            this.Controls.Add(this.addshowtime_dailytime_lb);
            this.Controls.Add(this.addshowtime_enddate_datepicker);
            this.Controls.Add(this.addshowtime_startdate_datepicker);
            this.Controls.Add(this.addshowtime_theater_cb);
            this.Controls.Add(this.addshowtime_movie_cb);
            this.Controls.Add(this.addshowtime_enddate_lbl);
            this.Controls.Add(this.addmovie_return_btn);
            this.Controls.Add(this.addshowtime_startdate_lbl);
            this.Controls.Add(this.addshowtime_totalseats_lbl);
            this.Controls.Add(this.addshowtime_theater_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addshowtime_dailytime_lbl);
            this.Controls.Add(this.addshowtime_btn);
            this.Controls.Add(this.addshowtime_movie_lbl);
            this.Controls.Add(this.addmovie_form_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddShowtimeForm";
            this.Load += new System.EventHandler(this.Add_Showtime_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddShowtimeForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddShowtimeForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addmovie_return_btn;
        private System.Windows.Forms.Button addshowtime_btn;
        private System.Windows.Forms.Label addshowtime_movie_lbl;
        private System.Windows.Forms.Label addmovie_form_lbl;
        private System.Windows.Forms.ComboBox addshowtime_movie_cb;

        private System.Windows.Forms.Label addshowtime_theater_lbl;
        private System.Windows.Forms.ComboBox addshowtime_theater_cb;
        private System.Windows.Forms.Label addshowtime_startdate_lbl;
        private System.Windows.Forms.DateTimePicker addshowtime_startdate_datepicker;
        private System.Windows.Forms.Label addshowtime_enddate_lbl;
        private System.Windows.Forms.DateTimePicker addshowtime_enddate_datepicker;
        private System.Windows.Forms.Label addshowtime_dailytime_lbl;

        private System.Windows.Forms.ListBox addshowtime_dailytime_lb;
        private System.Windows.Forms.Label addshowtime_totalseats_lbl;
        private System.Windows.Forms.Label label1;
    }
}