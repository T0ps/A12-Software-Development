using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchVal;
            searchVal = searchBar.Text;

            string searchFunction;
            Console.WriteLine(searchVal);
            searchFunction = "http://www.omdbapi.com/?apikey=d111ba84&" + "t=" + searchVal + "&r=xml";

            System.Diagnostics.Process.Start(searchFunction);

        }
    }
}
