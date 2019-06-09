using System;
using PingDong.CleanArchitect.Core;

namespace PingDong.CleanArchitect.Service
{
    public class ClientRequest : Entity<Guid>, IAggregateRoot
    {
        public ClientRequest(string name, DateTime time)
        {
            Name = name;
            Time = time;
        }

        public string Name { get; private set; }
        public DateTime Time { get; private set; }
    }
}
