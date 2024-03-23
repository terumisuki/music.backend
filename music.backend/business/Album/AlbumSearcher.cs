using business.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Album
{
    public class AlbumSearcher : IAlbumSearcher
    {
        private readonly AlxLibraryContext _context;
        public AlbumSearcher(AlxLibraryContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Searches for an album with a path matching the given directory path.
        /// </summary>
        /// <param name="directoryPath">The path to the directory to search for.</param>
        /// <returns>An IAlbum object representing the found album, or null if no matching album is found.</returns>
        public IAlbum Search(string directoryPath)
        {
            var track = _context.Media
                .Join(_context.Tracks,
                    medium => medium.MediaId,
                    track => track.MediaId,
                    (medium, track) => new { Medium = medium, Track = track })
                .Where(t => EF.Functions.Like(t.Medium.FileLocation, $"%{directoryPath}\\%"))
                .Select(t => t.Track)
                .FirstOrDefault();

            if (track != null)
            {
                var albumId = track.AlbumId;
                // Now you can use albumId to get the Album
                var album = _context.Albums.Find(albumId);
                if (album != null) 
                {
                    var test = album.Title;
                    return album as IAlbum;
                }
            }

            return null;
        }
    }
}
