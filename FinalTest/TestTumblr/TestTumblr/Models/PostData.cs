using System;
using System.Collections.Generic;
using System.Text;

namespace TestTumblr
{
    public class PostData
    {
        public PostData(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }

        public string Description { get; set; }


        public PostData()
        {

        }
    }
}
