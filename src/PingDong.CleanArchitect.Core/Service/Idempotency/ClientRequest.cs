using System;
using PingDong.CleanArchitect.Core;

namespace PingDong.CleanArchitect.Service
{
    public class ClientRequest<T> : Entity<T>, IAggregateRoot
    {
        public ClientRequest(string name, DateTime time)
        {
            Name = name;
            Time = time;
        }

        public string Name { get; }
        public DateTime Time { get; }
    }
}
