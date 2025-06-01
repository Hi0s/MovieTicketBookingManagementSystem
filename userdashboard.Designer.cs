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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yourticket_btn = new System.Windows.Forms.Button();
            this.listofmovie_btn = new System.Windows.Forms.Button();
            this.manage_movies_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.manage_movies_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_pnl
            // 
            this.menu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.menu_pnl.Controls.Add(this.admin_username_lbl);
            this.menu_pnl.Controls.Add(this.admin_logout_btn);
            this.menu_pnl.Controls.Add(this.pictureBox1);
            this.menu_pnl.Controls.Add(this.yourticket_btn);
            this.menu_pnl.Controls.Add(this.listofmovie_btn);
            this.menu_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_pnl.Location = new System.Drawing.Point(0, 0);
            this.menu_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.menu_pnl.Name = "menu_pnl";
            this.menu_pnl.Size = new System.Drawing.Size(210, 618);
            this.menu_pnl.TabIndex = 2;
            // 
            // admin_username_lbl
            // 
            this.admin_username_lbl.AutoSize = true;
            this.admin_username_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username_lbl.ForeColor = System.Drawing.Color.White;
            this.admin_username_lbl.Location = new System.Drawing.Point(61, 131);
            this.admin_username_lbl.Name = "admin_username_lbl";
            this.admin_username_lbl.Size = new System.Drawing.Size(96, 18);
            this.admin_username_lbl.TabIndex = 1;
            this.admin_username_lbl.Text = "User Name";
            // 
            // admin_logout_btn
            // 
            this.admin_logout_btn.BackColor = System.Drawing.Color.White;
            this.admin_logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin_logout_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.admin_logout_btn.Location = new System.Drawing.Point(64, 560);
            this.admin_logout_btn.Name = "admin_logout_btn";
            this.admin_logout_btn.Size = new System.Drawing.Size(92, 48);
            this.admin_logout_btn.TabIndex = 13;
            this.admin_logout_btn.Text = "Log out";
            this.admin_logout_btn.UseVisualStyleBackColor = false;
            this.admin_logout_btn.Click += new System.EventHandler(this.admin_logout_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieTicketBookingManagementSystem.Properties.Resources.circleUser;
            this.pictureBox1.Location = new System.Drawing.Point(64, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 87);
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
            this.yourticket_btn.Location = new System.Drawing.Point(0, 255);
            this.yourticket_btn.Margin = new System.Windows.Forms.Padding(0);
            this.yourticket_btn.Name = "yourticket_btn";
            this.yourticket_btn.Size = new System.Drawing.Size(210, 51);
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
            this.listofmovie_btn.Location = new System.Drawing.Point(0, 204);
            this.listofmovie_btn.Margin = new System.Windows.Forms.Padding(0);
            this.listofmovie_btn.Name = "listofmovie_btn";
            this.listofmovie_btn.Size = new System.Drawing.Size(210, 51);
            this.listofmovie_btn.TabIndex = 1;
            this.listofmovie_btn.Text = "List of movies";
            this.listofmovie_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listofmovie_btn.UseVisualStyleBackColor = false;
            this.listofmovie_btn.Click += new System.EventHandler(this.listofmovie_Click);
            this.listofmovie_btn.Leave += new System.EventHandler(this.listofmovie_btn_Leave);
            // 
            // manage_movies_pnl
            // 
            this.manage_movies_pnl.Controls.Add(this.panel1);
            this.manage_movies_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manage_movies_pnl.Location = new System.Drawing.Point(210, 0);
            this.manage_movies_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.manage_movies_pnl.Name = "manage_movies_pnl";
            this.manage_movies_pnl.Size = new System.Drawing.Size(573, 618);
            this.manage_movies_pnl.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Movie";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.manage_movies_pnl);
            this.panel2.Controls.Add(this.menu_pnl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 618);
            this.panel2.TabIndex = 4;
            // 
            // userdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 618);
            this.Controls.Add(this.panel2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userdashboard";
            this.Text = "userdashboard";
            this.Load += new System.EventHandler(this.userdashboard_Load);
            this.menu_pnl.ResumeLayout(false);
            this.menu_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.manage_movies_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_pnl;
        private System.Windows.Forms.Label admin_username_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button admin_logout_btn;
        private System.Windows.Forms.Button yourticket_btn;
        private System.Windows.Forms.Button listofmovie_btn;
        private System.Windows.Forms.Panel manage_movies_pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}