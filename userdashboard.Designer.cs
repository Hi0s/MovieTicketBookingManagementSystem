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
            this.info_pnl = new System.Windows.Forms.Panel();
            this.admin_username_lbl = new System.Windows.Forms.Label();
            this.admin_logout_btn = new System.Windows.Forms.Button();
            this.manage_movies_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yourticket_btn = new System.Windows.Forms.Button();
            this.listofmovie_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.menu_pnl.SuspendLayout();
            this.info_pnl.SuspendLayout();
            this.manage_movies_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_pnl
            // 
            this.menu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.menu_pnl.Controls.Add(this.info_pnl);
            this.menu_pnl.Controls.Add(this.admin_logout_btn);
            this.menu_pnl.Controls.Add(this.yourticket_btn);
            this.menu_pnl.Controls.Add(this.listofmovie_btn);
            this.menu_pnl.Location = new System.Drawing.Point(-4, 0);
            this.menu_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.menu_pnl.Name = "menu_pnl";
            this.menu_pnl.Size = new System.Drawing.Size(280, 872);
            this.menu_pnl.TabIndex = 2;
            // 
            // info_pnl
            // 
            this.info_pnl.Controls.Add(this.admin_username_lbl);
            this.info_pnl.Controls.Add(this.pictureBox1);
            this.info_pnl.Location = new System.Drawing.Point(4, 0);
            this.info_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.info_pnl.Name = "info_pnl";
            this.info_pnl.Size = new System.Drawing.Size(276, 251);
            this.info_pnl.TabIndex = 14;
            // 
            // admin_username_lbl
            // 
            this.admin_username_lbl.AutoSize = true;
            this.admin_username_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username_lbl.ForeColor = System.Drawing.Color.White;
            this.admin_username_lbl.Location = new System.Drawing.Point(77, 137);
            this.admin_username_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admin_username_lbl.Name = "admin_username_lbl";
            this.admin_username_lbl.Size = new System.Drawing.Size(119, 23);
            this.admin_username_lbl.TabIndex = 1;
            this.admin_username_lbl.Text = "User Name";
            // 
            // admin_logout_btn
            // 
            this.admin_logout_btn.BackColor = System.Drawing.Color.White;
            this.admin_logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin_logout_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_logout_btn.Location = new System.Drawing.Point(85, 689);
            this.admin_logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.admin_logout_btn.Name = "admin_logout_btn";
            this.admin_logout_btn.Size = new System.Drawing.Size(123, 59);
            this.admin_logout_btn.TabIndex = 13;
            this.admin_logout_btn.Text = "Log out";
            this.admin_logout_btn.UseVisualStyleBackColor = false;
            this.admin_logout_btn.Click += new System.EventHandler(this.admin_logout_btn_Click);
            // 
            // manage_movies_pnl
            // 
            this.manage_movies_pnl.Controls.Add(this.pictureBox7);
            this.manage_movies_pnl.Controls.Add(this.pictureBox6);
            this.manage_movies_pnl.Controls.Add(this.pictureBox5);
            this.manage_movies_pnl.Controls.Add(this.pictureBox4);
            this.manage_movies_pnl.Controls.Add(this.pictureBox3);
            this.manage_movies_pnl.Controls.Add(this.pictureBox2);
            this.manage_movies_pnl.Controls.Add(this.panel1);
            this.manage_movies_pnl.Location = new System.Drawing.Point(276, 0);
            this.manage_movies_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.manage_movies_pnl.Name = "manage_movies_pnl";
            this.manage_movies_pnl.Size = new System.Drawing.Size(773, 872);
            this.manage_movies_pnl.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Movie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.circleUser;
            this.pictureBox1.Location = new System.Drawing.Point(81, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // yourticket_btn
            // 
            this.yourticket_btn.FlatAppearance.BorderSize = 0;
            this.yourticket_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourticket_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.yourticket_btn.ForeColor = System.Drawing.Color.White;
            this.yourticket_btn.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.ticket;
            this.yourticket_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yourticket_btn.Location = new System.Drawing.Point(0, 314);
            this.yourticket_btn.Margin = new System.Windows.Forms.Padding(0);
            this.yourticket_btn.Name = "yourticket_btn";
            this.yourticket_btn.Size = new System.Drawing.Size(280, 63);
            this.yourticket_btn.TabIndex = 1;
            this.yourticket_btn.Text = "Your ticket";
            this.yourticket_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yourticket_btn.UseVisualStyleBackColor = true;
            this.yourticket_btn.Click += new System.EventHandler(this.yourticket_btn_Click);
            this.yourticket_btn.Leave += new System.EventHandler(this.yourticket_btn_Leave);
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
            this.listofmovie_btn.Location = new System.Drawing.Point(0, 251);
            this.listofmovie_btn.Margin = new System.Windows.Forms.Padding(0);
            this.listofmovie_btn.Name = "listofmovie_btn";
            this.listofmovie_btn.Size = new System.Drawing.Size(280, 63);
            this.listofmovie_btn.TabIndex = 1;
            this.listofmovie_btn.Text = "List of movies";
            this.listofmovie_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listofmovie_btn.UseVisualStyleBackColor = false;
            this.listofmovie_btn.Click += new System.EventHandler(this.listofmovie_Click);
            this.listofmovie_btn.Leave += new System.EventHandler(this.listofmovie_btn_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(76, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 191);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(553, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 191);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(312, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 191);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(312, 382);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(149, 191);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(553, 382);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(149, 191);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(76, 382);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(149, 191);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // userdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 761);
            this.Controls.Add(this.menu_pnl);
            this.Controls.Add(this.manage_movies_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userdashboard";
            this.Text = "userdashboard";
            this.Load += new System.EventHandler(this.userdashboard_Load);
            this.menu_pnl.ResumeLayout(false);
            this.info_pnl.ResumeLayout(false);
            this.info_pnl.PerformLayout();
            this.manage_movies_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_pnl;
        private System.Windows.Forms.Panel info_pnl;
        private System.Windows.Forms.Label admin_username_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button admin_logout_btn;
        private System.Windows.Forms.Button yourticket_btn;
        private System.Windows.Forms.Button listofmovie_btn;
        private System.Windows.Forms.Panel manage_movies_pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}