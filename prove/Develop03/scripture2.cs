public class Scripture {
    /////////////////// Creating Necessary Variables
        public string _text;
        public List<string> _processedList;
        List<Word> wordObjects = new List<Word>();
        public bool _havewordsbeenhiddenyet = false;
    ////////////////// set the list named _processedList to equal a list of every word in the _text,
    /// and then set the list named wordObjects to a list of objects, one for every word in _processedList.
    /// Call when you want to initialize a scripture as the scripture for the game.
        public List<Word> GetWordObjects() {
            _processedList = _text.Split(" ").ToList();
            foreach (string word in _processedList) {
                wordObjects.Add(new Word(word));
            }
            return wordObjects;
        }
    ////////////////// DisplayFullList
    /// scriptRef is a parameter passed through when the function is called
    /// start by clearing out the console (makes it easier to focus on the scripture)
    /// make a new list of strings called displayWords
    /// for every object in the wordObjects list (created in getWordObjects())
    /// add the current state of that word (shown or hidden) to the display words list
    /// Combine the scripture reference with a string made out of all the current word states and display it.
    /// (easier to see it displayed when all the extra nonsense in the console has been cleared)
        public void DisplayFullList(string scriptRef) {
            Console.Clear();
            List<string> displayWords = new List<string>();
            foreach (Word word in wordObjects) {
                displayWords.Add(word.CurrentStateOfWord());
            }
            Console.WriteLine(scriptRef + string.Join(" ", displayWords));
        }
    /////////////////// We have a list of word objects called shownWords
    /// Make a function named HideWord, should do the actual work of changing the current word state
    /// We start by looking at the list of word objects (created in getWordObjects)
    /// if it's current hidden state is false (meaning it should display the word itself and not ____)
    /// then add it to the shownWords list. This is so that we know which words are still availible to be hidden
    /// Then, pick a random number from 0 to the length of the shownWords list.
    /// Find the word object in shownwords and change it's state to hidden.
        public List<Word> shownWords = new List<Word>();
        private static Random _random = new Random();
        public void HideWord() {
            shownWords = new List<Word>();
            foreach (Word word in wordObjects) {
                if (word._hidden == false) {
                    //if (shownWords.Count > 0) {
                        shownWords.Add(word);
                    //}
                }
            }
            
            //Random random = new Random();

            if (shownWords.Count == 0) { 
                if(_havewordsbeenhiddenyet == true) ExitGame();
                return;
            }
            int randomIndex = _random.Next(0, shownWords.Count);
            shownWords[randomIndex]._hidden = true;
        }

        
        public bool ExitGame() {
            foreach (Word word in wordObjects) {
                if (word._hidden == false) {
                    return true;
                }
            }
            return false;
        }

        public void HideWords(int iterations) {
            //if (shownWords.Count - iterations >= 0) {
                for (int i = 0; i < iterations; i++) {
                    HideWord();
                }
                //Console.WriteLine(shownWords);
            //}
        }

    }




//Code down here was written by AI for the purpose of learning to write CSharp

//public List<string> GetWords(string text)
//{
//    return text.Split(' ').ToList();
//}

//Console.WriteLine(string.Join(", ", words));

// Convert the string list to object list


//public List<Word> GetWordObjects(string text)
//{
//    List<string> words = text.Split(' ').ToList();
//    List<Word> wordObjects = new List<Word>();
//    
//    foreach (string word in words)
//    {
//        wordObjects.Add(new Word(word));
//    }
//    
//    return wordObjects;
//}