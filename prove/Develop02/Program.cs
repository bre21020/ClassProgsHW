using System;



class Program
{
    public class Entry {
        public string _prompt;
        public string _date;
        public string _response;

        //public string CreateEntry() {
        //    string FullEntry = _date + _prompt + _response;
        //    return FullEntry;
        //}
        
    }
    static List<Entry> UserEntries = new List<Entry>();
    static List<string> Prompts = new List<string>();
    static void Main(string[] args)
    {   
        int user_selection = 0;
        PopulatePromptList();
        while (user_selection != 5) { //5 is quit
            user_selection = DisplayMenu();
            if (user_selection == 1) {
                Write();
            } else if (user_selection == 2) {
                DisplayEntries();
            } else if (user_selection == 3) {
                Console.WriteLine("this option does nothing!");
            } else if (user_selection == 4) {
                Console.WriteLine("this option does nothing!");
            } else if (user_selection == 5) {
                break;
            } else {
                Console.Write("Pick one of the options on the list (ex: 1)\n");
            }
        }
        Console.WriteLine("later nerd");
    }
    public static int DisplayMenu() {
        Console.Write("Welcome to the Journal Program!\nPlease make a selection:\n1.Write\n2.Display\n3.Load\n4.Display\n5.Quit\n");
        int selection = int.Parse(Console.ReadLine());
        return selection;
    }
    public static void Write() {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, Prompts.Count());
        string prompt = Prompts[index];
        
        Console.WriteLine(prompt);
        Console.Write("> ");
        string userResponse = Console.ReadLine();
        string currentDate = DateTime.Now.ToShortDateString();

        Entry NewEntry = new Entry();
        NewEntry._prompt = prompt;
        NewEntry._date = currentDate;
        NewEntry._response = userResponse;
        UserEntries.Add(NewEntry);
    }
    public static void DisplayEntries() {
        for (int i = 0; i < UserEntries.Count; i++) {
            Console.WriteLine(UserEntries[i]._date + " " + UserEntries[i]._prompt + " " + UserEntries[i]._response);
        }
    }
    public static void PopulatePromptList() {
        Prompts.Add("Yo this a promp");
        Prompts.Add("Yo this aalso promp");
        Prompts.Add("Yo this a super promp");
        Prompts.Add("how many prompts do you need until you are satisfied?");
        Prompts.Add("why did the chicken cross the road?");
        Prompts.Add("Do you go for negative skip tags?");
        Prompts.Add("How long does it take to grasp the C# system?");
        Prompts.Add("I know the whole point is that every data type is specificed, but I like not needing to have to in other langauges. its nice.");
        Prompts.Add("Ever play pinball by sense of smell?");
        Prompts.Add("If you could make a deal with God, could you get him to swap your places?");
        Prompts.Add("I wonder if having a million prompts will justify only having 1 of the 2 classes. What do you think?");
        Prompts.Add("What's your power level?");
        Prompts.Add("Stack of ice, or a water bucket?");
        Prompts.Add("If your working on a Friday, is it really a Friday?");
        Prompts.Add("What do you get when you cross?"); //sore fingers, you can stop crossing them now
        Prompts.Add("Crab Claw or Penguin?");
        Prompts.Add("What's your FLap on Moo Moo Farm?");
        Prompts.Add("Ever installed letter bomb?");
        Prompts.Add("Opponent moves knight to H5, putting your king in check. How do you respond?");
        Prompts.Add("Why IS there a shark at the bottom of the lakeside lab?");
        Prompts.Add("If your memories and brain and body are all made out of specifically arranged atoms, how do you know you actually lived your life, and weren't spontaneously created and arranged last Thursday? By that extent, how do you know the whole universe wasn't created and assembled last Thursday? You remember before last Thursday, but that's because your brain was assembled perfectly to have those memories, they didn't actually happen. Go ahead. Prove me wrong. ");
        Prompts.Add("How did Biff get back to 2015 after giving his younger self the Almanac?");
        Prompts.Add("How long did it take her to smile?");
        Prompts.Add("Did you know you can crash Lego Star Wars Complete Saga by selecting a hidden menu option in the Indianna Jones door?");
        Prompts.Add("Just because you hide in a bush it doesn't mean that your hidden. Draw distance for bushes is way shorter than it is for players.");
        Prompts.Add("Secret Friday Update!");
        Prompts.Add("How many belly jeans can fit in your belly button?");
        Prompts.Add("Should you trust someone when they say you can't trust anyone?");
        Prompts.Add("Which pocket do you put your wallet in?");
        Prompts.Add("Where did she go? How did she go missing? Why does the roots minigame line up pretty close to the light world?");
        Prompts.Add("Did the piano with teeth scare you as a kid?");
        Prompts.Add("How many hours do you spend on social media?");
        Prompts.Add("What's the deal with the pink and yellow motif?");
        Prompts.Add("Do you know Rick?");
        Prompts.Add("What's your favorite password to use when making bank accounts?");
        Prompts.Add("What's your favorite song?");
        Prompts.Add("What's your favorite song that nobody can ever learn about?");
        Prompts.Add("Who has time for that, anyway?");
        Prompts.Add("Cups don't have cancer.");
        Prompts.Add("What line if crossed will cause you to run for your life and call the cops? Other than the obvious, of course.");
        Prompts.Add("Did you ever figure out how to play Retro Rewind online? I hear the VR leaderboards have gotten spicy...");
        Prompts.Add("Prompts.Add()");
        Prompts.Add("Would you make the king a sandwich at 3am? Your life may depend on the answer.");
        Prompts.Add("Get over it already.");
        Prompts.Add("Half a point for Wade!");
        Prompts.Add("Did Francis Bacon write Shakespeare?");
        Prompts.Add("How do you spell Shakespeare?");
        Prompts.Add("Sparky was never real, it was all a big hoax.");
        Prompts.Add("How did Dave get this job? It wasn't inteded for him.");
        Prompts.Add("Did you bring your scary tape?");
        Prompts.Add("Why did you talk to them? They were red. You could have gotten in serious trouble");
        Prompts.Add("Did anybody find out that you beat Mario Bros 3?");
        Prompts.Add("What do you set your render distance to?");
        Prompts.Add("Cake or Fake? I think it depends on how your feeling that day.");
        Prompts.Add("How crazy would it be if all of these prompts were entered in manually? Its true, no AI here. Although maybe I should spend this time and effort getting that second class implemented, but nah. Not enough brain power to figure that out. The program works well enough.");
        Prompts.Add("Madness in ante 3. Do you go for it? How bout ante 4?");
        Prompts.Add("Would you rather have a code editor that crashes often, or a code editor that only crashes right before you save a whole bunch of progress?");
        Prompts.Add("How do you export a movie if you've accidentally shot every scene with variable framerate?");
        Prompts.Add("How fast is too fast?");
        Prompts.Add("Ever been hit by a car?");
        Prompts.Add("Ever been hit by another car?");
        Prompts.Add("What would you do if you found dog residue in your pocket?");
        Prompts.Add("Do you start seeing shadows at 24? Do they gain shape and color as you approach 36? Or do you go to bed before that ever happens?");
        Prompts.Add("ADD PROMPT HERE");
        Prompts.Add("Do you remember? Or have you forgotten?");
        Prompts.Add("Don't let your tears hit the business card");
        Prompts.Add("How old is too old to be ordering unicorn flavored ice cream at the parlor?");
        Prompts.Add("Do you trust your barber? Why not? Have you forgiven him yet?");
        Prompts.Add("Did you know that you can't fight Betty Jetty until you interact with the phone booth?");
        Prompts.Add("Have you ever actually heard what they say about airline food?");
        Prompts.Add("Does the road work ahead?");
        Prompts.Add("Go directly to jail. Do not pass GO, do not collect 200$.");
        Prompts.Add("Don't mine at night. Or do. I don't care, you're a grown up and you're able to make your own descicions.");
        Prompts.Add("How do you spell desciioncions?");
        Prompts.Add("is there a limit to how long a list can be?");
    }
}
