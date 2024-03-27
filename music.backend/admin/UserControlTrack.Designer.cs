namespace admin
{
    partial class UserControlTrack
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTrack = new GroupBox();
            textBoxTrackTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxTrack.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTrack
            // 
            groupBoxTrack.Controls.Add(textBoxTrackTitle);
            groupBoxTrack.Controls.Add(label2);
            groupBoxTrack.Controls.Add(label1);
            groupBoxTrack.Dock = DockStyle.Fill;
            groupBoxTrack.Location = new Point(0, 0);
            groupBoxTrack.Name = "groupBoxTrack";
            groupBoxTrack.Size = new Size(483, 279);
            groupBoxTrack.TabIndex = 0;
            groupBoxTrack.TabStop = false;
            // 
            // textBoxTrackTitle
            // 
            textBoxTrackTitle.Location = new Point(85, 24);
            textBoxTrackTitle.Name = "textBoxTrackTitle";
            textBoxTrackTitle.Size = new Size(344, 23);
            textBoxTrackTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 53);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "genres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "title:";
            // 
            // UserControlTrack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxTrack);
            Name = "UserControlTrack";
            Size = new Size(483, 279);
            groupBoxTrack.ResumeLayout(false);
            groupBoxTrack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTrack;
        private Label label2;
        private Label label1;
        private TextBox textBoxTrackTitle;
    }
}
