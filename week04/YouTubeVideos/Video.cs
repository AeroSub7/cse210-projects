using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void Display()
    {
        Console.WriteLine($"'{_title}' by {_author} Length:{_length} Number of Comments:{NumberOfComments()}");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}