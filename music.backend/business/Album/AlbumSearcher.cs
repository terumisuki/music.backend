using business.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<AlbumSearcher> _logger;
        public AlbumSearcher(AlxLibraryContext context, ILogger<AlbumSearcher> logger)
        {
            _context = context;
            _logger = logger;
        }


        /// <summary>
        /// Searches for an album with a path matching the given directory path.
        /// </summary>
        /// <param name="directoryPath">The path to the directory to search for.</param>
        /// <returns>An IAlbum object representing the found album, or null if no matching album is found.</returns>
        public IAlbum Search(string directoryPath)
        {
            _logger.LogInformation($"Searching for album with directory path: {directoryPath}");

            if (_context.Media == null || _context.Tracks == null || _context.Albums == null)
            {
                _logger.LogInformation($"No album found with directory path: {directoryPath}");
                return null;
            }

            // Pull any track that has a media file in the given directory
            var album = _context.Media
                .Join(_context.Tracks,
                    medium => medium.MediaId,
                    track => track.MediaId,
                    (medium, track) => new { Medium = medium, Track = track })
                .Join(_context.Albums,
                    track => track.Track.AlbumId,
                    album => album.AlbumId,
                    (track, album) => new { Track = track, Album = album })
                .Where(t => t.Track.Medium.FileLocation.Contains($"{directoryPath}\\"))
                .Select(t => t.Album)
                .FirstOrDefault();

            if (album != null)
            {
                return new AlbumModel(album);
            }

            return null;
        }
    }
}
