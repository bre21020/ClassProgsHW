public class Comment {
    private string _commentAuthor;
    private string _commentText;
    public Comment(string author, string text) {
        _commentAuthor = author;
        _commentText = text;
    }
    public void DisplayComment() {
        string DisplayedInfo = $"{_commentAuthor}: {_commentText}";
        Console.WriteLine(DisplayedInfo);
    }
    public string GetCommentAuthor() {
        return _commentAuthor;
    }
    public string GetCommentText() {
        return _commentText;
    }
}