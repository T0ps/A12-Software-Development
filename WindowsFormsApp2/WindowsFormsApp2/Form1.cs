using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

//using Newtonsoft.Json.Linq; // Implement?

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public string searchFunction;
        public string searchVal;
        public string uri;
        public string json;

        public Form1()
        {
            InitializeComponent();

            movieCombo.Items.Add("OMDb");
            movieCombo.Items.Add("TMDb");
            movieCombo.SelectedIndex = 0;



            


        }


        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchVal = searchBar.Text;
        }

        // OMDb
        public class movieStatsOMDb
        {
            public string title { get; set; }
            public string released { get; set; }
            public string plot { get; set; }
            public string value{ get; set; }
        }

        // TMDb
        public class movieStatsTMDb
        {
            public string title { get; set; }
            public string release_date { get; set; }
            public string overview { get; set; }
            public string vote_average { get; set; }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (movieCombo.SelectedItem.ToString() == "OMDb")
                {
                searchFunction = "http://www.omdbapi.com/?apikey=d111ba84&" + "t=" + searchVal;
            }

            else if (movieCombo.SelectedItem.ToString() == "TMDb")
                {
                searchFunction = "http://api.themoviedb.org/3/search/movie?api_key=95933e5a60f119e9b19b8e2be7252893&" + "query=" + searchVal;
            }


            string x;
            x = "hello title test";
            string y;

            Regex reg = new Regex(@"(?<=title)\d+");
            return reg.Matches(x);

            System.Diagnostics.Process.Start(searchFunction);

            //uri = searchFunction;
            //XDocument document = XDocument.Load(uri);
            //movieOutput.Text = Convert.ToString(document);
        }
    }
}
