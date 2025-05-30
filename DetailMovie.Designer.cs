namespace MovieTicketBookingManagementSystem
{
    partial class DetailMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.poster_movie = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblGenreValue = new System.Windows.Forms.Label();
            this.lblDurationValue = new System.Windows.Forms.Label();
            this.lblRated = new System.Windows.Forms.Label();
            this.lblRatedValue = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblReleaseValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_movie)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 323);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.poster_movie);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(900, 323);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // poster_movie
            // 
            this.poster_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poster_movie.Location = new System.Drawing.Point(0, 0);
            this.poster_movie.Name = "poster_movie";
            this.poster_movie.Size = new System.Drawing.Size(220, 323);
            this.poster_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster_movie.TabIndex = 0;
            this.poster_movie.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGenre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGenreValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDurationValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRated, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRatedValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDuration, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRelease, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblReleaseValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(670, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIM ĐIỆN ẢNH DORAEMON: NOBITA VÀ CUỘC PHIÊU LƯU VÀO THẾ GIỚI TRONG TRANH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenre.Location = new System.Drawing.Point(3, 64);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(53, 19);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenreValue
            // 
            this.lblGenreValue.AutoSize = true;
            this.lblGenreValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGenreValue.Location = new System.Drawing.Point(102, 64);
            this.lblGenreValue.Name = "lblGenreValue";
            this.lblGenreValue.Size = new System.Drawing.Size(140, 19);
            this.lblGenreValue.TabIndex = 6;
            this.lblGenreValue.Text = "Hoạt Hình, Phiêu Lưu";
            this.lblGenreValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDurationValue
            // 
            this.lblDurationValue.AutoSize = true;
            this.lblDurationValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDurationValue.Location = new System.Drawing.Point(102, 102);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(66, 19);
            this.lblDurationValue.TabIndex = 10;
            this.lblDurationValue.Text = "105 phút";
            this.lblDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRated
            // 
            this.lblRated.AutoSize = true;
            this.lblRated.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRated.Location = new System.Drawing.Point(3, 121);
            this.lblRated.Name = "lblRated";
            this.lblRated.Size = new System.Drawing.Size(52, 19);
            this.lblRated.TabIndex = 13;
            this.lblRated.Text = "Rated:";
            this.lblRated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRatedValue
            // 
            this.lblRatedValue.AutoSize = true;
            this.lblRatedValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRatedValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRatedValue.Location = new System.Drawing.Point(102, 121);
            this.lblRatedValue.Name = "lblRatedValue";
            this.lblRatedValue.Size = new System.Drawing.Size(18, 19);
            this.lblRatedValue.TabIndex = 14;
            this.lblRatedValue.Text = "P";
            this.lblRatedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDescription.Location = new System.Drawing.Point(3, 140);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(89, 19);
            this.lbDescription.TabIndex = 15;
            this.lbDescription.Text = "Description:";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDuration.Location = new System.Drawing.Point(3, 83);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(71, 19);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRelease.Location = new System.Drawing.Point(3, 102);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(64, 19);
            this.lblRelease.TabIndex = 7;
            this.lblRelease.Text = "Release:";
            this.lblRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReleaseValue
            // 
            this.lblReleaseValue.AutoSize = true;
            this.lblReleaseValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReleaseValue.Location = new System.Drawing.Point(102, 83);
            this.lblReleaseValue.Name = "lblReleaseValue";
            this.lblReleaseValue.Size = new System.Drawing.Size(83, 19);
            this.lblReleaseValue.TabIndex = 8;
            this.lblReleaseValue.Text = "23/05/2025";
            this.lblReleaseValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReleaseValue.Click += new System.EventHandler(this.lblReleaseValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(102, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "sad asdklasjd klasjd klasj dklasj dklasj dklasj kldjas kldjas kldjas kldjaslk jda" +
    "skl jdakls jkaldj askljd aklsdj askldj aslkjd kalsjd kalsjd klasjd klas das das " +
    "das das da ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetailMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 323);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailMovie";
            this.Text = "DetailMovie";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poster_movie)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox poster_movie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblGenreValue;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblReleaseValue;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationValue;
        private System.Windows.Forms.Label lblRated;
        private System.Windows.Forms.Label lblRatedValue;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label1;
    }
}