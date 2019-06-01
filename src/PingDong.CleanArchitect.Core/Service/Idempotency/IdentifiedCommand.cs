using System;
using MediatR;

namespace PingDong.CleanArchitect.Service
{
    public class IdentifiedCommand<TCommand, TResponse> : IRequest<TResponse> where TCommand : IRequest<TResponse>
    {
        public TCommand Command { get; }

        public Guid Id { get; }

        public IdentifiedCommand(Guid id, TCommand command)
        {
            Command = command;
            Id = id;
        }
    }
}
