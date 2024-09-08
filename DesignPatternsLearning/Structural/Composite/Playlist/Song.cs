namespace DesignPatternsLearning.Structural.Composite
{
    public class Song : IComponent
    {
        private string songName;
        private string artist;

        public Song(string songName, string artist)
        {
            this.songName = songName;
            this.artist = artist;
        }

        public string getName()
        {
            return songName;
        }
        public string getArtist()
        {
            return artist;
        }

        public void play()
        {
            Console.WriteLine($"Playing {songName}");
        }

        public void setPlaybackSpeed(double speed)
        {
            Console.WriteLine($"Setting playback speed for {songName} to {speed}");
        }
    }
}