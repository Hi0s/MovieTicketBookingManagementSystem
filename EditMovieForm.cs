using MovieTicketBookingManagementSystem.Config;
using MovieTicketBookingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MovieTicketBookingManagementSystem
{
    public partial class EditMovieForm : Form
    {
        Point lastPoint;
        public event EventHandler RequestClose;
        private List<Movies> moviesList;
        private Movies selectedMovie;

        public EditMovieForm()
        {
            InitializeComponent();

        }


        private void editmovie_return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditMovieForm_Load(object sender, EventArgs e)
        {
            // Query the database to get the movie and showtime details
            moviesList = AdminService.GetMoviesList();
            foreach (Movies movie in moviesList)
            {
                editmovie_slmovie_cb.DisplayMember = "Title";
                editmovie_slmovie_cb.ValueMember = "MovieID";
                editmovie_slmovie_cb.DataSource = moviesList;
            }



        }

        private void EditMovieForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EditMovieForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.ParentForm != null)
            {
                this.ParentForm.Left += e.X - lastPoint.X;
                this.ParentForm.Top += e.Y - lastPoint.Y;
            }
        }

        private void editmovie_ID_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMovie = moviesList.FirstOrDefault(m => m.MovieID == (int)editmovie_slmovie_cb.SelectedValue);
            if (selectedMovie != null)
            {
                editmovie_title_txt.Text = selectedMovie.Title;
                editmovie_genre_txt.Text = selectedMovie.Genre;
                editmovie_duration_txt.Text = selectedMovie.Duration.ToString();
                editmovie_description_txt.Text = selectedMovie.Description;
                editmovie_rating_txt.Text = selectedMovie.Rating.ToString();
                editmovie_release_datepicker.Value = selectedMovie.ReleaseDate;
                editmovie_price_txt.Text = selectedMovie.Pricing.ToString();
                editmovie_posterpath_lbl.Text = selectedMovie.PosterImagePath != null ?
                    Path.GetFileName(selectedMovie.PosterImagePath) : "No file chosen";
                editmovie_active_rd.Checked = selectedMovie.IsActive;
                editmovie_inactive_rd.Checked = !selectedMovie.IsActive;
                editmovie_CreatedAt_lbl.Text = $"Created At:           {selectedMovie.CreatedAt.ToString("M/d/yyyy")}";
            }
            else
            {
                MessageBox.Show("Please select a valid movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editmovie_poster_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                selectedMovie.PosterImagePath = openFileDialog.FileName;
                editmovie_posterpath_lbl.Text = $"{Path.GetFileName(selectedMovie.PosterImagePath)}";
                selectedMovie.PosterImagePath = @"Resources\" + Path.GetFileName(editmovie_posterpath_lbl.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please select a poster image", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editmovie_save_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateMovieFields()) return;
            selectedMovie.Title = editmovie_title_txt.Text.Trim();
            selectedMovie.Description = editmovie_description_txt.Text.Trim();
            selectedMovie.Duration = int.Parse(editmovie_duration_txt.Text.Trim());
            selectedMovie.Genre = editmovie_genre_txt.Text.Trim();
            selectedMovie.Rating = editmovie_rating_txt.Text.Trim();
            selectedMovie.Pricing = int.Parse(editmovie_price_txt.Text.Trim());
            selectedMovie.ReleaseDate = editmovie_release_datepicker.Value;
            selectedMovie.IsActive = editmovie_active_rd.Checked ? true :
                editmovie_inactive_rd.Checked ? false : throw new InvalidOperationException("Please select an active status.");

            AdminService.UpdateMovie(selectedMovie);
            MessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RequestClose?.Invoke(this, EventArgs.Empty);
        }

        private bool ValidateMovieFields()
        {
            if (string.IsNullOrWhiteSpace(editmovie_title_txt.Text))
            {
                MessageBox.Show("Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(editmovie_genre_txt.Text))
            {
                MessageBox.Show("Genre cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(editmovie_duration_txt.Text.Trim(), out int duration) || duration <= 0)
            {
                MessageBox.Show("Duration must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(editmovie_description_txt.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(editmovie_rating_txt.Text))
            {
                MessageBox.Show("Rating cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(editmovie_posterpath_lbl.Text) || editmovie_posterpath_lbl.Text.Trim() == "No file chosen")
            {
                MessageBox.Show("Please select a poster image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(editmovie_price_txt.Text))
            {
                MessageBox.Show("Price cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void editmovie_active_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (editmovie_active_rd.Checked)
            {
                editmovie_inactive_rd.Checked = false;
            }
        }

        private void editmovie_inactive_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (editmovie_inactive_rd.Checked)
            {
                editmovie_active_rd.Checked = false;
            }
        }
    }
}
