using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema
{
    public partial class ChangeFilms : Form
    {
        public byte[] photos;
        int myGenre, myCountry, myRating;
        string newGenre, newCountry, newRating;

        public ChangeFilms()

        {
            InitializeComponent();
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                using (CinemaEntities1 db = new CinemaEntities1())
                {
                    if (txtName.Text == "" || txtPhoto.Text == "" || txtDescription.Text == "" || txtDirector.Text == "" || txtRelizeDate.Text == ""
                        || txtDuration.Text == "" || txtGenre.SelectedItem == null || txtReting.SelectedItem == null || txtCountry.SelectedItem == null)
                    {
                        MessageBox.Show("Введите все данные!");
                    }
                    else
                    {
                        Film film = new Film(txtName.Text, txtDescription.Text, Convert.ToInt32(txtRelizeDate.Text), myCountry, txtDirector.Text, myGenre, myRating, txtDuration.Text, photos);
                        db.Film.Add(film);
                        db.SaveChanges();
                        MessageBox.Show("Фильм был добавлен успешно!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.filmTableAdapter.Fill(this.cinemaDataSet.Film);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                foreach (Film film in db.Film)
                {
                    if (Convert.ToInt32(txtFilm.Text) == film.FilmID)
                    {
                        film.Title = txtName.Text;
                        film.Photo = photos;
                        film.FilmDescription = txtDescription.Text;
                        film.Director = txtDirector.Text;
                        film.ReleaseDate = Convert.ToInt32(txtRelizeDate.Text);
                        film.Duration = txtDuration.Text;
                        film.GenreID = myGenre;
                        film.Duration = txtDuration.Text;
                        film.CountryID = myCountry;
                        film.RatingID = myRating;
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Данные изменены успешно!");
            }
            this.filmTableAdapter.Update(this.cinemaDataSet.Film);
        }

        private void ChangeFilms_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.cinemaDataSet.Film);
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                foreach(Genre genre in db.Genre)
                    txtGenre.Items.Add(genre.Name);

                foreach (Country genre in db.Country)
                    txtCountry.Items.Add(genre.Name);

                foreach (Rating genre in db.Rating)
                    txtReting.Items.Add(genre.Name);

                foreach (Film genre in db.Film)
                    txtFilm.Items.Add(genre.FilmID);
            }

        }

        private void ChangeFilms_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Auth mainForm = new Auth();
            mainForm.Show();
        }

        private void txtCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                foreach (Country country in db.Country)
                {
                    if (country.Name == txtCountry.SelectedItem.ToString())
                    {
                        myCountry = country.CountryID;
                    }
                }
            }
        }

        private void txtReting_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                foreach (Rating rating in db.Rating)
                {
                    if (rating.Name == txtReting.SelectedItem.ToString())
                    {
                        myRating = rating.RatingID;
                    }
                }
            }
        }

        private void txtFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReg.Enabled= false;
            using(CinemaEntities1 db = new CinemaEntities1())
            {
                foreach(Film film  in db.Film)
                {

                    foreach (Genre genre in db.Genre)
                    {
                        if(film.GenreID == genre.GenreID)
                        {
                            newGenre = genre.Name;
                        }
                    }

                    foreach (Country country in db.Country)
                    {
                        if (film.CountryID == country.CountryID)
                        {
                            newCountry = country.Name;
                        }
                    }

                    foreach (Rating country in db.Rating)
                    {
                        if (film.RatingID == country.RatingID)
                        {
                            newRating = country.Name;
                        }
                    }

                    txtName.Text = film.Title;
                    txtPhoto.Text = film.Photo.ToString();
                    txtDescription.Text = film.FilmDescription;
                    txtDirector.Text = film.Director;
                    txtRelizeDate.Text = film.ReleaseDate.ToString();
                    txtDuration.Text = film.Duration;
                    txtGenre.SelectedItem = newGenre;
                    txtCountry.SelectedItem = newCountry;
                    txtReting.SelectedItem = newRating;
                    txtDuration.Text = film.Duration;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ImageFiles(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | Allfiles(*.*) | *.* ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.photos = File.ReadAllBytes(openFileDialog.FileName);
                    txtPhoto.Text = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка!");
                }
            }
        }

        private void txtGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(CinemaEntities1 db = new CinemaEntities1())
            {
                foreach (Genre genre in db.Genre)
                {
                    if (genre.Name == txtGenre.SelectedItem.ToString())
                    {
                        myGenre = genre.GenreID;
                    }
                }
            }
        }
    }
}
