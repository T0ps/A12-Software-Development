using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

//using Newtonsoft.Json.Linq; // Implement?

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string searchVal;
        public string uri;
        public string json;
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchVal = searchBar.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchFunction = "http://www.omdbapi.com/?apikey=d111ba84&" + "t=" + searchVal + "&r=xml";
            System.Diagnostics.Process.Start(searchFunction);

            XDocument film = XDocument.Load(searchFunction);

            if (!isValidFilm(film)) // Check if the film is in the database
            {
                return;
            }

            //Set the current film Node attributes
            //BY THE WAY: this is a really long winded way round doing it
            //It would be better to have a function here that resets them/sets them instead of individually
            movieName.Text = "";
            movieYear.Text = "";
            movieGenre.Text = "";
            movieRating.Text = "";
            movieAwards.Text = "";
            var Film = new
            {
                Name = (string)film.Root.Element("movie").Attribute("title").Value,
                Year = (string)film.Root.Element("movie").Attribute("year").Value,
                Genre = (string)film.Root.Element("movie").Attribute("genre").Value,
                Rating = (string)film.Root.Element("movie").Attribute("imdbRating").Value,
                Awards = (string)film.Root.Element("movie").Attribute("awards").Value,
            };
            movieName.Text = Film.Name;
            movieYear.Text = Film.Year;
            movieGenre.Text = Film.Genre;
            movieRating.Text = Film.Rating;
            movieAwards.Text = Film.Awards;
        }

        private bool isValidFilm(XDocument xml) //Method to check if the movie is valid
        {
            try
            {
                string response = xml.Root.Attribute("response").Value;
                if(response == "True"){ return true; }
            }
            catch
            {
                MessageBox.Show("This is an Invalid Movie."); searchBar.Text = "";
                return false;
            }
            MessageBox.Show("This is an Invalid Movie."); searchBar.Text = "";
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void movieYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void movieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void movieGenre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
