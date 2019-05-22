using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="IDictionary"/>.
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Remove all elements in the dictionary that match the predicate.
        /// </summary>
        /// <typeparam name="TKey">Dictionary key.</typeparam>
        /// <typeparam name="TValue">Dictionary value.</typeparam>
        /// <param name="dict">The dictionary to modify.</param>
        /// <param name="predicate">The predicate to make the match.</param>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var dictionary = new Dictionary<string, int>]]>
        /// {
        ///     { "Luke", 1 },
        ///     { "Skywalker", 2 }
        /// };
        /// dictionary.RemoveAll(value => value == 2);
        /// 
        /// /*
        /// dictionary contains the values [ {"Luke", 1} ]
        /// */
        /// </code>
        /// </example>
        public static void RemoveAll<TKey, TValue>(this IDictionary<TKey, TValue> dict, Func<TValue, bool> predicate)
        {
            var keys = dict.Keys.Where(k => predicate(dict[k])).ToList();
            foreach (var key in keys)
            {
                dict.Remove(key);
            }
        }
    }
}
