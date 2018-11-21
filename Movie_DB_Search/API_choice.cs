using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_DB_Search
{
    public partial class API_choice : Form
    {
        public API_choice()
        {
            InitializeComponent();
            this.ControlBox = false;

        }

        private void OMDB_button_Click(object sender, EventArgs e)
        {
            OMDB_Form OMDB_Form = new OMDB_Form();
            OMDB_Form.Show();
        }

        private void TMDB_button_Click(object sender, EventArgs e)
        {
            TMDB_Form TMDB_Form = new TMDB_Form();
            TMDB_Form.Show();
            
        } 
    }
}
