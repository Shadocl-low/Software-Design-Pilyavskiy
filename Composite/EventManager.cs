using Composite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class EventManager
    {
        private Dictionary<EventType, List<IEventListener>> listeners = new();

        public void Subscribe(EventType eventType, IEventListener listener)
        {
            if (!listeners.ContainsKey(eventType))
                listeners[eventType] = new List<IEventListener>();

            listeners[eventType].Add(listener);
        }

        public void Unsubscribe(EventType eventType, IEventListener listener)
        {
            if (listeners.ContainsKey(eventType))
                listeners[eventType].Remove(listener);
        }

        public void Notify(EventType eventType, string data)
        {
            if (listeners.ContainsKey(eventType))
            {
                foreach (var listener in listeners[eventType])
                {
                    listener.Update(data);
                }
            }
        }
    }

}
