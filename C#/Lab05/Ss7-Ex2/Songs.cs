namespace Ss7_Ex2
{
    internal class Songs
    {
        public string SongSize { get; set; }
        public string Duration { get; set; }
        public string Type { get; set; }

        public Songs(string songSize, string duration, string type)
        {
            SongSize = songSize;
            Duration = duration;
            Type = type;
        }
    }

    internal class Albums : Songs
    {
        public int AlbumNumber { get; set; }
        public string AlbumName { get; set; }

        public Albums(string songSize, string duration, string type, int albumNumber, string albumName) : base(songSize, duration, type)
        {
            AlbumNumber = albumNumber;
            AlbumName = albumName;
        }
    }

    internal class Films : Songs
    {
        public string FilmName { get; set; }
        public string FilmType { get; set; }

        public Films(string songSize, string duration, string type, string filmName, string filmType) : base(songSize, duration, type)
        {
            FilmName = filmName;
            FilmType = filmType;
        }
    }

    internal class SongArtist : Songs
    {
        public string ArtistName { get; set; }

        public SongArtist(string songSize, string duration, string type, string artistName) : base(songSize, duration, type)
        {
            ArtistName = artistName;
        }
    }

    internal class Lyrics : Songs
    {
        public string SongLyric { get; set; }

        public Lyrics(string songSize, string duration, string type, string songLyric) : base(songSize, duration, type)
        {
            SongLyric = songLyric;
        }
    }

    internal class Languages : Songs
    {
        public string SongLanguage { get; set; }

        public Languages(string songSize, string duration, string type, string songLanguage) : base(songSize, duration, type)
        {
            SongLanguage = songLanguage;
        }
    }

    internal class Country : Songs
    {
        public string SongCountry { get; set; }

        public Country(string songSize, string duration, string type, string songCountry) : base(songSize, duration, type)
        {
            SongCountry = songCountry;
        }
    }
}