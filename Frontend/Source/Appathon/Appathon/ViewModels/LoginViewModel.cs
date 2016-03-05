using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Appathon.ViewModels
{
	using Models;
	using Events;

	public class LoginViewModel : ViewModelBase
	{
		public ICommand LogInAndSwitchToPostsCommand { get; set; }

		public string Username { get; set; }


		public LoginViewModel ()
		{
			this.LogInAndSwitchToPostsCommand = new Command (this.LogInAndSwitchToPosts);
		}	

		private void LogInAndSwitchToPosts()
		{
			App.AppEventAggregator.GetEvent<SecurityResolverChangedEvent> ().Publish (
				new SecurityResolver () { 
					Username = this.Username, 
					LoginDateStamp = DateTime.Now
			});
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new PostsView ());
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Publish (MenuToggleFlag.ToggleMenuToggleable);
		}
	}
}

