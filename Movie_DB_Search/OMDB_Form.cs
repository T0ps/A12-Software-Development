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
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

//using Newtonsoft.Json.Linq; // Implement?

namespace OMDB_Form
{
    public partial class OMDB_Form : Form
    {
        public string path = "wishlist.txt";
        public string searchVal;
        public string curMovName;
        public string uri;
        public string json;
        public OMDB_Form()
        {
            InitializeComponent();
            if (!File.Exists("wishlist.txt"))
            {
                File.Create("wishlist.txt");

            }
            loadWishList();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchVal = searchBar.Text;
            if (searchVal == "")
            {
                resetMovieData();
            }
            searchMovie();
        }

        private void resetMovieData() // Reset the displayed movie information
        {
            movieName.Text = "";
            movieYear.Text = "";
            movieGenre.Text = "";
            movieRating.Text = "";
            movieAwards.Text = "";
            pictureBox2.Image = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchMovie();
        }

        public void searchMovie()
        {
            var searchFunction = "http://www.omdbapi.com/?apikey=d111ba84&" + "t=" + searchVal + "&r=xml";
            //System.Diagnostics.Process.Start(searchFunction);

            XDocument film = XDocument.Load(searchFunction);

            if (!isValidFilm(film)) // Check if the film is in the database
            {
                return; // exit this
            }

            resetMovieData();
            //Set the current film Node attributes
            //BY THE WAY: this is a really long winded way round doing it
            //It would be better to have a function here that resets them/sets them instead of individually (get:set methods)

            var Film = new
            {
                Name = (string)film.Root.Element("movie").Attribute("title").Value,
                Year = (string)film.Root.Element("movie").Attribute("year").Value,
                Genre = (string)film.Root.Element("movie").Attribute("genre").Value,
                Rating = (string)film.Root.Element("movie").Attribute("imdbRating").Value,
                Awards = (string)film.Root.Element("movie").Attribute("awards").Value,
                Poster = (string)film.Root.Element("movie").Attribute("poster").Value,
            };
            movieName.Text = Film.Name;
            movieYear.Text = Film.Year;
            movieGenre.Text = Film.Genre;
            movieRating.Text = Film.Rating;
            movieAwards.Text = Film.Awards;
            try
            {
                pictureBox2.Load(Film.Poster);
            }
            catch
            {
                pictureBox2.Image = null;
            }
        }

        private bool isValidFilm(XDocument xml) //Method to check if the movie is valid
        {
            try
            {
                string response = xml.Root.Attribute("response").Value;
                if (response == "True")
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void movieYear_TextChanged(object sender, EventArgs e) { }
        private void movieName_TextChanged(object sender, EventArgs e)
        {
            curMovName = movieName.Text;
        }
        private void movieGenre_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = "";
            try
            {
                curItem = listBox1.SelectedItem.ToString();
            }
            catch
            {
                searchBar.Text = curItem;
                searchVal = searchBar.Text;
                return;
            }
            searchBar.Text = curItem;
            searchVal = searchBar.Text;
            searchMovie();
        }

        private void load_wl_Click_1(object sender, EventArgs e)
        {
            loadWishList();
        }

        private void loadWishList()
        {
            Console.WriteLine("WE ARE LOADING!!");
            listBox1.Items.Clear();
            path = "wishlist.txt";
            String[] films = new String[5];

            films = File.ReadAllLines(path);

            foreach (string f in films)
            {
                listBox1.Items.Add(f);
            }
        }

        private void save_wl_Click(object sender, EventArgs e)
        {


            using (StreamReader sr = new StreamReader(path))
            {
                string contents = sr.ReadToEnd();



                if (contents.Contains(curMovName))
                {
                    System.Windows.Forms.MessageBox.Show("Alert already on your wishlist");
                    return;
                }
            }


            int lineCount = File.ReadLines(path).Count();

            if (lineCount >= 5)
            {
                System.Windows.Forms.MessageBox.Show("Alert you have reached 5 items on your wishlist");
            }
            else
            {
                listBox1.Items.Add(curMovName);
                File.AppendAllText(path, curMovName + Environment.NewLine);
            }
        }

        private void delete_wl_Click(object sender, EventArgs e)
        {
            deleteWishList();
        }

        private void deleteWishList()
        {
            string si = listBox1.GetItemText(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);

            string temp_file = Path.GetTempFileName();

            using (var sr = new StreamReader(path))
            {
                using (var sw = new StreamWriter(temp_file))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != si)
                        {
                            sw.WriteLine(line);
                        }
                    }

                }
            }

            File.Delete(path);
            File.Move(temp_file, path);
        }

        private void search_wl_Click(object sender, EventArgs e)
        {
            var onlineFilm = "http://www.omdbapi.com/?apikey=d111ba84&" + "t=" + searchVal + "&r=xml";
            System.Diagnostics.Process.Start(onlineFilm);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}