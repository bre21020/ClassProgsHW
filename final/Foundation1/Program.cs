using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video meAtTheZoo = new Video("Me at the zoo", "jawed", 19);
        meAtTheZoo.AddComment("@SanDiegoZoo", "We're so honored that the first ever YouTube video was filmed here!");
        meAtTheZoo.AddComment("@lkm-qb5pm" ,"2005 me at the zoo\n2020 me at the zoom");
        meAtTheZoo.AddComment("@hyri3188" ,"If he uploads another video with the title: Me leaving the zoo, that will be the end of YouTube");

        Video rickroll = new Video("Rick Astley - Never Gonna Give You Up (Official Video) (4K Remaster)", "Rick Astley", 213);
        rickroll.AddComment("@YouTube", "can confirm: he never gave us up");
        rickroll.AddComment("@SonimodGT" ,"Petition to make this the national anthem of the internet");
        rickroll.AddComment("@lillyie" ,"Imagine if Rick Astley dies everyone would be too afraid to click a link to articles announcing his death because it might be a rickroll");

        Video keyboardcat = new Video("Keyboard Cat! - THE ORIGINAL!", "Keyboard Cat!", 54);
        keyboardcat.AddComment("@perrytheplatypus42", "YouTube needs to add an “Oldest First” option for comments");
        keyboardcat.AddComment("@kamirkaze" ,"Press F to pay respects");
        keyboardcat.AddComment("@triple_trash_bucket6169" ,"This is literally one of the ancient fragments of the internet");


        List<Video> videos = new List<Video>();
        videos.Add(meAtTheZoo);
        videos.Add(rickroll);
        videos.Add(keyboardcat);

        foreach (Video video in videos) {
            video.Display();
            Console.WriteLine("\n");
        }

    }
}