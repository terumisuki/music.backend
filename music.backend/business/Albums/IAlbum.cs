using business.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Albums
{
    public interface IAlbum
    {
        int AlbumId { get; }
        string Title { get; }
        List<ITrack> Tracks { get; }
    }
}
