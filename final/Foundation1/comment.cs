public class Comment {
    private string _CommentAuthor;
    private string _CommentText;
    public Comment(string author, string text) {
        _CommentAuthor = author;
        _CommentText = text;
    }
    public void DisplayComment() {
        string DisplayedInfo = $"{_CommentAuthor}: {_CommentText}";
        Console.WriteLine(DisplayedInfo);
    }
    public string GetCommentAuthor() {
        return _CommentAuthor;
    }
    public string GetCommentText() {
        return _CommentText;
    }
}