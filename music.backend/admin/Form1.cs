using business.Album;
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

        //  This function whould let the user select a directory from only the InitialDirectory           
        //  It should only allow the selection of a Directory and not a File.
        private void btnSearchAlbum_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.InitialDirectory = @"\\chopin\alxAudio";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    HandleSelectedPath(dialog.SelectedPath);
                }
            }
        }

        private void HandleSelectedPath(string selectedPath)
        {
            var album = _albumSearcher.Search(selectedPath);
            if (album != null) { textBoxAlbumTitle.Text = album.Title; }
        }
    }
}
