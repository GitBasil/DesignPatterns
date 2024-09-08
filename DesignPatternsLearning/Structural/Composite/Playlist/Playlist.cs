namespace DesignPatternsLearning.Structural.Composite
{
    public class Playlist : IComponent
    {
        private string playlistName;
        private List<IComponent> playlist;

        public Playlist(string playlistName)
        {
            Console.WriteLine($"Creating Playlist: {playlistName}");
            this.playlistName = playlistName;
            this.playlist = new List<IComponent>();
        }

        public string getName()
        {
            return playlistName;
        }

        public void play()
        {
            Console.WriteLine($"Playing Playlist: {playlistName}");
            foreach (IComponent s in playlist)
            {
                Console.WriteLine($"Playing: {s.getName()}");
            }
        }

        public void setPlaybackSpeed(double speed)
        {
            Console.WriteLine($"Setting Playlist playback speed: {speed}");
            foreach (IComponent s in playlist)
            {
                s.setPlaybackSpeed(speed);
            }
        }

        public void add(IComponent component)
        {
            Console.WriteLine($"Adding {component.getName()}");
            playlist.Add(component);
        }

        public void remove(IComponent component)
        {
            Console.WriteLine($"Removing {component.getName()}");
            playlist.Remove(component);
        }
    }

}