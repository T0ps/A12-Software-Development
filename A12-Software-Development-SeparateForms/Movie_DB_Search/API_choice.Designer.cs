namespace Movie_DB_Search
{
    partial class API_choice
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
            this.OMDB_button = new System.Windows.Forms.Button();
            this.TMDB_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OMDB_button
            // 
            this.OMDB_button.Location = new System.Drawing.Point(16, 49);
            this.OMDB_button.Name = "OMDB_button";
            this.OMDB_button.Size = new System.Drawing.Size(200, 150);
            this.OMDB_button.TabIndex = 0;
            this.OMDB_button.Text = "OMDB - Real Time Search";
            this.OMDB_button.UseVisualStyleBackColor = true;
            this.OMDB_button.Click += new System.EventHandler(this.OMDB_button_Click);
            // 
            // TMDB_button
            // 
            this.TMDB_button.Location = new System.Drawing.Point(222, 49);
            this.TMDB_button.Name = "TMDB_button";
            this.TMDB_button.Size = new System.Drawing.Size(200, 150);
            this.TMDB_button.TabIndex = 1;
            this.TMDB_button.Text = "TMDB - List Search";
            this.TMDB_button.UseVisualStyleBackColor = true;
            this.TMDB_button.Click += new System.EventHandler(this.TMDB_button_Click);
            // 
            // API_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.TMDB_button);
            this.Controls.Add(this.OMDB_button);
            this.Name = "API_choice";
            this.Text = "Movie Database Search";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OMDB_button;
        private System.Windows.Forms.Button TMDB_button;
    }
}

