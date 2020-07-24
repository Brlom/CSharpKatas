using Katas.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class GetTweetDataTests
    {
        [Fact]
        public void GetTweetData_WhenPassedEmptyStr_ShouldReturnEmptyObject()
        {
            // arrange
            string empty = String.Empty;
            GetTweetData x = new GetTweetData();
            Object expected = null;

            // act
            Object actual = x.ReturnTweetData(empty);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetTweetData_WhenPassedStrWithNoTweets_ShouldReturnTweetDataObjectWithStrLength()
        {
            // arrange
            string original = "My awesome tweet";
            GetTweetData x = new GetTweetData();
            var tagList = new List<string>();
            var mentionsList = new List<string>();
            TweetDataObject expected = new TweetDataObject
            {
                Tags = tagList,
                Mentions = mentionsList,
                TagCount = 0,
                MentionCount = 0,
                StringLength = 16
            };

            // act
            TweetDataObject actual = x.ReturnTweetData(original);

            // assert
            Assert.Equal(expected.Tags, actual.Tags);
            Assert.Equal(expected.Mentions, actual.Mentions);
            Assert.Equal(expected.TagCount, actual.TagCount);
            Assert.Equal(expected.MentionCount, actual.MentionCount);
            Assert.Equal(expected.StringLength, actual.StringLength);
        }

        [Fact]
        public void GetTweetData_WhenPassedStrWithAMention_ShouldReturnTweetDataObjectWithMentionAndNumMentions()
        {
            // arrange
            string original = "My awesome tweet to @northcoders";
            GetTweetData x = new GetTweetData();
            var tagList = new List<string>();
            var mentionsList = new List<string>();
            mentionsList.Add("@northcoders");
            TweetDataObject expected = new TweetDataObject
            {
                Tags = tagList,
                Mentions = mentionsList,
                TagCount = 0,
                MentionCount = 1,
                StringLength = 32
            };

            // act
            TweetDataObject actual = x.ReturnTweetData(original);

            // assert
            Assert.Equal(expected.Tags, actual.Tags);
            Assert.Equal(expected.Mentions, actual.Mentions);
            Assert.Equal(expected.TagCount, actual.TagCount);
            Assert.Equal(expected.MentionCount, actual.MentionCount);
            Assert.Equal(expected.StringLength, actual.StringLength);
        }

        [Fact]
        public void GetTweetData_WhenPassedStrWithATag_ShouldReturnTweetDataObjectWithTagAndNumTags()
        {
            // arrange
            string original = "My awesome tweet about #coding";
            GetTweetData x = new GetTweetData();
            var tagList = new List<string>();
            tagList.Add("#coding");
            var mentionsList = new List<string>();
            TweetDataObject expected = new TweetDataObject
            {
                Tags = tagList,
                Mentions = mentionsList,
                TagCount = 1,
                MentionCount = 0,
                StringLength = 30
            };

            // act 
            TweetDataObject actual = x.ReturnTweetData(original);

            // assert
            Assert.Equal(expected.Tags, actual.Tags);
            Assert.Equal(expected.Mentions, actual.Mentions);
            Assert.Equal(expected.TagCount, actual.TagCount);
            Assert.Equal(expected.MentionCount, actual.MentionCount);
            Assert.Equal(expected.StringLength, actual.StringLength);
        }

        [Fact]
        public void GetTweetData_WhenPassedStrWithATagAndAMention_ShouldReturnTweetDataObjWithAllValues()
        {
            // arrange
            string original = "My awesome tweet about #coding to @northcoders";
            GetTweetData x = new GetTweetData();
            var tagList = new List<string>();
            tagList.Add("#coding");
            var mentionsList = new List<string>();
            mentionsList.Add("@northcoders");
            TweetDataObject expected = new TweetDataObject
            {
                Tags = tagList,
                Mentions = mentionsList,
                TagCount = 1,
                MentionCount = 1,
                StringLength = 46
            };

            // act
            TweetDataObject actual = x.ReturnTweetData(original);

            // assert
            Assert.Equal(expected.Tags, actual.Tags);
            Assert.Equal(expected.Mentions, actual.Mentions);
            Assert.Equal(expected.TagCount, actual.TagCount);
            Assert.Equal(expected.MentionCount, actual.MentionCount);
            Assert.Equal(expected.StringLength, actual.StringLength);
        }

        [Fact]
        public void GetTweetData_WhenPassedStrWithSeveralTagsAndMentions_ShouldReturnUpdatedTweetDataObject()
        {
            // arrange
            string original = "I am #coding with @northcoders I love #coding and @northcoders";
            GetTweetData x = new GetTweetData();
            var tagList = new List<string>();
            tagList.Add("#coding");
            var mentionsList = new List<string>();
            mentionsList.Add("@northcoders");
            TweetDataObject expected = new TweetDataObject
            {
                Tags = tagList,
                Mentions = mentionsList,
                TagCount = 1,
                MentionCount = 1,
                StringLength = 62
            };

            // act
            TweetDataObject actual = x.ReturnTweetData(original);

            // assert
            Assert.Equal(expected.Tags, actual.Tags);
            Assert.Equal(expected.Mentions, actual.Mentions);
            Assert.Equal(expected.TagCount, actual.TagCount);
            Assert.Equal(expected.MentionCount, actual.MentionCount);
            Assert.Equal(expected.StringLength, actual.StringLength);
        }

    }
}
