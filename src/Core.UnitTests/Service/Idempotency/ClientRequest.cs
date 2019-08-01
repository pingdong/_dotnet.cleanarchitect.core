using System;
using PingDong.CleanArchitect.Service;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests.Service
{
    public class ClientRequestTests
    {
        [Fact]
        public void ClientRequest_Set_Then_Read()
        {
            var time = DateTime.Now;
            var id = Guid.NewGuid();

            var req = new ClientRequest<Guid>(id, "name", time);

            Assert.Equal(id, req.Id);
            Assert.Equal(time, req.Time);
            Assert.Equal("name", req.Name);
        }
    }
}
