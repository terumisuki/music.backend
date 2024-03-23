using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace business.Repository.Models;

public partial class AlxLibraryContext : DbContext
{
    public AlxLibraryContext()
    {
    }

    public AlxLibraryContext(DbContextOptions<AlxLibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Album> Albums { get; set; }

    public virtual DbSet<Artist> Artists { get; set; }

    public virtual DbSet<ArtistEra> ArtistEras { get; set; }

    public virtual DbSet<ArtistOrigin> ArtistOrigins { get; set; }

    public virtual DbSet<ArtistType> ArtistTypes { get; set; }

    public virtual DbSet<ArtistsToEra> ArtistsToEras { get; set; }

    public virtual DbSet<ArtistsToOrigin> ArtistsToOrigins { get; set; }

    public virtual DbSet<ArtistsToType> ArtistsToTypes { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DarwinScore> DarwinScores { get; set; }

    public virtual DbSet<DynamicInstruction> DynamicInstructions { get; set; }

    public virtual DbSet<DynamicPlaylist> DynamicPlaylists { get; set; }

    public virtual DbSet<DynamicPlaylistGlobal> DynamicPlaylistGlobals { get; set; }

    public virtual DbSet<DynamicPlaylistInstructionSet> DynamicPlaylistInstructionSets { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<KeySignature> KeySignatures { get; set; }

    public virtual DbSet<MediaType> MediaTypes { get; set; }

    public virtual DbSet<Medium> Media { get; set; }

    public virtual DbSet<Mood> Moods { get; set; }

    public virtual DbSet<Movement> Movements { get; set; }

    public virtual DbSet<MovementsToPart> MovementsToParts { get; set; }

    public virtual DbSet<MovementsToTrack> MovementsToTracks { get; set; }

    public virtual DbSet<Opuse> Opuses { get; set; }

    public virtual DbSet<P3Conjunction> P3Conjunctions { get; set; }

    public virtual DbSet<P3Instruction> P3Instructions { get; set; }

    public virtual DbSet<P3InstructionSet> P3InstructionSets { get; set; }

    public virtual DbSet<P3InstructionType> P3InstructionTypes { get; set; }

    public virtual DbSet<P3Playlist> P3Playlists { get; set; }

    public virtual DbSet<P3PlaylistInstructionSet> P3PlaylistInstructionSets { get; set; }

    public virtual DbSet<P3RecentEntry> P3RecentEntries { get; set; }

    public virtual DbSet<P3Year> P3Years { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PhotoAlbum> PhotoAlbums { get; set; }

    public virtual DbSet<PhotoAlbumPhoto> PhotoAlbumPhotos { get; set; }

    public virtual DbSet<Piece> Pieces { get; set; }

    public virtual DbSet<PlayedList> PlayedLists { get; set; }

    public virtual DbSet<Playlist> Playlists { get; set; }

    public virtual DbSet<PlaylistConjugator> PlaylistConjugators { get; set; }

    public virtual DbSet<PlaylistInstruction> PlaylistInstructions { get; set; }

    public virtual DbSet<PlaylistInstructionSet> PlaylistInstructionSets { get; set; }

    public virtual DbSet<RecentlyPlayedArtist> RecentlyPlayedArtists { get; set; }

    public virtual DbSet<RecentlyPlayedMedium> RecentlyPlayedMedia { get; set; }

    public virtual DbSet<RemoteDownload> RemoteDownloads { get; set; }

    public virtual DbSet<SagaTrack> SagaTracks { get; set; }

    public virtual DbSet<SyncdWithPhone> SyncdWithPhones { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TaggedMedium> TaggedMedia { get; set; }

    public virtual DbSet<Tempo> Tempos { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    public virtual DbSet<TrackGrade> TrackGrades { get; set; }

    public virtual DbSet<TracksToGenre> TracksToGenres { get; set; }

    public virtual DbSet<TracksToMood> TracksToMoods { get; set; }

    public virtual DbSet<TracksToPerformer> TracksToPerformers { get; set; }

    public virtual DbSet<TracksToTempo> TracksToTempos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<Variable> Variables { get; set; }

    public virtual DbSet<VariablesToUser> VariablesToUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=chopin;Database=alxLibrary;User Id=alxMediaUser;Password=alxMediaPassword;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Album>(entity =>
        {
            entity.HasKey(e => e.AlbumId).HasName("PK_albums");

            entity.HasIndex(e => e.Title, "albumTitle");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GracenoteId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<Artist>(entity =>
        {
            entity.HasKey(e => e.ArtistId).HasName("PK_artists");

            entity.HasIndex(e => e.Name, "artistName").IsUnique();

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GracenoteId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JapaneseName).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ArtistEra>(entity =>
        {
            entity.HasKey(e => e.EraId).HasName("PK_Eras");

            entity.HasIndex(e => e.English, "IX_ArtistEras").IsUnique();

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.English).HasMaxLength(200);
            entity.Property(e => e.Japanese).HasMaxLength(200);
        });

        modelBuilder.Entity<ArtistOrigin>(entity =>
        {
            entity.HasKey(e => e.ArtistOriginId).HasName("PK_GracenoteArtistOrigins");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.English).HasMaxLength(200);
            entity.Property(e => e.Japanese).HasMaxLength(200);
        });

        modelBuilder.Entity<ArtistType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.English).HasMaxLength(200);
            entity.Property(e => e.Japanese).HasMaxLength(200);
        });

        modelBuilder.Entity<ArtistsToEra>(entity =>
        {
            entity.HasKey(e => new { e.ArtistId, e.EraId });

            entity.ToTable("Artists__to__Eras");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Artist).WithMany(p => p.ArtistsToEras)
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Artists__to__Eras_artists");

            entity.HasOne(d => d.Era).WithMany(p => p.ArtistsToEras)
                .HasForeignKey(d => d.EraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Artists__to__Eras_ArtistEras");
        });

        modelBuilder.Entity<ArtistsToOrigin>(entity =>
        {
            entity.HasKey(e => new { e.ArtistId, e.OriginId });

            entity.ToTable("Artists__to__Origins");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Artist).WithMany(p => p.ArtistsToOrigins)
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Artists__to__Origins_artists");

            entity.HasOne(d => d.Origin).WithMany(p => p.ArtistsToOrigins)
                .HasForeignKey(d => d.OriginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Artists__to__Origins_ArtistOrigins");
        });

        modelBuilder.Entity<ArtistsToType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Artists__to__Types");

            entity.Property(e => e.DatStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Artist).WithMany()
                .HasForeignKey(d => d.ArtistId)
                .HasConstraintName("FK_Artists__to__Types_artists");

            entity.HasOne(d => d.Type).WithMany()
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_Artists__to__Types_ArtistTypes");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("clients");

            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DarwinScore>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.MediaId });

            entity.ToTable("darwinScores");

            entity.HasIndex(e => new { e.UserId, e.DarwinScore1, e.DateStamp }, "IX_darwinScores");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.DarwinScore1).HasColumnName("darwinScore");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.NumberOfTimesSkipped)
                .HasDefaultValue(0)
                .HasColumnName("numberOfTimesSkipped");

            entity.HasOne(d => d.User).WithMany(p => p.DarwinScores)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_darwinScores_users");
        });

        modelBuilder.Entity<DynamicInstruction>(entity =>
        {
            entity.HasKey(e => e.InstructionId);

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnOff).HasDefaultValue(true);
            entity.Property(e => e.TargetName).HasMaxLength(100);

            entity.HasOne(d => d.InstructionSet).WithMany(p => p.DynamicInstructions)
                .HasForeignKey(d => d.InstructionSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicInstructions_DynamicPlaylistInstructionSets");
        });

        modelBuilder.Entity<DynamicPlaylist>(entity =>
        {
            entity.HasKey(e => e.PlaylistId);

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PlaylistName)
                .HasMaxLength(200)
                .HasDefaultValue("new playlist");

            entity.HasOne(d => d.User).WithMany(p => p.DynamicPlaylists)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicPlaylists_users");
        });

        modelBuilder.Entity<DynamicPlaylistGlobal>(entity =>
        {
            entity.HasKey(e => e.PlaylistGlobalId);

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TargetName).HasMaxLength(100);

            entity.HasOne(d => d.Playlist).WithMany(p => p.DynamicPlaylistGlobals)
                .HasForeignKey(d => d.PlaylistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicPlaylistGlobals_DynamicPlaylists");
        });

        modelBuilder.Entity<DynamicPlaylistInstructionSet>(entity =>
        {
            entity.HasKey(e => e.InstructionSetId);

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RotationWeight).HasDefaultValue(50);
            entity.Property(e => e.TopXtracks).HasColumnName("TopXTracks");

            entity.HasOne(d => d.Playlist).WithMany(p => p.DynamicPlaylistInstructionSets)
                .HasForeignKey(d => d.PlaylistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicPlaylistInstructionSets_DynamicPlaylists");
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("entities");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.ToTable("errors");

            entity.Property(e => e.ErrorId).HasColumnName("errorId");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateCreated");
            entity.Property(e => e.Error1).HasColumnName("error");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK_genre");

            entity.ToTable("Genre");

            entity.HasIndex(e => e.Genre1, "genreName");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Genre1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Genre");
            entity.Property(e => e.HasMovements).HasDefaultValue(false);
            entity.Property(e => e.IsClassical).HasDefaultValue(false);
            entity.Property(e => e.Japanese).HasMaxLength(200);
        });

        modelBuilder.Entity<KeySignature>(entity =>
        {
            entity.HasKey(e => e.KeyId);

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.KeySignature1)
                .HasMaxLength(50)
                .HasColumnName("KeySignature");
        });

        modelBuilder.Entity<MediaType>(entity =>
        {
            entity.ToTable("mediaTypes");

            entity.Property(e => e.MediaTypeId).HasColumnName("mediaTypeId");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.MediaType1)
                .HasMaxLength(50)
                .HasColumnName("mediaType");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<Medium>(entity =>
        {
            entity.HasKey(e => e.MediaId).HasName("PK_media");

            entity.HasIndex(e => e.FileLocation, "IX_media");

            entity.HasIndex(e => e.Title, "IX_media_1");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileLocation).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.MediaType).WithMany(p => p.Media)
                .HasForeignKey(d => d.MediaTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_media_mediaTypes");
        });

        modelBuilder.Entity<Mood>(entity =>
        {
            entity.HasKey(e => e.MoodId).HasName("PK_GracenoteMoods");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.English).HasMaxLength(200);
            entity.Property(e => e.Japanese).HasMaxLength(150);
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<Movement>(entity =>
        {
            entity.HasKey(e => e.MovementId).HasName("PK_movements");

            entity.HasIndex(e => e.Title, "movementTitle");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.IsLegacy).HasDefaultValue(false);
            entity.Property(e => e.SortNumber).HasColumnName("sortNumber");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Piece).WithMany(p => p.Movements)
                .HasForeignKey(d => d.PieceId)
                .HasConstraintName("FK_movements_pieces");
        });

        modelBuilder.Entity<MovementsToPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_movements_to_parts");

            entity.ToTable("Movements_to_Parts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComposedBy).HasColumnName("composedBy");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsLegacy).HasDefaultValue(false);
            entity.Property(e => e.PartId).HasColumnName("partId");

            entity.HasOne(d => d.ComposedAsNavigation).WithMany(p => p.MovementsToParts)
                .HasForeignKey(d => d.ComposedAs)
                .HasConstraintName("FK_movements_to_parts_artists");

            entity.HasOne(d => d.ComposedByNavigation).WithMany(p => p.MovementsToParts)
                .HasForeignKey(d => d.ComposedBy)
                .HasConstraintName("FK_movements_to_parts_people");

            entity.HasOne(d => d.Movement).WithMany(p => p.MovementsToParts)
                .HasForeignKey(d => d.MovementId)
                .HasConstraintName("FK_movements_to_parts_movements");

            entity.HasOne(d => d.Part).WithMany(p => p.MovementsToParts)
                .HasForeignKey(d => d.PartId)
                .HasConstraintName("FK_movements_to_parts_parts");
        });

        modelBuilder.Entity<MovementsToTrack>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Movements_to_Tracks");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.IsLegacy).HasDefaultValue(false);
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.MovementId).HasColumnName("movementId");

            entity.HasOne(d => d.Movement).WithMany()
                .HasForeignKey(d => d.MovementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_movements_to_tracks_movements");
        });

        modelBuilder.Entity<Opuse>(entity =>
        {
            entity.HasKey(e => e.OpusId).HasName("PK_opuses");

            entity.HasIndex(e => e.Title, "opusTitle");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsLegacy).HasDefaultValue(false);
            entity.Property(e => e.Number).HasMaxLength(200);
            entity.Property(e => e.Opus).HasMaxLength(200);
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<P3Conjunction>(entity =>
        {
            entity.HasKey(e => e.ConjunctionId).HasName("PK_2021SavedConjunction");

            entity.ToTable("P3_Conjunctions");

            entity.Property(e => e.Conjunction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("or");
            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.InstructionSet).WithMany(p => p.P3Conjunctions)
                .HasForeignKey(d => d.InstructionSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2021SavedConjunction_2021SavedInstructionSets");
        });

        modelBuilder.Entity<P3Instruction>(entity =>
        {
            entity.HasKey(e => e.Instructionid).HasName("PK_2021SavedInstructions");

            entity.ToTable("P3_Instructions");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.OnOff).HasDefaultValue(true);
            entity.Property(e => e.TargetName).HasMaxLength(200);

            entity.HasOne(d => d.Conjunction).WithMany(p => p.P3Instructions)
                .HasForeignKey(d => d.ConjunctionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2021SavedInstructions_2021SavedConjunctions");

            entity.HasOne(d => d.InstructionType).WithMany(p => p.P3Instructions)
                .HasForeignKey(d => d.InstructionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_P3_Instructions_P3_PlaylistTypes");
        });

        modelBuilder.Entity<P3InstructionSet>(entity =>
        {
            entity.HasKey(e => e.InstructionSetId).HasName("PK_2021SavedInstructionSets");

            entity.ToTable("P3_InstructionSets");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.InstructionSetName)
                .HasMaxLength(250)
                .HasDefaultValue("instruction set");
        });

        modelBuilder.Entity<P3InstructionType>(entity =>
        {
            entity.HasKey(e => e.InstructionTypeId).HasName("PK_2021PlaylistTypes");

            entity.ToTable("P3_InstructionTypes");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Type).HasMaxLength(250);
        });

        modelBuilder.Entity<P3Playlist>(entity =>
        {
            entity.HasKey(e => e.PlaylistId).HasName("PK_2021_Playlists");

            entity.ToTable("P3_Playlists");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.PlaylistName)
                .HasMaxLength(250)
                .HasDefaultValue("new playlist");

            entity.HasOne(d => d.GlobalInstructionSet).WithMany(p => p.P3Playlists)
                .HasForeignKey(d => d.GlobalInstructionSetId)
                .HasConstraintName("FK_P3_Playlists_P3_InstructionSets");

            entity.HasOne(d => d.User).WithMany(p => p.P3Playlists)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2021Playlists_users");
        });

        modelBuilder.Entity<P3PlaylistInstructionSet>(entity =>
        {
            entity.HasKey(e => e.PlaylistInstructionSetId).HasName("PK_Table_1");

            entity.ToTable("P3_PlaylistInstructionSets");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.RotationWeight).HasDefaultValue(100);
            entity.Property(e => e.TopXtracks).HasColumnName("TopXTracks");

            entity.HasOne(d => d.InstructionSet).WithMany(p => p.P3PlaylistInstructionSets)
                .HasForeignKey(d => d.InstructionSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2021PlaylistInstructionSets_2021SavedInstructionSets");

            entity.HasOne(d => d.Playlist).WithMany(p => p.P3PlaylistInstructionSets)
                .HasForeignKey(d => d.PlaylistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_2021PlaylistInstructionSets_2021_Playlists");
        });

        modelBuilder.Entity<P3RecentEntry>(entity =>
        {
            entity.HasKey(e => e.RecentId);

            entity.ToTable("P3_RecentEntries");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Instruction).WithMany(p => p.P3RecentEntries)
                .HasForeignKey(d => d.InstructionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_P3_RecentEntries_P3_Instructions");
        });

        modelBuilder.Entity<P3Year>(entity =>
        {
            entity.HasKey(e => e.YearId).HasName("PK_2021PlaylistYears");

            entity.ToTable("P3_Years");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Instruction).WithMany(p => p.P3Years)
                .HasForeignKey(d => d.InstructionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_P3_PlaylistYears_P3_Instructions");
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.ToTable("parts");

            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.Part1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("part");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PeopleId);

            entity.ToTable("people");

            entity.Property(e => e.PeopleId).HasColumnName("peopleId");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middleName");
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prefix");
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ssn");
            entity.Property(e => e.Suffix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("suffix");
        });

        modelBuilder.Entity<PhotoAlbum>(entity =>
        {
            entity.HasKey(e => e.AlbumId);

            entity.ToTable("photoAlbums");

            entity.HasIndex(e => e.AlbumCode, "IX_photoAlbums").IsUnique();

            entity.Property(e => e.AlbumCode)
                .HasMaxLength(50)
                .HasColumnName("albumCode");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<PhotoAlbumPhoto>(entity =>
        {
            entity.HasKey(e => new { e.AlbumId, e.MediaId });

            entity.ToTable("photoAlbumPhotos");

            entity.Property(e => e.AlbumId).HasColumnName("albumId");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.Datestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("datestamp");
            entity.Property(e => e.EnglishCaption)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("englishCaption");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JapaneseCaption)
                .HasMaxLength(1000)
                .HasColumnName("japaneseCaption");

            entity.HasOne(d => d.Album).WithMany(p => p.PhotoAlbumPhotos)
                .HasForeignKey(d => d.AlbumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_photoAlbumPhotos_photoAlbums");

            entity.HasOne(d => d.Media).WithMany(p => p.PhotoAlbumPhotos)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_photoAlbumPhotos_media");
        });

        modelBuilder.Entity<Piece>(entity =>
        {
            entity.HasKey(e => e.PieceId).HasName("PK_pieces");

            entity.HasIndex(e => e.Title, "pieceTitle");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsLegacy).HasDefaultValue(false);
            entity.Property(e => e.KeySignature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("keySignature");
            entity.Property(e => e.PieceTypeId).HasColumnName("pieceTypeId");
            entity.Property(e => e.SortNumber).HasColumnName("sortNumber");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Opus).WithMany(p => p.Pieces)
                .HasForeignKey(d => d.OpusId)
                .HasConstraintName("FK_pieces_opuses");
        });

        modelBuilder.Entity<PlayedList>(entity =>
        {
            entity.ToTable("playedList");

            entity.HasIndex(e => e.MediaId, "IX_playedList");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<Playlist>(entity =>
        {
            entity.HasKey(e => e.PlaylistId).HasName("PK_playlists_1");

            entity.ToTable("playlists");

            entity.Property(e => e.PlaylistId).HasColumnName("playlistId");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Playlists)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_playlists_users");
        });

        modelBuilder.Entity<PlaylistConjugator>(entity =>
        {
            entity.HasKey(e => e.ConjugatorId);

            entity.Property(e => e.Conjugation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<PlaylistInstruction>(entity =>
        {
            entity.HasKey(e => e.InstructionId).HasName("PK_playlistInstructions_1");

            entity.ToTable("playlistInstructions");

            entity.Property(e => e.InstructionId).HasColumnName("instructionId");
            entity.Property(e => e.Conjugation)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("and");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.NextInstructionId).HasColumnName("nextInstructionId");
            entity.Property(e => e.OnOff).HasDefaultValue(true);
            entity.Property(e => e.TargetId).HasColumnName("targetId");
        });

        modelBuilder.Entity<PlaylistInstructionSet>(entity =>
        {
            entity.HasKey(e => e.InstructionSetId).HasName("PK_playlistInstructionSets_1");

            entity.ToTable("playlistInstructionSets");

            entity.Property(e => e.InstructionSetId).HasColumnName("instructionSetId");
            entity.Property(e => e.Datestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("datestamp");
            entity.Property(e => e.NextInstructionSetId).HasColumnName("nextInstructionSetId");
            entity.Property(e => e.RotationWeight).HasDefaultValue(100);
        });

        modelBuilder.Entity<RecentlyPlayedArtist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recentlyPlayedArtists");

            entity.Property(e => e.ArtistId).HasColumnName("artistId");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<RecentlyPlayedMedium>(entity =>
        {
            entity.HasKey(e => new { e.MediaId, e.UserId });

            entity.ToTable("recentlyPlayedMedia");

            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");

            entity.HasOne(d => d.Media).WithMany(p => p.RecentlyPlayedMedia)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recentlyPlayedMedia_media");

            entity.HasOne(d => d.User).WithMany(p => p.RecentlyPlayedMedia)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recentlyPlayedMedia_users");
        });

        modelBuilder.Entity<RemoteDownload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("remoteDownloads");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<SagaTrack>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SagaTracks");

            entity.Property(e => e.ArtistEra).HasMaxLength(200);
            entity.Property(e => e.ArtistName).HasMaxLength(200);
            entity.Property(e => e.Expr1).HasMaxLength(150);
            entity.Property(e => e.FileLocation).HasMaxLength(250);
            entity.Property(e => e.Genre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Mood).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.TrackAdded).HasColumnType("datetime");
        });

        modelBuilder.Entity<SyncdWithPhone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SyncdWithPhone");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("tags");

            entity.Property(e => e.TagId).HasColumnName("tagId");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.Tag1)
                .HasMaxLength(100)
                .HasColumnName("tag");
        });

        modelBuilder.Entity<TaggedMedium>(entity =>
        {
            entity.HasKey(e => new { e.TagId, e.MediaId });

            entity.ToTable("taggedMedia");

            entity.Property(e => e.TagId).HasColumnName("tagId");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");

            entity.HasOne(d => d.Media).WithMany(p => p.TaggedMedia)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_taggedMedia_media");

            entity.HasOne(d => d.Tag).WithMany(p => p.TaggedMedia)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_taggedMedia_tags");
        });

        modelBuilder.Entity<Tempo>(entity =>
        {
            entity.HasKey(e => e.TempoId).HasName("PK_GracenoteTempos");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.English).HasMaxLength(200);
            entity.Property(e => e.Japanese).HasMaxLength(200);
            entity.Property(e => e.Tempo1).HasColumnName("Tempo");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GracenoteId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrackGrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("trackGrades");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Media).WithMany()
                .HasForeignKey(d => d.MediaId)
                .HasConstraintName("FK_trackGrades_media");
        });

        modelBuilder.Entity<TracksToGenre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tracks_to_genres");

            entity.HasIndex(e => new { e.GenreId, e.MediaId }, "mediaId_genereId").IsClustered();

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Media).WithMany()
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tracks_to_genres_media");
        });

        modelBuilder.Entity<TracksToMood>(entity =>
        {
            entity.HasKey(e => new { e.MediaId, e.MoodId });

            entity.ToTable("Tracks__to__Moods");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TracksToPerformer>(entity =>
        {
            entity.ToTable("tracks_to_performers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.MediaId).HasColumnName("mediaId");
            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.PerformedAs).HasColumnName("performedAs");
            entity.Property(e => e.PerformedBy).HasColumnName("performedBy");

            entity.HasOne(d => d.PerformedAsNavigation).WithMany(p => p.TracksToPerformers)
                .HasForeignKey(d => d.PerformedAs)
                .HasConstraintName("FK_tracks_to_performers_artists");

            entity.HasOne(d => d.PerformedByNavigation).WithMany(p => p.TracksToPerformers)
                .HasForeignKey(d => d.PerformedBy)
                .HasConstraintName("FK_tracks_to_performers_people");
        });

        modelBuilder.Entity<TracksToTempo>(entity =>
        {
            entity.HasKey(e => new { e.MediaId, e.TempoId }).HasName("PK_tracks__to__tempos");

            entity.ToTable("Tracks__to__Tempos");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Media).WithMany(p => p.TracksToTempos)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tracks__to__Tempos_Media");

            entity.HasOne(d => d.Tempo).WithMany(p => p.TracksToTempos)
                .HasForeignKey(d => d.TempoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tracks__to__Tempos_Tempos");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Auth)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auth");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PeopleId).HasColumnName("peopleId");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.People).WithMany(p => p.Users)
                .HasForeignKey(d => d.PeopleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_users_people");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.SettingId);

            entity.ToTable("userSettings");

            entity.Property(e => e.SettingId).HasColumnName("settingId");
            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.SettingName)
                .HasMaxLength(50)
                .HasColumnName("settingName");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.UserSettings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_userSettings_users");
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.ToTable("variables");

            entity.Property(e => e.VariableId).HasColumnName("variableId");
            entity.Property(e => e.TheKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("theKey");
            entity.Property(e => e.TheValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("theValue");
        });

        modelBuilder.Entity<VariablesToUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("variables___to___users");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStamp");
            entity.Property(e => e.SettingId).HasColumnName("settingId");
            entity.Property(e => e.TheValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("theValue");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.VariableId).HasColumnName("variableId");

            entity.HasOne(d => d.Setting).WithMany()
                .HasForeignKey(d => d.SettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_variables___to___users_userSettings");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
