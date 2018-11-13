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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public string searchFunction;
        public string searchVal;

        public Form1()
        {
            InitializeComponent();

            movieCombo.Items.Add("OMDb");
            movieCombo.Items.Add("TMDb");
            movieCombo.SelectedIndex = 0;

 

            if (movieCombo.SelectedText == "OMDb")
            {
                MessageBox.Show("OMDb");

                searchFunction = "http://www.omdbapi.com/?apikey=d111ba84&" + "t=" + searchVal + "&r=xml";
                
            }

            else if (movieCombo.SelectedText == "TMDb")
            {
                MessageBox.Show("TMDb");

                searchFunction = "https://api.themoviedb.org/3/movie/550?api_key=95933e5a60f119e9b19b8e2be7252893" + "/search" + searchVal;
            }


        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchVal = searchBar.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(searchFunction);

            //string uri = searchFunction;
            //XDocument document = XDocument.Load(uri);
            //richTextBox1.Text = Convert.ToString(document);
        }
    }
}
