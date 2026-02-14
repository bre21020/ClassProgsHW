public class Word {
        public string _word;
        public bool _hidden = false;

        public Word(string word) {
            _word = word;
        }

        public string CurrentStateOfWord() {
            if (_hidden == false) {
                return _word;
            } else {
                return "____";
            }
        }
    }