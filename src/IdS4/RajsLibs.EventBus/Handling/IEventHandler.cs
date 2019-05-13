﻿using RajsLibs.EventBus.Event;
using System.Threading.Tasks;

namespace RajsLibs.EventBus.Handling
{
    public interface IEventHandler<in TEvent>
        where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event); 
    }
}
