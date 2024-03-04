using System;

public class Post
{
    private int _voteCount;

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationTime { get; }

    public int VoteCount
    {
        get { return _voteCount; }
    }

    public Post(string title, string description)
    {
        Title = title;
        Description = description;
        CreationTime = DateTime.Now;
        _voteCount = 0;
    }

    public void UpVote()
    {
        _voteCount++;
    }

    public void DownVote()
    {
        _voteCount--;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Post post = new Post("Example Post", "This is an example post for StackOverflow.");

        post.UpVote();
        post.UpVote();
        post.DownVote();

        Console.WriteLine($"Title: {post.Title}");
        Console.WriteLine($"Description: {post.Description}");
        Console.WriteLine($"Creation Time: {post.CreationTime}");
        Console.WriteLine($"Vote Count: {post.VoteCount}");
    }
}
