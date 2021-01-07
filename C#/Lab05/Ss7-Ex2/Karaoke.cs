namespace Ss7_Ex2
{
    internal class Karaoke
    {
        public string KaraokeSongName { get; set; }
        public int KaraokeSongNumber { get; set; }

        public Karaoke(string karaokeSongName, int karaokeSongNumber)
        {
            KaraokeSongName = karaokeSongName;
            KaraokeSongNumber = karaokeSongNumber;
        }
    }

    internal class Instrumental : Karaoke
    {
        public string KaraokeInstrument { get; set; }

        public Instrumental(string karaokeSongName, int karaokeSongNumber, string karaokeInstrument) : base(karaokeSongName, karaokeSongNumber)
        {
            KaraokeInstrument = karaokeInstrument;
        }
    }

    internal class Artist : Karaoke
    {
        public string KaraokeArtist { get; set; }

        public Artist(string karaokeSongName, int karaokeSongNumber, string karaokeArtist) : base(karaokeSongName, karaokeSongNumber)
        {
            KaraokeArtist = karaokeArtist;
        }
    }

    internal class KaraCountry : Karaoke
    {
        public string KaraokeCountry { get; set; }

        public KaraCountry(string karaokeSongName, int karaokeSongNumber, string karaokeCountry) : base(karaokeSongName, karaokeSongNumber)
        {
            KaraokeCountry = karaokeCountry;
        }
    }
}