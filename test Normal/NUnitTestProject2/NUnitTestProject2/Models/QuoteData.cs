using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject2
{
    public class QuoteData
    {
        public QuoteData(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }

        public string Description { get; set; }

    }
}

