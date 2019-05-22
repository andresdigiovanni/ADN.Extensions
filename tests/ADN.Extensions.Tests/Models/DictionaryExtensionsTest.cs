using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class DictionaryExtensionsTest
    {
        [Fact]
        public void RemoveAll()
        {
            var dictionary = new Dictionary<string, int>
            {
                { "Luke", 1 },
                { "Skywalker", 2 },
                { "Leia", 3 }
            };
            dictionary.RemoveAll(value => value == 2);

            Assert.Equal(2, dictionary.Count);
        }

        [Fact]
        public void RemoveAll_duplicate()
        {
            var dictionary = new Dictionary<string, int>
            {
                { "Luke", 1 },
                { "Skywalker", 2 },
                { "Leia", 2 }
            };
            dictionary.RemoveAll(value => value == 2);

            Assert.Single(dictionary);
        }

        [Fact]
        public void RemoveAll_nomatch()
        {
            var dictionary = new Dictionary<string, int>
            {
                { "Luke", 1 },
                { "Skywalker", 2 },
                { "Leia", 3 }
            };
            dictionary.RemoveAll(value => value == 10);

            Assert.Equal(3, dictionary.Count);
        }

        [Fact]
        public void RemoveAll_empty()
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.RemoveAll(value => value == 2);

            Assert.Empty(dictionary);
        }
    }
}
