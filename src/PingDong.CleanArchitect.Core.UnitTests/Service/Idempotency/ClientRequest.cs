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

            var req = new ClientRequest<Guid>("name", time);

            Assert.Equal(time, req.Time);
            Assert.Equal("name", req.Name);
        }

        [Fact]
        public void ClientRequest_Id()
        {
            var time = DateTime.Now;

            var req = new ClientRequest<Guid>("name", time);

            Assert.Equal(typeof(Guid), req.Id.GetType());
        }
    }
}
