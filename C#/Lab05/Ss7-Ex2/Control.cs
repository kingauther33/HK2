using System;

namespace Ss7_Ex2
{
    internal class Control
    {
        private Songs song1 = new Songs("1.2MB", "3:26", "Rock");
        private Albums album1 = new Albums("1.2MB", "3:26", "Rock", 1, "Rock&Roll");
        private Films film1 = new Films("1.2MB", "3:26", "Rock", "Lion and Father", "Action");
        private SongArtist songArtist1 = new SongArtist("1.2MB", "3:26", "Rock", "John");
        private Lyrics lyric1 = new Lyrics("1.2MB", "3:26", "Rock", "I hate you but i love you");
        private Languages language1 = new Languages("1.2MB", "3:26", "Rock", "English");
        private Country country1 = new Country("1.2MB", "3:26", "Rock", "USA");

        private Karaoke kara1 = new Karaoke("Dieu gi lam anh boi roi", 1);
        private Instrumental instrument1 = new Instrumental("Dieu gi lam anh boi roi", 1, "Guitar");
        private KaraCountry karaCountry1 = new KaraCountry("Dieu gi lam anh boi roi", 1, "Vietnam");
        private static void Main(string[] args)
        {
            Control objControl = new Control();
            Console.WriteLine("Songs details: \n" +
                              "Song Size: {0}\n" +
                              "Song Duration: {1}\n" +
                              "Song Type: {2}\n--------------------------------", objControl.song1.SongSize, objControl.song1.Duration, objControl.song1.Type);
            Console.WriteLine("Albums details: \n" +
                              "Album Name: {0}\n" +
                              "Album Number: {1}\n--------------------------------", objControl.album1.AlbumName, objControl.album1.AlbumNumber);
            // Tu viet nhung cai con lai de test.
        }
    }
}