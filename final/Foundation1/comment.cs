public class Comment {
    string _CommentAuthor;
    string _CommentText;
    public Comment(string author, string text) {
        _CommentAuthor = author;
        _CommentText = text;
    }
    public void DisplayComment() {
        string DisplayedInfo = $"{_CommentAuthor}: {_CommentText}";
        Console.WriteLine(DisplayedInfo);
    }
}