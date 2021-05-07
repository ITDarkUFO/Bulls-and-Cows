using System;
using System.Collections.Generic;
namespace Program
{
    class EventManager : EventArgs
    {
        // Счетчик количества событий
        private int _eventID = -1;
        public int EventID
        {
            get
            {
                return _eventID;
            }

            set
            {

            }
        }

        // Статус события
        public enum EventStatus { NOTSET = 0, DEBUG = 10, INFO = 20, WARNING = 30, ERROR = 40, CRITICAL = 50 };

        
        /*public delegate void EventHandler(object Sender, EventManager Argument, String Message);

        public class LoggingEvent
        {
            public event EventHandler Logging;

            public void OnLogging(String msg)
            {
                EventManager arg = new EventManager();

                Logging?.Invoke(this, arg, msg);
            }
        }*/
    }
    
    /*class EventGenerator : EventManager
    {
        dynamic Creator;
        String EventName;

        public EventGenerator(dynamic Creator, String EventName)
        {
            this.Creator = Creator;
            this.EventName = EventName;

            EventList.Add(this, new List<Delegate> { });
        }

        public void Activate(object source, EventManager.EventStatus Status)
        {

        }*/
    }
}
