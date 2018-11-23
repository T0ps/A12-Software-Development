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
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Movie_DB_Search
{
    public partial class TMDB_Form : Form
    {
        public string path = "wishlist.txt";
        public List<Film> filmList = new List<Film>();
        public string searchVal;
        public string curMovName;
        public string uri;
        public string json;
        public string newSearchVal;

        public TMDB_Form()
        {
            InitializeComponent();
            if (!File.Exists("wishlist.txt"))
            {
                File.Create("wishlist.txt");

            }
            loadWishList();

            
        }

        // If the search bar text is changed, use the searchMovie function to update it in realtime
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchVal = searchBar.Text;
            if (searchVal == "")
            {
                resetMovieData();
            }
            //searchMovie();
        }

        // Reset the displayed movie information
        private void resetMovieData() 
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

        // Main Search Function
        public void searchMovie()
        {
            resetMovieData();

            var searchFunction = "https://api.themoviedb.org/3/search/movie?api_key=95933e5a60f119e9b19b8e2be7252893" + "&query=" + searchVal + "&page=1&include_adult=false";

            WebClient c = new WebClient();
            var data = c.DownloadString(searchFunction);

            JObject filmJson = JObject.Parse(data);
            JArray Films = (JArray)filmJson.SelectToken("results");
            string result = (string)filmJson.SelectToken("total_results");
            if(result == "0")
            {
                MessageBox.Show("No movies found");
                return;
            }

            foreach(JToken results in Films) // Create film objects here
            {

                Film f = new Film(results);
                filmList.Add(f);
            }


            for (int i = 0; i < filmList.Count; i++) // Display all films and attributes , at the moment to console
            {
                string currentTitle = filmList[i].title;
                string currentYear = filmList[i].year;
                string voteAverage = filmList[i].vote;
                Console.WriteLine("{0}: {1}", currentTitle, currentYear);
                Console.WriteLine("Rating: {0}\n", voteAverage);

                FilmListBox.Items.Add(currentTitle);

            }



            
            //if (!isValidFilm(Film.Response)) // Check if the film is in the database
            //{
            //    return; // exit this
            //}

     

            //movieName.Text = Film.Name;
            //movieYear.Text = Film.Year;
            //movieGenre.Text = Film.Genre;
            //movieRating.Text = Film.Awards;
            //movieAwards.Text = Film.Awards;
            //try
            //{
            //    pictureBox2.Load(Film.Poster);
            //}
            //catch
            //{
            //    pictureBox2.Image = null;
            //}
        }

        //private bool isValidFilm(XDocument xml) //Method to check if the movie is valid
        //{
        //    try
        //    {
        //        string response = xml.Root.Attribute("response").Value;
        //        if (response == "True")
        //        {
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    return false;
        //}
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
            var onlineFilm = "https://api.themoviedb.org/3/search/movie?api_key=95933e5a60f119e9b19b8e2be7252893" + "&query=" + searchVal + "&page=1&include_adult=false";

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

        private void TMDB_Form_Load(object sender, EventArgs e)
        {

        }

        private void switchAPI_Click(object sender, EventArgs e)
        {
            OMDB_Form OMDB_Form = new OMDB_Form();

            this.Hide();

            OMDB_Form.Show();

            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        public void updateTextBox(string newSearchVal)
        {
            


        }

        private void FilmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string selectedFilm = FilmListBox.SelectedItem.ToString();
            Console.WriteLine(selectedFilm);
            searchVal = selectedFilm;

            //newSearchVal = "https://api.themoviedb.org/3/search/movie?api_key=95933e5a60f119e9b19b8e2be7252893" + "&query=" + selectedFilm + "&page=1&include_adult=false";


            OMDB_Form OMDB_Form = new OMDB_Form();
            OMDB_Form.Show();

            OMDB_Form.searchBar.Tag = selectedFilm;
            OMDB_Form.searchBar.Text = (string)textBox1.Tag;
            //OMDB_Form.searchBar.TextChanged += new EventHandler(OnTextChanged);

            if (string.IsNullOrEmpty(OMDB_Form.searchBar.Text))
            {
                OMDB_Form.searchBar.Text = (string)OMDB_Form.searchBar.Tag;
            }
        }


   
    }
    public class Film
    {
        public string title { get; set; }
        public string year { get; set; }
        public string vote { get; set; }


        public Film(JToken result)
        {
            title = (string)result.SelectToken("title");
            year = (string)result.SelectToken("release_date");
            vote = (string)result.SelectToken("vote_average");
        }
    }

}