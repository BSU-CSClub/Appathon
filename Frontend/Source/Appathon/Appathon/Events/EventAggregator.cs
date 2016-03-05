using System;
using System.Collections.Generic;

namespace Appathon.Events
{
	public class EventAggregator
	{
		private Dictionary<string, AppEvent> Events;


		public EventAggregator ()
		{
			this.Events = new Dictionary<string, AppEvent> ();
		}

		public TEventType GetEvent<TEventType>() where TEventType : AppEvent
		{
			string eventName = typeof(TEventType).Name;
			if (!this.Events.ContainsKey (eventName)) {
				this.Events.Add (eventName, Activator.CreateInstance<TEventType> ());
			}
			return (TEventType)this.Events [eventName];
		}	
	}
}

