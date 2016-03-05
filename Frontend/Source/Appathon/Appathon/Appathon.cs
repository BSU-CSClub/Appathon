using System;

using System.Threading;
using Xamarin.Forms;

namespace Appathon
{
	using Events;

	public class App : Application
	{
		public static EventAggregator AppEventAggregator { get; set; }
		public static SecurityResolver User { get; set; } 
		public App ()
		{
			App.AppEventAggregator = new EventAggregator ();
			App.AppEventAggregator.GetEvent<SecurityResolverChangedEvent> ().Subscribe ((resolver) => App.User = resolver);

			// The root page of your application
			MainPage = new ShellView();


		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

