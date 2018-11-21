namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.movieCombo = new System.Windows.Forms.ComboBox();
            this.movieName = new System.Windows.Forms.RichTextBox();
            this.movieYear = new System.Windows.Forms.RichTextBox();
            this.movieGenre = new System.Windows.Forms.RichTextBox();
            this.movieRating = new System.Windows.Forms.RichTextBox();
            this.movieAwards = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.load_wl = new System.Windows.Forms.Button();
            this.save_wl = new System.Windows.Forms.Button();
            this.delete_wl = new System.Windows.Forms.Button();
            this.search_wl = new System.Windows.Forms.Button();
            this.movieNameBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(406, 86);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 66);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(14, 86);
            this.searchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(384, 30);
            this.searchBar.TabIndex = 1;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // movieCombo
            // 
            this.movieCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieCombo.FormattingEnabled = true;
            this.movieCombo.Location = new System.Drawing.Point(14, 17);
            this.movieCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieCombo.Name = "movieCombo";
            this.movieCombo.Size = new System.Drawing.Size(140, 24);
            this.movieCombo.TabIndex = 2;
            // 
            // movieName
            // 
            this.movieName.Location = new System.Drawing.Point(726, 438);
            this.movieName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(384, 61);
            this.movieName.TabIndex = 3;
            this.movieName.Text = "";
            this.movieName.TextChanged += new System.EventHandler(this.movieName_TextChanged);
            // 
            // movieYear
            // 
            this.movieYear.Location = new System.Drawing.Point(726, 539);
            this.movieYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(384, 61);
            this.movieYear.TabIndex = 4;
            this.movieYear.Text = "";
            this.movieYear.TextChanged += new System.EventHandler(this.movieYear_TextChanged);
            // 
            // movieGenre
            // 
            this.movieGenre.Location = new System.Drawing.Point(726, 657);
            this.movieGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(384, 61);
            this.movieGenre.TabIndex = 5;
            this.movieGenre.Text = "";
            this.movieGenre.TextChanged += new System.EventHandler(this.movieGenre_TextChanged);
            // 
            // movieRating
            // 
            this.movieRating.Location = new System.Drawing.Point(726, 743);
            this.movieRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieRating.Name = "movieRating";
            this.movieRating.Size = new System.Drawing.Size(384, 61);
            this.movieRating.TabIndex = 6;
            this.movieRating.Text = "";
            // 
            // movieAwards
            // 
            this.movieAwards.Location = new System.Drawing.Point(726, 846);
            this.movieAwards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieAwards.Name = "movieAwards";
            this.movieAwards.Size = new System.Drawing.Size(384, 61);
            this.movieAwards.TabIndex = 7;
            this.movieAwards.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(558, 86);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 292);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // load_wl
            // 
            this.load_wl.Location = new System.Drawing.Point(1008, 86);
            this.load_wl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.load_wl.Name = "load_wl";
            this.load_wl.Size = new System.Drawing.Size(131, 28);
            this.load_wl.TabIndex = 9;
            this.load_wl.Text = "Load Wishlist";
            this.load_wl.UseVisualStyleBackColor = true;
            this.load_wl.Click += new System.EventHandler(this.load_wl_Click_1);
            // 
            // save_wl
            // 
            this.save_wl.Location = new System.Drawing.Point(1008, 137);
            this.save_wl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_wl.Name = "save_wl";
            this.save_wl.Size = new System.Drawing.Size(131, 28);
            this.save_wl.TabIndex = 10;
            this.save_wl.Text = "Save Wishlist";
            this.save_wl.UseVisualStyleBackColor = true;
            this.save_wl.Click += new System.EventHandler(this.save_wl_Click);
            // 
            // delete_wl
            // 
            this.delete_wl.Location = new System.Drawing.Point(1008, 192);
            this.delete_wl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_wl.Name = "delete_wl";
            this.delete_wl.Size = new System.Drawing.Size(131, 28);
            this.delete_wl.TabIndex = 11;
            this.delete_wl.Text = "Remove from List";
            this.delete_wl.UseVisualStyleBackColor = true;
            this.delete_wl.Click += new System.EventHandler(this.delete_wl_Click);
            // 
            // search_wl
            // 
            this.search_wl.Location = new System.Drawing.Point(1008, 249);
            this.search_wl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_wl.Name = "search_wl";
            this.search_wl.Size = new System.Drawing.Size(131, 28);
            this.search_wl.TabIndex = 12;
            this.search_wl.Text = "API Data";
            this.search_wl.UseVisualStyleBackColor = true;
            this.search_wl.Click += new System.EventHandler(this.search_wl_Click);
            // 
            // movieNameBox
            // 
            this.movieNameBox.Location = new System.Drawing.Point(558, 438);
            this.movieNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieNameBox.Name = "movieNameBox";
            this.movieNameBox.Size = new System.Drawing.Size(116, 22);
            this.movieNameBox.TabIndex = 13;
            this.movieNameBox.Text = "Name";
            this.movieNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(558, 539);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Year";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(558, 657);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Genre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(558, 743);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "IMDB Rating";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(558, 846);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 22);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Awards";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Location = new System.Drawing.Point(15, 192);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 507);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label1.Location = new System.Drawing.Point(401, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "OMDB Movie Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 923);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.movieNameBox);
            this.Controls.Add(this.search_wl);
            this.Controls.Add(this.delete_wl);
            this.Controls.Add(this.save_wl);
            this.Controls.Add(this.load_wl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.movieAwards);
            this.Controls.Add(this.movieRating);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.movieCombo);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ComboBox movieCombo;
        private System.Windows.Forms.RichTextBox movieName;
        private System.Windows.Forms.RichTextBox movieYear;
        private System.Windows.Forms.RichTextBox movieGenre;
        private System.Windows.Forms.RichTextBox movieRating;
        private System.Windows.Forms.RichTextBox movieAwards;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button load_wl;
        private System.Windows.Forms.Button save_wl;
        private System.Windows.Forms.Button delete_wl;
        private System.Windows.Forms.Button search_wl;
        private System.Windows.Forms.TextBox movieNameBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
