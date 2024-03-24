using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Album
{
    public class AlbumModel : IAlbum
    {
        public int AlbumId { get; }
        public string Title { get; }


        
        // Map the Album properties to this object
        public AlbumModel(Repository.Models.Album album)
        {
            // Map the Album properties to this object
            this.AlbumId = album.AlbumId;
            this.Title = album.Title;
        }

        // Map this object's properties to an Album object
        public Repository.Models.Album ToEntity()
        {
            // Create a new Album object and map this object's properties to it
            return new Repository.Models.Album
            {
                // Map properties here
                AlbumId = this.AlbumId,
                Title = this.Title
            };
        }
    }
}
