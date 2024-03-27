using business.Albums;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace admin
{
    public partial class Form1 : Form
    {
        public Form1(IServiceProvider services)
        {
            InitializeComponent();

            _albumSearcher = services.GetRequiredService<IAlbumSearcher>();
        }

        private IAlbumSearcher _albumSearcher;

        //  This function would let the user select a directory from only the InitialDirectory           
        //  It should only allow the selection of a Directory and not a File.
        private void btnSearchAlbum_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.InitialDirectory = @"\\chopin\alxAudio";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    SearchForAndLoadAlbumIntoUi(dialog.SelectedPath);
                }
            }
        }

        private void SearchForAndLoadAlbumIntoUi(string selectedPath)
        {
            // Search for the album
            var album = _albumSearcher.Search(selectedPath);

            // If no album is found, show a message box and return
            if (album == null) { MessageBox.Show("No album returned"); return; }

            // Load the album into the UI
            textBoxAlbumTitle.Text = album.Title;

            tracksPanel.Controls.Clear();
            tracksPanel.AutoScroll = true;

            // Assume albumTracks is a List<Track> containing your tracks
            for (int i = 0; i < album.Tracks.Count; i++)
            {
                // Create a new instance of your track user control
                var trackControl = new UserControlTrack();

                // Set the properties of the user control based on the track data
                trackControl.Track = album.Tracks[i];

                // Position the user control within the panel
                trackControl.Top = i * trackControl.Height;

                // Add the user control to the panel
                tracksPanel.Controls.Add(trackControl);
            }
        }
    }
}
