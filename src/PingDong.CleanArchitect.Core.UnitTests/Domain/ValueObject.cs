using System;
using System.Collections.Generic;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class TestValueObject : ValueObject
    {
        public String No { get; }
        public String Street { get; }
        public String City { get; }
        
        public TestValueObject(string no, string street, string city)
        {
            No = no;
            Street = street;
            City = city;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return No;
            yield return Street;
            yield return City;
        }
    }

    public class ValueObjectTests
    {
        [Fact]
        public void ValueObject_Equals()
        {
            var t1 = new TestValueObject("1", "ST", "CT");
            var t2 = new TestValueObject("2", "ST", "CT");
            var t3 = new TestValueObject("1", "ST", "CT");

            Assert.Equal(t1, t3);
            Assert.True(t1.Equals(t3));
            Assert.True(t1 == t3);
            Assert.False(t1 != t3);

            Assert.NotEqual(t1, t2);
            Assert.False(t1.Equals(t2));
            Assert.False(t1 == t2);
            Assert.True(t1 != t2);
        }
        [Fact]
        public void ValueObject_Clone()
        {
            var t1 = new TestValueObject("1", "ST", "CT");
            var t2 = t1.Clone();

            Assert.Equal(t1, t2);
            Assert.True(t1.Equals(t2));
            Assert.True(t1 == t2);
            Assert.False(t1 != t2);
        }
    }
}
