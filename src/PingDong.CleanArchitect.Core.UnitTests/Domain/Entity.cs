using MediatR;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class TestEntity : Entity<int>
    {
        public string Name { get; }

        public TestEntity(string name)
        {
            Name = name;
        }

        public void Save(int id)
        {
            Id = id;
        }
    }
    public class TestEntityAnother : Entity<int>
    {
        public string Name { get; }

        public TestEntityAnother(string name)
        {
            Name = name;
        }
    }

    public class TestNotification : INotification
    {

    }

    public class EntityTests
    {
        [Fact]
        public void Entity_ShouldHaveDefault_AfterInitialized()
        {
            var t = new TestEntity("name");

            Assert.Equal(default, t.Id);
            Assert.True(t.IsTransient());
        }

        [Fact]
        public void Entity_ShouldNotEqual_If_AreNotEntity()
        {
            var t = new TestEntity("name");
            
            Assert.False(t.Equals("a"));
        }

        [Fact]
        public void Entity_ShouldNotEqual_If_AreNotSameType()
        {
            var t = new TestEntity("name");
            var ta = new TestEntityAnother("name");
            
            Assert.False(t.Equals(ta));
        }

        [Fact]
        public void Entity_ShouldEqual_If_ReferenceEqual()
        {
            var t = new TestEntity("name");
            var ta = t;
            
            Assert.True(t.Equals(ta));
            Assert.True(t == ta);
            Assert.False(t != ta);
        }

        [Fact]
        public void Entity_ShouldNotEqual_If_AnyOneIsTransient()
        {
            var t = new TestEntity("name");
            var ta = new TestEntity("name");
            
            Assert.False(t.Equals(ta));
            Assert.True(t != ta);
            Assert.False(t == ta);

            t.Save(1);
            Assert.False(t.Equals(ta));
            Assert.True(t != ta);
            Assert.False(t == ta);

            t = new TestEntity("name");
            ta.Save(1);
            Assert.False(t.Equals(ta));
            Assert.True(t != ta);
            Assert.False(t == ta);
        }

        [Fact]
        public void Entity_ShouldEqual_If_NoneIsTransient()
        {
            var t = new TestEntity("name");
            var ta = new TestEntity("name");
            
            t.Save(1);
            ta.Save(1);

            Assert.True(t.Equals(ta));
            Assert.True(t == ta);
            Assert.False(t != ta);
        }

        [Fact]
        public void Entity_ShouldNotEqual_If_IdDoesNotMatch()
        {
            var t = new TestEntity("name");
            var ta = new TestEntity("name");
            
            t.Save(1);
            ta.Save(2);

            Assert.False(t.Equals(ta));
            Assert.True(t != ta);
            Assert.False(t == ta);
        }

        [Fact]
        public void DomainEvents_ShouldEmpty_AfterInit()
        {
            var t = new TestEntity("name");

            Assert.Null(t.DomainEvents);
        }

        [Fact]
        public void DomainEvents_ShouldAddProperly()
        {
            var t = new TestEntity("name");

            Assert.Null(t.DomainEvents);
            t.AddDomainEvent(new TestNotification());
            Assert.Equal(1, t.DomainEvents.Count);
        }

        [Fact]
        public void DomainEvents_ShouldRemoveProperly()
        {
            var t = new TestEntity("name");
            var notification = new TestNotification();

            t.AddDomainEvent(notification);
            Assert.Equal(1, t.DomainEvents.Count);

            t.RemoveDomainEvent(notification);
            Assert.Empty(t.DomainEvents);
        }

        [Fact]
        public void DomainEvents_ShouldClearProperly()
        {
            var t = new TestEntity("name");
            var notification = new TestNotification();

            t.AddDomainEvent(notification);
            Assert.Equal(1, t.DomainEvents.Count);

            t.ClearDomainEvents();
            Assert.Empty(t.DomainEvents);
        }
    }
}
