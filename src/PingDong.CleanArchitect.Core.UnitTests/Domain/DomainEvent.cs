using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class DomainEventTest
    {
        [Fact]
        public void DomainEvent_EmptyCtor()
        {
            var evt = new DomainEvent();

            Assert.Null(evt.CorrelationId);
        }

        [Fact]
        public void DomainEvent_WithCorrelationId()
        {
            var evt = new DomainEvent("Test");

            Assert.Equal("Test", evt.CorrelationId);
        }

        [Fact]
        public void DomainEvent_Property_CorrelationId()
        {
            var evt = new DomainEvent
            {
                CorrelationId = "Test"
            };

            Assert.Equal("Test", evt.CorrelationId);
        }
    }
}
