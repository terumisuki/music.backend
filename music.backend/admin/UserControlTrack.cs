using business.Tracks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class UserControlTrack : UserControl
    {
        private ITrack _track;
        public ITrack Track
        {
            get { return _track; }
            set
            {
                _track = value;
                LoadTrack(_track); // Call the method to update the UI
            }
        }

        private void LoadTrack(ITrack track)
        {
            textBoxTrackTitle.Text = track.Title;
        }

        public UserControlTrack()
        {
            InitializeComponent();
        }
    }
}
