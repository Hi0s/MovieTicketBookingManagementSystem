using MovieTicketBookingManagementSystem.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem
{

    public partial class AddMoviesForm : Form
    {
        string poster_path;
        private readonly string connString = DatabaseConfig.ConnectionString;

        public AddMoviesForm()
        {
            InitializeComponent();
        }

        private void addmovie_btn_Click(object sender, EventArgs e)
        {
            if(addmovie_title_txt.Text == "" ||
                addmovie_genre_txt.Text == "" ||
                addmovie_duration_txt.Text == "" ||
                addmovie_description_txt.Text == "" ||
                addmovie_rating_txt.Text==""|| addmovie_posterpath_lbl.Text== "No file chosen")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Int32.TryParse(addmovie_duration_txt.Text,out _)==false) {
                MessageBox.Show("Duration must be a number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Code to add movie to database
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO movies (Title, Genre, Duration, Description, Rating, PosterPath, CreatedAt)" +
                        " VALUES (@Title, @Genre, @Duration, @Description, @Rating, @PosterPath,@CreatedAt)";
                    DateTime today = DateTime.Today;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", addmovie_title_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@Genre", addmovie_genre_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@Duration", addmovie_duration_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@Description", addmovie_description_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@Rating", addmovie_rating_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@PosterPath", poster_path.Trim());
                        cmd.Parameters.AddWithValue("@CreatedAt", today);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Movie added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        c.Text = "";
                    }
                }
                addmovie_posterpath_lbl.Text = "No file chosen";
                poster_path = string.Empty; // Reset the poster path
                addmovie_release_datepicker.Value = DateTime.Now; // Reset the release date picker to current date
            }
        }

        private void admin_addmovies_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                poster_path = openFileDialog.FileName;
                addmovie_posterpath_lbl.Text = $"{Path.GetFileName(poster_path)}";
            }
            else
            {
                MessageBox.Show("Please select a poster image", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addmovie_return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
