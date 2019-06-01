using System;
using PingDong.CleanArchitect.Core;

namespace PingDong.CleanArchitect.Service
{
    public class ClientRequest : Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}
