using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class TestEnumeration : Enumeration
    {
        public static TestEnumeration Created = new TestEnumeration(1, nameof(Created));
        public static TestEnumeration Approved = new TestEnumeration(2, nameof(Approved));

        public TestEnumeration()
        {
        }

        public TestEnumeration(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<TestEnumeration> List() => new[] { Created, Approved };
    }

    public class EnumerationTests
    {
        [Fact]
        public void Enumeration_NameAndId_ShouldReturnCorrectly()
        {
            Assert.Equal(1, TestEnumeration.Created.Id);
            Assert.Equal("Created", TestEnumeration.Created.Name);
        }
        
        [Fact]
        public void Enumeration_ToString()
        {
            Assert.Equal(1, TestEnumeration.Created.Id);
            Assert.Equal("Created", TestEnumeration.Created.ToString());
        }

        [Fact]
        public void Enumeration_GetAll()
        {
            Assert.True(2 == Enumeration.GetAll<TestEnumeration>().Count());
        }

        [Fact]
        public void Enumeration_Equals()
        {
            var target = Enumeration.FromValue<TestEnumeration>(1);

            Assert.True(TestEnumeration.Created.Equals(target));
            Assert.True(TestEnumeration.Created == target);
            Assert.False(TestEnumeration.Created != target);
            Assert.Equal(0, TestEnumeration.Created.CompareTo(target));
            
            target = Enumeration.FromValue<TestEnumeration>(2);
            
            Assert.False(TestEnumeration.Created.Equals(target));
            Assert.False(TestEnumeration.Created == target);
            Assert.True(TestEnumeration.Created != target);
            Assert.NotEqual(0, TestEnumeration.Created.CompareTo(target));
        }

        [Fact]
        public void Enumeration_AbsoluteDifference()
        {
            Assert.Equal(1, Enumeration.AbsoluteDifference(TestEnumeration.Created, TestEnumeration.Approved));
        }

        [Fact]
        public void Enumeration_FromValue()
        {
            Assert.Equal(Enumeration.FromValue<TestEnumeration>(1), TestEnumeration.Created);
        }

        [Fact]
        public void Enumeration_FromDisplayName()
        {
            Assert.Equal(Enumeration.FromDisplayName<TestEnumeration>("Created"), TestEnumeration.Created);
        }
    }
}
