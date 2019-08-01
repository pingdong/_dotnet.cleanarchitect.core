using System;

namespace PingDong.CleanArchitect.Service
{
    public class ClientRequest<T>
    {
        public ClientRequest(T id, string name, DateTime time)
        {
            Id = id;
            Name = name;
            Time = time;
        }

        public T Id { get; }
        public string Name { get; }
        public DateTime Time { get; }
    }
}
