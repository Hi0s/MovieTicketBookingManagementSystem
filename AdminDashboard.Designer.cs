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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu_pnl = new System.Windows.Forms.Panel();
            this.info_pnl = new System.Windows.Forms.Panel();
            this.admin_username_lbl = new System.Windows.Forms.Label();
            this.admin_logout_btn = new System.Windows.Forms.Button();
            this.manage_movies_pnl = new System.Windows.Forms.Panel();
            this.admin_movieedit_btn = new System.Windows.Forms.Button();
            this.admin_addshowtime_btn = new System.Windows.Forms.Button();
            this.admin_addmovies_btn = new System.Windows.Forms.Button();
            this.manage_movie_datagridview = new System.Windows.Forms.DataGridView();
            this.admin_avatar_pic = new System.Windows.Forms.PictureBox();
            this.admin_managetickets_btn = new System.Windows.Forms.Button();
            this.admin_manageusers_btn = new System.Windows.Forms.Button();
            this.admin_managemovies_btn = new System.Windows.Forms.Button();
            this.admin_dashboard_btn = new System.Windows.Forms.Button();
            this.menu_pnl.SuspendLayout();
            this.info_pnl.SuspendLayout();
            this.manage_movies_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manage_movie_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_avatar_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_pnl
            // 
            this.menu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.menu_pnl.Controls.Add(this.info_pnl);
            this.menu_pnl.Controls.Add(this.admin_logout_btn);
            this.menu_pnl.Controls.Add(this.admin_managetickets_btn);
            this.menu_pnl.Controls.Add(this.admin_manageusers_btn);
            this.menu_pnl.Controls.Add(this.admin_managemovies_btn);
            this.menu_pnl.Controls.Add(this.admin_dashboard_btn);
            this.menu_pnl.Location = new System.Drawing.Point(-7, 0);
            this.menu_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.menu_pnl.Name = "menu_pnl";
            this.menu_pnl.Size = new System.Drawing.Size(210, 741);
            this.menu_pnl.TabIndex = 0;
            // 
            // info_pnl
            // 
            this.info_pnl.Controls.Add(this.admin_username_lbl);
            this.info_pnl.Controls.Add(this.admin_avatar_pic);
            this.info_pnl.Location = new System.Drawing.Point(3, 0);
            this.info_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.info_pnl.Name = "info_pnl";
            this.info_pnl.Size = new System.Drawing.Size(207, 188);
            this.info_pnl.TabIndex = 14;
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
            this.admin_logout_btn.Click += new System.EventHandler(this.admin_logout_btn_Click);
            // 
            // manage_movies_pnl
            // 
            this.manage_movies_pnl.Controls.Add(this.admin_movieedit_btn);
            this.manage_movies_pnl.Controls.Add(this.admin_addshowtime_btn);
            this.manage_movies_pnl.Controls.Add(this.admin_addmovies_btn);
            this.manage_movies_pnl.Controls.Add(this.manage_movie_datagridview);
            this.manage_movies_pnl.Location = new System.Drawing.Point(203, 0);
            this.manage_movies_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.manage_movies_pnl.Name = "manage_movies_pnl";
            this.manage_movies_pnl.Size = new System.Drawing.Size(582, 741);
            this.manage_movies_pnl.TabIndex = 1;
            this.manage_movies_pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manage_movies_pnl_MouseDown);
            this.manage_movies_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.manage_movies_pnl_MouseMove);
            // 
            // admin_movieedit_btn
            // 
            this.admin_movieedit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_movieedit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_movieedit_btn.FlatAppearance.BorderSize = 0;
            this.admin_movieedit_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.admin_movieedit_btn.ForeColor = System.Drawing.Color.White;
            this.admin_movieedit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_movieedit_btn.Location = new System.Drawing.Point(188, 649);
            this.admin_movieedit_btn.Margin = new System.Windows.Forms.Padding(0);
            this.admin_movieedit_btn.Name = "admin_movieedit_btn";
            this.admin_movieedit_btn.Size = new System.Drawing.Size(125, 44);
            this.admin_movieedit_btn.TabIndex = 16;
            this.admin_movieedit_btn.Text = "Edit movie";
            this.admin_movieedit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_movieedit_btn.UseVisualStyleBackColor = false;
            this.admin_movieedit_btn.Click += new System.EventHandler(this.admin_movieedit_btn_Click);
            // 
            // admin_addshowtime_btn
            // 
            this.admin_addshowtime_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_addshowtime_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_addshowtime_btn.FlatAppearance.BorderSize = 0;
            this.admin_addshowtime_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.admin_addshowtime_btn.ForeColor = System.Drawing.Color.White;
            this.admin_addshowtime_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_addshowtime_btn.Location = new System.Drawing.Point(166, 68);
            this.admin_addshowtime_btn.Margin = new System.Windows.Forms.Padding(0);
            this.admin_addshowtime_btn.Name = "admin_addshowtime_btn";
            this.admin_addshowtime_btn.Size = new System.Drawing.Size(170, 60);
            this.admin_addshowtime_btn.TabIndex = 16;
            this.admin_addshowtime_btn.Text = "+ Add Showtime";
            this.admin_addshowtime_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_addshowtime_btn.UseVisualStyleBackColor = false;
            this.admin_addshowtime_btn.Click += new System.EventHandler(this.admin_addshowtime_btn_Click);
            // 
            // admin_addmovies_btn
            // 
            this.admin_addmovies_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_addmovies_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_addmovies_btn.FlatAppearance.BorderSize = 0;
            this.admin_addmovies_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.admin_addmovies_btn.ForeColor = System.Drawing.Color.White;
            this.admin_addmovies_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_addmovies_btn.Location = new System.Drawing.Point(351, 68);
            this.admin_addmovies_btn.Margin = new System.Windows.Forms.Padding(0);
            this.admin_addmovies_btn.Name = "admin_addmovies_btn";
            this.admin_addmovies_btn.Size = new System.Drawing.Size(170, 60);
            this.admin_addmovies_btn.TabIndex = 15;
            this.admin_addmovies_btn.Text = "+ Add Movie";
            this.admin_addmovies_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_addmovies_btn.UseVisualStyleBackColor = false;
            this.admin_addmovies_btn.Click += new System.EventHandler(this.admin_addmovies_btn_Click);
            // 
            // manage_movie_datagridview
            // 
            this.manage_movie_datagridview.AllowUserToAddRows = false;
            this.manage_movie_datagridview.AllowUserToDeleteRows = false;
            this.manage_movie_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.manage_movie_datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manage_movie_datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.manage_movie_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manage_movie_datagridview.Location = new System.Drawing.Point(40, 205);
            this.manage_movie_datagridview.Margin = new System.Windows.Forms.Padding(2);
            this.manage_movie_datagridview.Name = "manage_movie_datagridview";
            this.manage_movie_datagridview.ReadOnly = true;
            this.manage_movie_datagridview.RowTemplate.Height = 24;
            this.manage_movie_datagridview.Size = new System.Drawing.Size(481, 408);
            this.manage_movie_datagridview.TabIndex = 0;
            // 
            // admin_avatar_pic
            // 
            this.admin_avatar_pic.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.circleUser;
            this.admin_avatar_pic.Location = new System.Drawing.Point(61, 12);
            this.admin_avatar_pic.Name = "admin_avatar_pic";
            this.admin_avatar_pic.Size = new System.Drawing.Size(80, 80);
            this.admin_avatar_pic.TabIndex = 0;
            this.admin_avatar_pic.TabStop = false;
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
            // 
            // admin_dashboard_btn
            // 
            this.admin_dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
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
            this.admin_dashboard_btn.UseVisualStyleBackColor = false;
            this.admin_dashboard_btn.Click += new System.EventHandler(this.admin_dashboard_btn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 741);
            this.Controls.Add(this.menu_pnl);
            this.Controls.Add(this.manage_movies_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminDashboard_MouseMove);
            this.menu_pnl.ResumeLayout(false);
            this.info_pnl.ResumeLayout(false);
            this.info_pnl.PerformLayout();
            this.manage_movies_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manage_movie_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_avatar_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_pnl;
        private System.Windows.Forms.Button admin_dashboard_btn;
        private System.Windows.Forms.Button admin_managetickets_btn;
        private System.Windows.Forms.Button admin_manageusers_btn;
        private System.Windows.Forms.Button admin_managemovies_btn;
        private System.Windows.Forms.Button admin_logout_btn;
        private System.Windows.Forms.Panel info_pnl;
        private System.Windows.Forms.PictureBox admin_avatar_pic;
        private System.Windows.Forms.Label admin_username_lbl;
        private System.Windows.Forms.Panel manage_movies_pnl;
        private System.Windows.Forms.DataGridView manage_movie_datagridview;
        private System.Windows.Forms.Button admin_addmovies_btn;
        private System.Windows.Forms.Button admin_addshowtime_btn;
        private System.Windows.Forms.Button admin_movieedit_btn;
    }
}