// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Suggested search string to be used for further search for time series instances. </summary>
    public partial class SearchSuggestion
    {
        /// <summary> Initializes a new instance of SearchSuggestion. </summary>
        internal SearchSuggestion()
        {
        }

        /// <summary> Initializes a new instance of SearchSuggestion. </summary>
        /// <param name="searchString"> Suggested search string. Can be used for further search for time series instances. </param>
        /// <param name="highlightedSearchString"> Highlighted suggested search string to be displayed to the user. Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions of text that matched the search string. Do not use highlighted search string to do further search calls. </param>
        internal SearchSuggestion(string searchString, string highlightedSearchString)
        {
            SearchString = searchString;
            HighlightedSearchString = highlightedSearchString;
        }

        /// <summary> Suggested search string. Can be used for further search for time series instances. </summary>
        public string SearchString { get; }
        /// <summary> Highlighted suggested search string to be displayed to the user. Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions of text that matched the search string. Do not use highlighted search string to do further search calls. </summary>
        public string HighlightedSearchString { get; }
    }
}
