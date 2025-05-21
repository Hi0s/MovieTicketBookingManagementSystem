namespace MovieTicketBookingManagementSystem
{
    partial class AdminDashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_username_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_logout_btn = new System.Windows.Forms.Button();
            this.admin_managetickets_btn = new System.Windows.Forms.Button();
            this.admin_manageusers_btn = new System.Windows.Forms.Button();
            this.admin_managemovies_btn = new System.Windows.Forms.Button();
            this.admin_dashboard_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.admin_logout_btn);
            this.panel1.Controls.Add(this.admin_managetickets_btn);
            this.panel1.Controls.Add(this.admin_manageusers_btn);
            this.panel1.Controls.Add(this.admin_managemovies_btn);
            this.panel1.Controls.Add(this.admin_dashboard_btn);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 741);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.admin_username_lbl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 188);
            this.panel2.TabIndex = 14;
            // 
            // admin_username_lbl
            // 
            this.admin_username_lbl.AutoSize = true;
            this.admin_username_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username_lbl.ForeColor = System.Drawing.Color.White;
            this.admin_username_lbl.Location = new System.Drawing.Point(73, 112);
            this.admin_username_lbl.Name = "admin_username_lbl";
            this.admin_username_lbl.Size = new System.Drawing.Size(58, 18);
            this.admin_username_lbl.TabIndex = 1;
            this.admin_username_lbl.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.circleUser;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // admin_logout_btn
            // 
            this.admin_logout_btn.BackColor = System.Drawing.Color.White;
            this.admin_logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin_logout_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_logout_btn.Location = new System.Drawing.Point(59, 685);
            this.admin_logout_btn.Name = "admin_logout_btn";
            this.admin_logout_btn.Size = new System.Drawing.Size(92, 44);
            this.admin_logout_btn.TabIndex = 13;
            this.admin_logout_btn.Text = "Log out";
            this.admin_logout_btn.UseVisualStyleBackColor = false;
            // 
            // admin_managetickets_btn
            // 
            this.admin_managetickets_btn.FlatAppearance.BorderSize = 0;
            this.admin_managetickets_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_managetickets_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.admin_managetickets_btn.ForeColor = System.Drawing.Color.White;
            this.admin_managetickets_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.ticket;
            this.admin_managetickets_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_managetickets_btn.Location = new System.Drawing.Point(0, 332);
            this.admin_managetickets_btn.Margin = new System.Windows.Forms.Padding(0);
            this.admin_managetickets_btn.Name = "admin_managetickets_btn";
            this.admin_managetickets_btn.Size = new System.Drawing.Size(210, 47);
            this.admin_managetickets_btn.TabIndex = 1;
            this.admin_managetickets_btn.Text = "Manage Tickets";
            this.admin_managetickets_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_managetickets_btn.UseVisualStyleBackColor = true;
            this.admin_managetickets_btn.Click += new System.EventHandler(this.admin_managetickets_btn_Click);
            this.admin_managetickets_btn.Leave += new System.EventHandler(this.admin_managetickets_btn_Leave);
            // 
            // admin_manageusers_btn
            // 
            this.admin_manageusers_btn.FlatAppearance.BorderSize = 0;
            this.admin_manageusers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_manageusers_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.admin_manageusers_btn.ForeColor = System.Drawing.Color.White;
            this.admin_manageusers_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.user;
            this.admin_manageusers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_manageusers_btn.Location = new System.Drawing.Point(0, 285);
            this.admin_manageusers_btn.Margin = new System.Windows.Forms.Padding(0);
            this.admin_manageusers_btn.Name = "admin_manageusers_btn";
            this.admin_manageusers_btn.Size = new System.Drawing.Size(210, 47);
            this.admin_manageusers_btn.TabIndex = 1;
            this.admin_manageusers_btn.Text = "Manage Users";
            this.admin_manageusers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_manageusers_btn.UseVisualStyleBackColor = true;
            this.admin_manageusers_btn.Click += new System.EventHandler(this.admin_manageusers_btn_Click);
            this.admin_manageusers_btn.Leave += new System.EventHandler(this.admin_manageusers_btn_Leave);
            // 
            // admin_managemovies_btn
            // 
            this.admin_managemovies_btn.FlatAppearance.BorderSize = 0;
            this.admin_managemovies_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_managemovies_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.admin_managemovies_btn.ForeColor = System.Drawing.Color.White;
            this.admin_managemovies_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.movie;
            this.admin_managemovies_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_managemovies_btn.Location = new System.Drawing.Point(0, 238);
            this.admin_managemovies_btn.Margin = new System.Windows.Forms.Padding(0);
            this.admin_managemovies_btn.Name = "admin_managemovies_btn";
            this.admin_managemovies_btn.Size = new System.Drawing.Size(210, 47);
            this.admin_managemovies_btn.TabIndex = 1;
            this.admin_managemovies_btn.Text = "Manage Movies";
            this.admin_managemovies_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_managemovies_btn.UseVisualStyleBackColor = true;
            this.admin_managemovies_btn.Click += new System.EventHandler(this.admin_managemovies_btn_Click);
            this.admin_managemovies_btn.Leave += new System.EventHandler(this.admin_managemovies_btn_Leave);
            // 
            // admin_dashboard_btn
            // 
            this.admin_dashboard_btn.FlatAppearance.BorderSize = 0;
            this.admin_dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_dashboard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.admin_dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.admin_dashboard_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.dashboard;
            this.admin_dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_dashboard_btn.Location = new System.Drawing.Point(0, 191);
            this.admin_dashboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.admin_dashboard_btn.Name = "admin_dashboard_btn";
            this.admin_dashboard_btn.Size = new System.Drawing.Size(210, 47);
            this.admin_dashboard_btn.TabIndex = 1;
            this.admin_dashboard_btn.Text = "Dashboard";
            this.admin_dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_dashboard_btn.UseVisualStyleBackColor = true;
            this.admin_dashboard_btn.Click += new System.EventHandler(this.admin_dashboard_btn_Click);
            this.admin_dashboard_btn.Leave += new System.EventHandler(this.admin_dashboard_btn_Leave);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 741);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin_dashboard_btn;
        private System.Windows.Forms.Button admin_managetickets_btn;
        private System.Windows.Forms.Button admin_manageusers_btn;
        private System.Windows.Forms.Button admin_managemovies_btn;
        private System.Windows.Forms.Button admin_logout_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label admin_username_lbl;
    }
}