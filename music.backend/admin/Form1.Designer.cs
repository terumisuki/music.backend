﻿namespace admin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageAlbum = new TabPage();
            btnSearchAlbum = new Button();
            tabPageArtist = new TabPage();
            tabControl1.SuspendLayout();
            tabPageAlbum.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAlbum);
            tabControl1.Controls.Add(tabPageArtist);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPageAlbum
            // 
            tabPageAlbum.Controls.Add(btnSearchAlbum);
            tabPageAlbum.Location = new Point(4, 24);
            tabPageAlbum.Name = "tabPageAlbum";
            tabPageAlbum.Padding = new Padding(3);
            tabPageAlbum.Size = new Size(792, 422);
            tabPageAlbum.TabIndex = 0;
            tabPageAlbum.Text = "Album";
            tabPageAlbum.UseVisualStyleBackColor = true;
            // 
            // btnSearchAlbum
            // 
            btnSearchAlbum.Location = new Point(33, 14);
            btnSearchAlbum.Name = "btnSearchAlbum";
            btnSearchAlbum.Size = new Size(126, 23);
            btnSearchAlbum.TabIndex = 0;
            btnSearchAlbum.Text = "Browse for Album";
            btnSearchAlbum.UseVisualStyleBackColor = true;
            btnSearchAlbum.Click += btnSearchAlbum_Click;
            // 
            // tabPageArtist
            // 
            tabPageArtist.Location = new Point(4, 24);
            tabPageArtist.Name = "tabPageArtist";
            tabPageArtist.Padding = new Padding(3);
            tabPageArtist.Size = new Size(792, 422);
            tabPageArtist.TabIndex = 1;
            tabPageArtist.Text = "Artist";
            tabPageArtist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPageAlbum.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageAlbum;
        private TabPage tabPageArtist;
        private Button btnSearchAlbum;
    }
}
