using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="DateTime"/>.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts DateTime to unix time stamp.
        /// </summary>
        /// <param name="dateTime">The DateTime.</param>
        /// <returns>The unix time stamp.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var dateTime = DateTime.Parse("02/16/2008 12:15:12", new CultureInfo("en-US"));
        /// var result = date.DateTimeToUnixTimeStamp();
        /// 
        /// /*
        /// result is 1203164112
        /// */
        /// </code>
        /// </example>
        public static long DateTimeToUnixTimeStamp(this DateTime dateTime)
        {
            long unixTimestamp = dateTime.Ticks - new DateTime(1970, 1, 1).Ticks;
            unixTimestamp /= TimeSpan.TicksPerSecond;

            return unixTimestamp;
        }

        /// <summary>
        /// Converts unix time stamp to DateTime.
        /// </summary>
        /// <param name="unixTimestamp">The unix time stamp.</param>
        /// <returns>The DateTime.</returns>
        /// <example>
        /// <code lang="csharp">
        /// long unixTimestamp = 1203164112;
        /// var result = unixTimestamp.UnixTimeStampToDateTime().ToString("MM/dd/yyyy HH:mm:ss");
        /// 
        /// /*
        /// result is 02/16/2008 12:15:12
        /// */
        /// </code>
        /// </example>
        public static DateTime UnixTimeStampToDateTime(this long unixTimestamp)
        {
            var dateTime = new DateTime(1970, 1, 1);
            long unixTimeStampInTicks = unixTimestamp * TimeSpan.TicksPerSecond;

            return new DateTime(dateTime.Ticks + unixTimeStampInTicks);
        }

        /// <summary>
        /// Returns the DateTime with the ticks trimmed.
        /// </summary>
        /// <param name="dateTime">The DateTime.</param>
        /// <returns>A DateTime with the ticks trimmed.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var dateTime = DateTime.Now.TrimTicks();
        /// </code>
        /// </example>
        public static DateTime TrimTicks(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond, dateTime.Kind);
        }

        /// <summary>
        /// Returns the DateTime with the milliseconds trimmed.
        /// </summary>
        /// <param name="dateTime">The DateTime.</param>
        /// <returns>A DateTime with the milliseconds trimmed.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var dateTime = DateTime.Now.TrimMilliseconds();
        /// </code>
        /// </example>
        public static DateTime TrimMilliseconds(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Kind);
        }

        /// <summary>
        /// Returns a Datetime with the seconds trimmed.
        /// </summary>
        /// <param name="dateTime">The DateTime.</param>
        /// <returns>A DateTime with the seconds trimmed.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var dateTime = DateTime.Now.TrimSecondsAndMilliseconds();
        /// </code>
        /// </example>
        public static DateTime TrimSecondsAndMilliseconds(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0, 0, dateTime.Kind);
        }
    }
}
