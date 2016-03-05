using System;

namespace Appathon.Events
{
	public abstract class AppEvent {}

	public abstract class AppEvent<TPayload> : AppEvent
	{
		public Action<TPayload> Listeners { get; set; }

		public void Subscribe(Action<TPayload> action)
		{
			this.Listeners += action;
		}

		public void Publish(TPayload payload)
		{
			if (this.Listeners == null) {
				return;
			}
			
			this.Listeners (payload);
		}
			
	}
}