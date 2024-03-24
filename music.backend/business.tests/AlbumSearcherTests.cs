using business.Album;
using business.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.Extensions.Logging;

namespace business.tests
{
    [Collection("AlbumSearcherTests")]
    public class AlbumSearcherTests
    {
        [Fact]
        public void Search_ReturnsCorrectAlbum()
        {
            // Arrange
            var searcher = SetupAlbumSearcher();

            // Act
            var result = searcher.Search("\\path\\to\\album");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.AlbumId);
        }
        [Fact]
        public void Search_ReturnsNull_WhenNoMatchingAlbum()
        {
            // Arrange
            var searcher = SetupAlbumSearcher();

            // Act
            var result = searcher.Search("\\path\\to\\nonexistent\\album");

            // Assert
            Assert.Null(result);
        }


        [Fact(Skip = "Test is redundant because it's equivalent to Search_ReturnsNull_WhenNoMatchingAlbum.")]
        public void Search_ReturnsNull_WhenNoMedia()
        {
            // Arrange
            var searcher = SetupAlbumSearcher();

            // Act
            var result = searcher.Search("\\path\\to\\nonexistent\\album");

            // Assert
            Assert.Null(result);
        }


        [Fact]
        public void Search_ReturnsNull_WhenNoTracks()
        {
            // Arrange
            var searcher = SetupAlbumSearcher();

            // Act
            var result = searcher.Search("\\\\Chopin\\path\\to\\album with no tracks");

            // Assert
            Assert.Null(result);
        }
        // ToDo: AlbumSearcher: Add more tests as needed





        // Helper method to set up an AlbumSearcher with test data
        private static AlbumSearcher SetupAlbumSearcher()
        {
            var mockContext = new Mock<AlxLibraryContext>();

            // Create data to use for testing
            var mediaData = new List<Medium>
            {
                new Medium { MediaId = 1, FileLocation = "\\\\Chopin\\path\\to\\album\\01 - Track.mp3" },
                new Medium { MediaId = 2, FileLocation = "\\\\Chopin\\path\\to\\album with multiple tracks\\01 - Track.mp3" },
                new Medium { MediaId = 3, FileLocation = "\\\\Chopin\\path\\to\\album with multiple tracks\\02 - Track.mp3" },
                new Medium { MediaId = 4, FileLocation = "\\\\Chopin\\path\\to\\album with multiple tracks\\02 - Track.mp3" },
                new Medium { MediaId = 5, FileLocation = "\\\\Chopin\\path\\to\\album with no tracks\\01 - Track.mp3" },
                // Add more media as needed
            }.AsQueryable();

            var trackData = new List<Track>
            {
                new Track { MediaId = 1, AlbumId = 1 },
                new Track { MediaId = 2, AlbumId = 2 },
                new Track { MediaId = 3, AlbumId = 2 },
                new Track { MediaId = 4, AlbumId = 4 },
                // Add more tracks as needed
            }.AsQueryable();

                    // Add Album data
            var albumData = new List<Repository.Models.Album>
            {
                new Repository.Models.Album { AlbumId = 1, Title = "Unit Testin' to the Oldies" },
                new Repository.Models.Album { AlbumId = 2, Title = "Multi-trakin'" /* Album has multiple Tracks... */ },
                new Repository.Models.Album { AlbumId = 3, Title = "I ain't got nobody" /* Album has no Tracks ... */ },
                new Repository.Models.Album { AlbumId = 4, Title = "I ain't got no Media" /* Album has Tracks that are missing Media... */ },
                // Add more albums as needed
            }.AsQueryable();

            




            // Populate the mock context with the test data and set up querying behavior
            var mockMediaSet = new Mock<DbSet<Medium>>();
            mockMediaSet.As<IQueryable<Medium>>().Setup(m => m.Provider).Returns(mediaData.Provider);
            mockMediaSet.As<IQueryable<Medium>>().Setup(m => m.Expression).Returns(mediaData.Expression);
            mockMediaSet.As<IQueryable<Medium>>().Setup(m => m.ElementType).Returns(mediaData.ElementType);
            mockMediaSet.As<IQueryable<Medium>>().Setup(m => m.GetEnumerator()).Returns(mediaData.GetEnumerator());

            var mockTrackSet = new Mock<DbSet<Track>>();
            mockTrackSet.As<IQueryable<Track>>().Setup(m => m.Provider).Returns(trackData.Provider);
            mockTrackSet.As<IQueryable<Track>>().Setup(m => m.Expression).Returns(trackData.Expression);
            mockTrackSet.As<IQueryable<Track>>().Setup(m => m.ElementType).Returns(trackData.ElementType);
            mockTrackSet.As<IQueryable<Track>>().Setup(m => m.GetEnumerator()).Returns(trackData.GetEnumerator());

            var mockAlbumSet = new Mock<DbSet<Repository.Models.Album>>();
            mockAlbumSet.As<IQueryable<Repository.Models.Album>>().Setup(m => m.Provider).Returns(albumData.Provider);
            mockAlbumSet.As<IQueryable<Repository.Models.Album>>().Setup(m => m.Expression).Returns(albumData.Expression);
            mockAlbumSet.As<IQueryable<Repository.Models.Album>>().Setup(m => m.ElementType).Returns(albumData.ElementType);
            mockAlbumSet.As<IQueryable<Repository.Models.Album>>().Setup(m => m.GetEnumerator()).Returns(albumData.GetEnumerator());

            mockContext.Setup(c => c.Media).Returns(mockMediaSet.Object);
            mockContext.Setup(c => c.Tracks).Returns(mockTrackSet.Object);
            mockContext.Setup(c => c.Albums).Returns(mockAlbumSet.Object);

            var mockLogger = new Mock<ILogger<AlbumSearcher>>();
            var searcher = new AlbumSearcher(mockContext.Object, mockLogger.Object);

            return searcher;
        }
    }
}