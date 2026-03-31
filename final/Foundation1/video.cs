public class Video {
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments = new List<Comment>();
    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
    public void AddComment(string author, string text) {
        _comments.Add(new Comment(author, text));
    }
    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }
    public void Display() {
        //display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.
        string DisplayedInfo = $"{_title} uploaded by {_author}\n{_length}s\n";
        Console.WriteLine(DisplayedInfo);
        foreach (Comment comment in _comments) {
            comment.DisplayComment();
        }
    }
    public string GetTitle() {
        return _title;
    }
    public string GetAuthor() {
        return _author;
    }
    public int GetLength() {
        return _length;
    }
}