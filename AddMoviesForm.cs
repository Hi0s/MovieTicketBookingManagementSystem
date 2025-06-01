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
using MovieTicketBookingManagementSystem.Models;

namespace MovieTicketBookingManagementSystem
{

    public partial class AddMoviesForm : Form
    {
        Point lastPoint;
        public event EventHandler RequestClose;
        string poster_path;
        private readonly string connString = DatabaseConfig.ConnectionString;

        public AddMoviesForm()
        {
            InitializeComponent();
        }
        private bool ValidateMovieFields()
        {
            if (string.IsNullOrWhiteSpace(addmovie_title_txt.Text))
            {
                MessageBox.Show("Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(addmovie_genre_txt.Text))
            {
                MessageBox.Show("Genre cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(addmovie_duration_txt.Text.Trim(), out int duration) || duration <= 0)
            {
                MessageBox.Show("Duration must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(addmovie_description_txt.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(addmovie_rating_txt.Text))
            {
                MessageBox.Show("Rating cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(addmovie_posterpath_lbl.Text) || addmovie_posterpath_lbl.Text.Trim() == "No file chosen")
            {
                MessageBox.Show("Please select a poster image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(addmovie_price_txt.Text.Trim(), out int pricing) || pricing <= 0)
            {
                MessageBox.Show("Price cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void addmovie_btn_Click(object sender, EventArgs e)
        {
            if(ValidateMovieFields())
            {
                
                // Code to add movie to database using AdminService
                Movies movie = new Movies();
                movie.Title=addmovie_title_txt.Text.Trim();
                movie.Description = addmovie_description_txt.Text.Trim();
                movie.Genre = addmovie_genre_txt.Text.Trim();
                movie.Duration= int.Parse(addmovie_duration_txt.Text.Trim());
                movie.Rating = addmovie_rating_txt.Text.Trim();
                movie.Pricing = int.Parse(addmovie_price_txt.Text.Trim());
                movie.ReleaseDate = addmovie_release_datepicker.Value;
                movie.PosterImagePath = poster_path.Trim();
                movie.CreatedAt = DateTime.Now; // Set CreatedAt to current date and time

                AdminService.AddMovie(movie);


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

        private void AddMoviesForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.ParentForm != null)
            {
                this.ParentForm.Left += e.X - lastPoint.X;
                this.ParentForm.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddMoviesForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
