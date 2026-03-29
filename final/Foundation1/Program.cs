using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video meAtTheZoo = new Video();
        meAtTheZoo._title = "Me at the zoo";
        meAtTheZoo._author = "jawed";
        meAtTheZoo._length = 19;
        meAtTheZoo.AddComment("@SanDiegoZoo", "We're so honored that the first ever YouTube video was filmed here!");
        meAtTheZoo.AddComment("@lkm-qb5pm" ,"2005 me at the zoo\n2020 me at the zoom");
        meAtTheZoo.AddComment("@hyri3188" ,"If he uploads another video with the title: Me leaving the zoo, that will be the end of YouTube");

        Video rickroll = new Video();
        rickroll._title = "Rick Astley - Never Gonna Give You Up (Official Video) (4K Remaster)";
        rickroll._author = "Rick Astley";
        rickroll._length = 213;
        rickroll.AddComment("@YouTube", "can confirm: he never gave us up");
        rickroll.AddComment("@SonimodGT" ,"Petition to make this the national anthem of the internet");
        rickroll.AddComment("@lillyie" ,"Imagine if Rick Astley dies everyone would be too afraid to click a link to articles announcing his death because it might be a rickroll");

        Video keyboardcat = new Video();
        keyboardcat._title = "Keyboard Cat! - THE ORIGINAL!";
        keyboardcat._author = "Keyboard Cat!";
        keyboardcat._length = 54;
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