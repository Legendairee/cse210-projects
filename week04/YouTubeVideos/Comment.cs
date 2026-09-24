public class Comment
{
    private string _nameOfCommenter;
    private string _commentContent;

    public Comment(string nameOfCommenter, string commentContent)
    {
        _nameOfCommenter = nameOfCommenter;
        _commentContent = commentContent;
    }

    public void Display()
    {
        Console.WriteLine($"   --- {_nameOfCommenter}: {_commentContent}");
    }
}