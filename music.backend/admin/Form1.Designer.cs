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
            btnSearchAlbum = new Button();
            tabPageArtist = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            textBoxAlbumTitle = new TextBox();
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
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPageAlbum
            // 
            tabPageAlbum.Controls.Add(panel1);
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
            btnSearchAlbum.Location = new Point(663, 6);
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
            // panel1
            // 
            panel1.Controls.Add(textBoxAlbumTitle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 90);
            panel1.TabIndex = 1;
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
            // textBoxAlbumTitle
            // 
            textBoxAlbumTitle.Location = new Point(67, 14);
            textBoxAlbumTitle.Name = "textBoxAlbumTitle";
            textBoxAlbumTitle.Size = new Size(697, 23);
            textBoxAlbumTitle.TabIndex = 1;
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
    }
}
