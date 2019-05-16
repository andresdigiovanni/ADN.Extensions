using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="Object"/>.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Clone a serializable object.
        /// </summary>
        /// <param name="source">Object to clone.</param>
        /// <returns>A clone of the object.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var person1 = new Person()
        /// {
        ///     FirstName = "Luke",
        ///     LastName = "Skywalwer"
        /// };
        /// var person2 = person1.DeepClone();
        /// </code>
        /// </example>
        public static T DeepClone<T>(this T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable", "source");
            }

            if (source is null)
            {
                return default;
            }

            var formatter = new BinaryFormatter();
            using (Stream stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
