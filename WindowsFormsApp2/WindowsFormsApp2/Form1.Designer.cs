﻿namespace WindowsFormsApp2
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
            this.movieOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(348, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 54);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(12, 70);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(330, 34);
            this.searchBar.TabIndex = 1;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // movieCombo
            // 
            this.movieCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieCombo.FormattingEnabled = true;
            this.movieCombo.Location = new System.Drawing.Point(12, 14);
            this.movieCombo.Name = "movieCombo";
            this.movieCombo.Size = new System.Drawing.Size(121, 21);
            this.movieCombo.TabIndex = 2;
            // 
            // movieOutput
            // 
            this.movieOutput.Location = new System.Drawing.Point(12, 148);
            this.movieOutput.Name = "movieOutput";
            this.movieOutput.Size = new System.Drawing.Size(444, 254);
            this.movieOutput.TabIndex = 3;
            this.movieOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 414);
            this.Controls.Add(this.movieOutput);
            this.Controls.Add(this.movieCombo);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ComboBox movieCombo;
        private System.Windows.Forms.RichTextBox movieOutput;
    }
}

