namespace admin
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
            panel1 = new Panel();
            tracksPanel = new Panel();
            btnSearchAlbum = new Button();
            label2 = new Label();
            textBoxAlbumTitle = new TextBox();
            label1 = new Label();
            tabPageArtist = new TabPage();
            tabControl1.SuspendLayout();
            tabPageAlbum.SuspendLayout();
            panel1.SuspendLayout();
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
            tabControl1.Size = new Size(961, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabPageAlbum
            // 
            tabPageAlbum.Controls.Add(panel1);
            tabPageAlbum.Location = new Point(4, 24);
            tabPageAlbum.Name = "tabPageAlbum";
            tabPageAlbum.Padding = new Padding(3);
            tabPageAlbum.Size = new Size(953, 542);
            tabPageAlbum.TabIndex = 0;
            tabPageAlbum.Text = "Album";
            tabPageAlbum.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tracksPanel);
            panel1.Controls.Add(btnSearchAlbum);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxAlbumTitle);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 536);
            panel1.TabIndex = 1;
            // 
            // tracksPanel
            // 
            tracksPanel.Location = new Point(22, 81);
            tracksPanel.Name = "tracksPanel";
            tracksPanel.Size = new Size(742, 282);
            tracksPanel.TabIndex = 3;
            // 
            // btnSearchAlbum
            // 
            btnSearchAlbum.Location = new Point(638, 47);
            btnSearchAlbum.Name = "btnSearchAlbum";
            btnSearchAlbum.Size = new Size(126, 23);
            btnSearchAlbum.TabIndex = 0;
            btnSearchAlbum.Text = "Browse for Album";
            btnSearchAlbum.UseVisualStyleBackColor = true;
            btnSearchAlbum.Click += btnSearchAlbum_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 47);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "year released:";
            // 
            // textBoxAlbumTitle
            // 
            textBoxAlbumTitle.Location = new Point(67, 14);
            textBoxAlbumTitle.Name = "textBoxAlbumTitle";
            textBoxAlbumTitle.Size = new Size(697, 23);
            textBoxAlbumTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "title:";
            // 
            // tabPageArtist
            // 
            tabPageArtist.Location = new Point(4, 24);
            tabPageArtist.Name = "tabPageArtist";
            tabPageArtist.Padding = new Padding(3);
            tabPageArtist.Size = new Size(953, 542);
            tabPageArtist.TabIndex = 1;
            tabPageArtist.Text = "Artist";
            tabPageArtist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 570);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPageAlbum.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageAlbum;
        private TabPage tabPageArtist;
        private Button btnSearchAlbum;
        private Panel panel1;
        private TextBox textBoxAlbumTitle;
        private Label label1;
        private Label label2;
        private Panel tracksPanel;
    }
}
