using System;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class DomainEventTest
    {
        [Fact]
        public void DomainEvent_EmptyCtor()
        {
            var evt = new DomainEvent();

            Assert.Equal(default, evt.CorrelationId);
            Assert.Equal(default, evt.TenantId);
        }

        [Fact]
        public void DomainEvent_Ctor()
        {
            var correlationId = Guid.NewGuid().ToString();
            var tenantId = Guid.NewGuid().ToString();

            var evt = new DomainEvent(tenantId, correlationId);

            Assert.Equal(correlationId, evt.CorrelationId);
            Assert.Equal(tenantId, evt.TenantId);
        }

        [Fact]
        public void DomainEvent_Property()
        {
            var correlationId = Guid.NewGuid().ToString();
            var tenantId = Guid.NewGuid().ToString();

            var evt = new DomainEvent
            {
                CorrelationId = correlationId,
                TenantId = tenantId
            };

            Assert.Equal(correlationId, evt.CorrelationId);
            Assert.Equal(tenantId, evt.TenantId);
        }
    }
}
