using business.Repository.Models;
using business.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Albums
{
    public class AlbumModel : IAlbum
    {
        public int AlbumId { get; }
        public string Title { get; }

        public List<ITrack> Tracks { get; }

        
        // Map the Album properties to this object
        public AlbumModel(Album album, List<ITrack> tracks)
        {
            // Map the Album properties to this object
            this.AlbumId = album.AlbumId;
            this.Title = album.Title;
            this.Tracks = tracks;

        }

        // Map this object's properties to an Album object
        public Album ToEntity()
        {
            // Create a new Album object and map this object's properties to it
            return new Album
            {
                // Map properties here
                AlbumId = this.AlbumId,
                Title = this.Title
            };
        }
    }
}
