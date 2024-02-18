namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] lineTokens = Console.ReadLine().Split("_");
                string listType = lineTokens[0];
                string songName = lineTokens[1];
                string songTime = lineTokens[2];

                Song song=new Song(listType, songName, songTime);
                playlist.Add(song);
            }
            string filter=Console.ReadLine();

            if(filter !="all")
            {
                foreach(Song song in playlist) 
                {
                    if(song.TypeList==filter) 
                    {
                        Console.WriteLine(song.Name);
                    }
                }
                return;
            }
            foreach (Song song in playlist) 
            {
                Console.WriteLine(song.Name);
            }
        }


    }
    public class Song
    {
        public Song()
        {

        }
        public Song(string typeList,string name,string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}