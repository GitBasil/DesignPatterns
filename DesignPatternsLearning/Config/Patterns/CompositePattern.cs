using DesignPatternsLearning.Structural.Composite;

namespace DesignPatternsLearning.Config
{
    public class CompositePattern : IPattern
    {
        public void Test()
        {
            Console.WriteLine("----------------Example One----------------");
            // Create rooms for the first floor
            Room livingRoom = new Room("Living Room");
            Room kitchen = new Room("Kitchen");

            // Create rooms for the second floor
            Room bedroom = new Room("Bedroom");
            Room bathroom = new Room("Bathroom");

            // Create first floor and add rooms
            Housing firstFloor = new Housing("First Floor");
            firstFloor.AddStructure(livingRoom);
            firstFloor.AddStructure(kitchen);

            // Create second floor and add rooms
            Housing secondFloor = new Housing("Second Floor");
            secondFloor.AddStructure(bedroom);
            secondFloor.AddStructure(bathroom);

            // Create a house that contains the first and second floors
            Housing house = new Housing("123 Main Street");
            house.AddStructure(firstFloor);
            house.AddStructure(secondFloor);

            // Simulate actions on the house
            house.Enter();
            house.Location();
            house.Exit();

            Console.WriteLine("----------------Example Two----------------");
            // Make new empty "Study" playlist 
            Playlist studyPlaylist = new Playlist("Study");

            // Make "Synth Pop" playlist and add 2 songs to it.
            Playlist synthPopPlaylist = new Playlist("Synth Pop");
            Song synthPopSong1 = new Song("Girl Like You", "Toro Y Moi");
            Song synthPopSong2 = new Song("Outside", "TOPS");
            synthPopPlaylist.add(synthPopSong1);
            synthPopPlaylist.add(synthPopSong2);

            // Make "Experimental" playlist and add 3 songs to it, 
            // then set playback speed of the playlist to 0.5x
            Playlist experimentalPlaylist = new Playlist("Experimental");
            Song experimentalSong1 = new Song("About you", "XXYYXX");
            Song experimentalSong2 = new Song("Motivation", "Clams Casino");
            Song experimentalSong3 = new Song("Computer Vision", "Oneohtrix Point Never");
            experimentalPlaylist.add(experimentalSong1);
            experimentalPlaylist.add(experimentalSong2);
            experimentalPlaylist.add(experimentalSong3);
            float slowSpeed = 0.5f;
            experimentalPlaylist.setPlaybackSpeed(slowSpeed);

            // Add the "Synth Pop" playlist to the "Experimental" playlist
            experimentalPlaylist.add(synthPopPlaylist);

            // Add the "Experimental" playlist to the "Study" playlist
            studyPlaylist.add(experimentalPlaylist);

            // Create a new song and set its playback speed to 1.25x, play this song, 
            // get the name of glitchSong → "Textuell", then get the artist of this song → "Oval"
            Song glitchSong = new Song("Textuell", "Oval");
            float fasterSpeed = 1.25f;
            glitchSong.setPlaybackSpeed(fasterSpeed);
            glitchSong.play();
            String name = glitchSong.getName();
            String artist = glitchSong.getArtist();
            Console.WriteLine("The song name is " + name);
            Console.WriteLine("The song artist is " + artist);

            // Add glitchSong to the "Study" playlist
            studyPlaylist.add(glitchSong);

            // Play "Study" playlist.
            studyPlaylist.play();

            // Get the playlist name of studyPlaylist → "Study"
            Console.WriteLine("The Playlist's name is " + studyPlaylist.getName());

        }
    }
}
