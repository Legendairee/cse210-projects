public class Video
{
    private string _title;
    private string _author;
    private int _videoLengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int videoLengthInSeconds)
    {
        _title = title;
        _author = author;
        _videoLengthInSeconds = videoLengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_videoLengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}