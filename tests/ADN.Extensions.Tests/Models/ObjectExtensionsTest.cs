using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class ObjectExtensionsTest
    {
        [Fact]
        public void DeepClone()
        {
            var person1 = new Person()
            {
                FirstName = "Luke",
                LastName = "Skywalwer"
            };
            var person2 = person1.DeepClone();

            Assert.True(PersonsAreEqual(person1, person2));
        }

        [Fact]
        public void DeepClone_ChangeObject()
        {
            var person1 = new Person()
            {
                FirstName = "Luke",
                LastName = "Skywalwer"
            };
            var person2 = person1.DeepClone();
            person2.FirstName = "Mike";

            Assert.False(PersonsAreEqual(person1, person2));
        }

        [Fact]
        public void DeepClone_Null()
        {
            Person person1 = null;
            var person2 = person1.DeepClone();

            Assert.Null(person2);
        }

        [Fact]
        public void DeepClone_ArgumentException_NonSerializable()
        {
            var person1 = new Person_NonSerializable()
            {
                FirstName = "Luke",
                LastName = "Skywalwer"
            };

            Assert.Throws<ArgumentException>(() => person1.DeepClone());
        }

        public bool PersonsAreEqual(Person person1, Person person2)
        {
            return person1.FirstName == person2.FirstName &&
                person1.LastName == person2.LastName;
        }
    }

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Person_NonSerializable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
