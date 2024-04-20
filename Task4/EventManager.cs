using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public delegate void EventHandler();
    public class EventManager
    {
        private event EventHandler _eventHandler;

        public void AddEventHandler(EventHandler handler)
        {
            _eventHandler += handler;
        }
        public void RemoveEventHandler(EventHandler handler)
        {
            _eventHandler -= handler;
        }

        public void TriggerEvent()
        {
            if(_eventHandler != null)
            {
                _eventHandler.Invoke();
            }
        }
    }
}
