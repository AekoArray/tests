using System;

public class PostData
{
    public PostData(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public PostData() { }

    public string Title { get; set; }

    public string Description { get; set; }

}
