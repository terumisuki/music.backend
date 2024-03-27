using business.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Tracks
{
    internal class TrackModel : ITrack
    {
        public int MediaId { get; private set; }
        public string Title { get; private set; }


        public TrackModel(Track track, Medium media)
        {
            this.MediaId = track.MediaId;
            this.Title = media.Title;
        }
    }
}
