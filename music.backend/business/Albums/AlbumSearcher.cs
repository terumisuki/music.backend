using business.Repository.Models;
using business.Tracks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Albums
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
            var albumWithTracks = _context.Albums
                .ToList() // Load the albums into memory
                .Select(album => new
                {
                    Album = album,
                    Tracks = _context.Tracks
                        .Where(track => track.AlbumId == album.AlbumId)
                        .Join(_context.Media,
                            track => track.MediaId,
                            medium => medium.MediaId,
                            (track, medium) => new { Track = track, Medium = medium })
                        .Where(t => t.Medium.FileLocation.Contains($"{directoryPath}\\"))
                        .ToList()
                })
                .FirstOrDefault(a => a.Tracks.Any()); // Get the first album that has any tracks

            if (albumWithTracks != null)
            {
                // Assemble the Tracks
                var tracks = albumWithTracks.Tracks
                    .Select(t => new TrackModel(t.Track, t.Medium) as ITrack)
                    .ToList();

                // Assemble the Album
                var album = new AlbumModel(albumWithTracks.Album, tracks);

                return album;
            }

            return null;
        }
    }
}
