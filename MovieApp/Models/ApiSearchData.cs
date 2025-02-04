﻿using System.Collections.Generic;

namespace MovieApp.Models
{
    public class ApiSearchData
    {
        public ApiSearchData()
        {
            ErrorMessage = string.Empty;
            Results = new List<SearchResult>();
        }

        public ApiSearchData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Results = null;
        }

        public string SearchType { get; set; }
        public string Expression { get; set; }
        public List<SearchResult> Results { get; set; }
        public string ErrorMessage { get; set; }
    }



    public class SearchResult
    {
        public string Id { get; set; }
        public string ResultType { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public enum SearchType
    {
        Title = 1,
        Movie = 2,
        Series = 4,
        Name = 8,
        Episode = 16,
        Company = 32,
        Keyword = 64,
        All = 128
    }
}