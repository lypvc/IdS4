﻿using RajsLibs.EventBus.Event;
using RajsLibs.EventBus.Handling;
using System.Threading.Tasks;

namespace RajsLibs.Events
{
    public interface IEventBus
    {
        Task PublishAsync<TEvent>(TEvent @event) where TEvent : IEvent;

        void Subscribe<TEvent, THandler>()
            where TEvent : IEvent
            where THandler : IEventHandler<TEvent>;

        void UnSubscribe<TEvent, THandler>() 
            where TEvent : IEvent
            where THandler : IEventHandler<TEvent>;
    }
}
