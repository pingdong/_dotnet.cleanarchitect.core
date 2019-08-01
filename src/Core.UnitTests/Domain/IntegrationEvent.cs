using System;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class IntegrationEventTest
    {
        [Fact]
        public void IntegrationEvent_EmptyCtor()
        {
            var evt = new IntegrationEvent();
            
            Assert.True((DateTime.UtcNow - evt.CreationDateInUtc).TotalSeconds < 1);
            Assert.Empty(evt.RequestId);
            Assert.Empty(evt.CorrelationId);
            Assert.Empty(evt.TenantId);
        }

        [Fact]
        public void IntegrationEvent_Ctor()
        {
            var requestId = Guid.NewGuid().ToString();
            var correlationId = Guid.NewGuid().ToString();
            var tenantId = Guid.NewGuid().ToString();

            var evt = new IntegrationEvent(requestId, tenantId, correlationId);
            
            Assert.True((DateTime.UtcNow - evt.CreationDateInUtc).TotalSeconds < 1);
            Assert.Equal(requestId, evt.RequestId);
            Assert.Equal(correlationId, evt.CorrelationId);
            Assert.Equal(tenantId, evt.TenantId);
        }

        [Fact]
        public void IntegrationEvent_Property()
        {
            var requestId = Guid.NewGuid().ToString();
            var correlationId = Guid.NewGuid().ToString();
            var tenantId = Guid.NewGuid().ToString();

            var evt = new IntegrationEvent
            {
                RequestId = requestId,
                CorrelationId = correlationId,
                TenantId = tenantId
            };
            
            Assert.True((DateTime.UtcNow - evt.CreationDateInUtc).TotalSeconds < 1);
            Assert.Equal(requestId, evt.RequestId);
            Assert.Equal(correlationId, evt.CorrelationId);
            Assert.Equal(tenantId, evt.TenantId);
        }
    }
}
