public class Reference {
        public string _book;
        public string _chapter;
        public string _verses;

        public string DisplayReference() {
            string combinedReference = "[" + _book + " " + _chapter + ": " + _verses + "] ";
            return combinedReference;
        }
    }

