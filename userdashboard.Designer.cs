namespace MovieTicketBookingManagementSystem
{
    partial class userdashboard
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
            this.menu_pnl = new System.Windows.Forms.Panel();
            this.admin_username_lbl = new System.Windows.Forms.Label();
            this.admin_logout_btn = new System.Windows.Forms.Button();
            this.avatar_pb = new System.Windows.Forms.PictureBox();
            this.yourticket_btn = new System.Windows.Forms.Button();
            this.listofmovie_btn = new System.Windows.Forms.Button();
            this.list_pnl = new System.Windows.Forms.Panel();
            this.top_pnl = new System.Windows.Forms.Panel();
            this.list_lbl = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.menu_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pb)).BeginInit();
            this.list_pnl.SuspendLayout();
            this.top_pnl.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_pnl
            // 
            this.menu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.menu_pnl.Controls.Add(this.admin_username_lbl);
            this.menu_pnl.Controls.Add(this.admin_logout_btn);
            this.menu_pnl.Controls.Add(this.avatar_pb);
            this.menu_pnl.Controls.Add(this.yourticket_btn);
            this.menu_pnl.Controls.Add(this.listofmovie_btn);
            this.menu_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_pnl.Location = new System.Drawing.Point(0, 0);
            this.menu_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.menu_pnl.Name = "menu_pnl";
            this.menu_pnl.Size = new System.Drawing.Size(210, 570);
            this.menu_pnl.TabIndex = 2;
            this.menu_pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_pnl_MouseDown);
            this.menu_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menu_pnl_MouseMove);
            // 
            // admin_username_lbl
            // 
            this.admin_username_lbl.AutoSize = true;
            this.admin_username_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username_lbl.ForeColor = System.Drawing.Color.White;
            this.admin_username_lbl.Location = new System.Drawing.Point(81, 124);
            this.admin_username_lbl.Name = "admin_username_lbl";
            this.admin_username_lbl.Size = new System.Drawing.Size(46, 18);
            this.admin_username_lbl.TabIndex = 1;
            this.admin_username_lbl.Text = "User";
            this.admin_username_lbl.Click += new System.EventHandler(this.admin_username_lbl_Click);
            // 
            // admin_logout_btn
            // 
            this.admin_logout_btn.BackColor = System.Drawing.Color.White;
            this.admin_logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin_logout_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_logout_btn.Location = new System.Drawing.Point(64, 517);
            this.admin_logout_btn.Name = "admin_logout_btn";
            this.admin_logout_btn.Size = new System.Drawing.Size(92, 44);
            this.admin_logout_btn.TabIndex = 13;
            this.admin_logout_btn.Text = "Log out";
            this.admin_logout_btn.UseVisualStyleBackColor = false;
            this.admin_logout_btn.Click += new System.EventHandler(this.admin_logout_btn_Click);
            // 
            // avatar_pb
            // 
            this.avatar_pb.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.circleUser;
            this.avatar_pb.Location = new System.Drawing.Point(64, 21);
            this.avatar_pb.Name = "avatar_pb";
            this.avatar_pb.Size = new System.Drawing.Size(80, 80);
            this.avatar_pb.TabIndex = 0;
            this.avatar_pb.TabStop = false;
            // 
            // yourticket_btn
            // 
            this.yourticket_btn.FlatAppearance.BorderSize = 0;
            this.yourticket_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourticket_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.yourticket_btn.ForeColor = System.Drawing.Color.White;
            this.yourticket_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.ticket;
            this.yourticket_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yourticket_btn.Location = new System.Drawing.Point(0, 235);
            this.yourticket_btn.Margin = new System.Windows.Forms.Padding(0);
            this.yourticket_btn.Name = "yourticket_btn";
            this.yourticket_btn.Size = new System.Drawing.Size(210, 47);
            this.yourticket_btn.TabIndex = 1;
            this.yourticket_btn.Text = "Your ticket";
            this.yourticket_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yourticket_btn.UseVisualStyleBackColor = true;
            this.yourticket_btn.Click += new System.EventHandler(this.yourticket_btn_Click);
            // 
            // listofmovie_btn
            // 
            this.listofmovie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.listofmovie_btn.FlatAppearance.BorderSize = 0;
            this.listofmovie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listofmovie_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.listofmovie_btn.ForeColor = System.Drawing.Color.White;
            this.listofmovie_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.listofmovie;
            this.listofmovie_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listofmovie_btn.Location = new System.Drawing.Point(0, 188);
            this.listofmovie_btn.Margin = new System.Windows.Forms.Padding(0);
            this.listofmovie_btn.Name = "listofmovie_btn";
            this.listofmovie_btn.Size = new System.Drawing.Size(210, 47);
            this.listofmovie_btn.TabIndex = 1;
            this.listofmovie_btn.Text = "List of movies";
            this.listofmovie_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listofmovie_btn.UseVisualStyleBackColor = false;
            this.listofmovie_btn.Click += new System.EventHandler(this.listofmovie_Click);
            // 
            // list_pnl
            // 
            this.list_pnl.Controls.Add(this.top_pnl);
            this.list_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_pnl.Location = new System.Drawing.Point(210, 0);
            this.list_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.list_pnl.Name = "list_pnl";
            this.list_pnl.Size = new System.Drawing.Size(573, 570);
            this.list_pnl.TabIndex = 3;
            // 
            // top_pnl
            // 
            this.top_pnl.BackColor = System.Drawing.Color.Navy;
            this.top_pnl.Controls.Add(this.list_lbl);
            this.top_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_pnl.Location = new System.Drawing.Point(0, 0);
            this.top_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(573, 36);
            this.top_pnl.TabIndex = 0;
            // 
            // list_lbl
            // 
            this.list_lbl.AutoSize = true;
            this.list_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list_lbl.Location = new System.Drawing.Point(18, 10);
            this.list_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.list_lbl.Name = "list_lbl";
            this.list_lbl.Size = new System.Drawing.Size(97, 20);
            this.list_lbl.TabIndex = 0;
            this.list_lbl.Text = "List of Movie";
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.list_pnl);
            this.main_panel.Controls.Add(this.menu_pnl);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(783, 570);
            this.main_panel.TabIndex = 4;
            // 
            // userdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 570);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userdashboard";
            this.Load += new System.EventHandler(this.userdashboard_Load);
            this.menu_pnl.ResumeLayout(false);
            this.menu_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pb)).EndInit();
            this.list_pnl.ResumeLayout(false);
            this.top_pnl.ResumeLayout(false);
            this.top_pnl.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_pnl;
        private System.Windows.Forms.Label admin_username_lbl;
        private System.Windows.Forms.PictureBox avatar_pb;
        private System.Windows.Forms.Button admin_logout_btn;
        private System.Windows.Forms.Button yourticket_btn;
        private System.Windows.Forms.Button listofmovie_btn;
        private System.Windows.Forms.Panel list_pnl;
        private System.Windows.Forms.Panel top_pnl;
        private System.Windows.Forms.Label list_lbl;
        private System.Windows.Forms.Panel main_panel;
    }
}