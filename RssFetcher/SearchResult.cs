using System;
using System.Collections.Generic;
using System.Text;

namespace RssFetcher
{
    public class SearchResult
    {
        public long Id { get; set; }
        public string Source { get; set; }
        public string Link { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }

    }
}
