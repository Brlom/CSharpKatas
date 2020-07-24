using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas.Core
{
    public class GetTweetData
    {
        public TweetDataObject ReturnTweetData(string originalStr)
        {
            if (originalStr == String.Empty)
            {
                return null;
            }

            TweetDataObject newDataObject = new TweetDataObject
            {
                Tags = FindTags(originalStr),
                Mentions = FindMentions(originalStr),
                TagCount = FindTags(originalStr).Count,
                MentionCount = FindMentions(originalStr).Count,
                StringLength = originalStr.Length
            };

            return newDataObject;
        }

        public List<string> FindMentions(string fullStr)
        {
            if (fullStr == String.Empty)
            {
                return new List<string>();
            }

            var mentionsMatch = Regex.Matches(fullStr, @"[@][A-Za-z]+")
                .OfType<Match>()
                .Select(m => m.Value)
                .ToList<string>();

            return mentionsMatch.Distinct().ToList<string>();
        }

        public List<string> FindTags(string fullStr)
        {
            if (fullStr == String.Empty)
            {
                return new List<string>();
            }

            var tagsMatch = Regex.Matches(fullStr, @"[#][A-Za-z]+")
                .OfType<Match>()
                .Select(m => m.Value)
                .ToList<string>();

            return tagsMatch.Distinct().ToList<string>();
        }
    }

    public class TweetDataObject
    {
        public List<string> Tags { get; set; }
        public List<string> Mentions { get; set; }
        public int TagCount { get; set; }
        public int MentionCount { get; set; }
        public int StringLength { get; set; }
    }

}
