using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Appathon.ViewModels
{
	using Models;
	using Events;

	public class AccountViewModel : ViewModelBase
	{
		public ICommand LogoutCommand { get; set; }

		public ICommand NavigateMyPostsCommand { get; set; }

		public ICommand NavigateMyUpvotesCommand { get; set; }

		public AccountViewModel ()
		{
			this.LogoutCommand = new Command (this.Logout);
			this.NavigateMyPostsCommand = new Command (this.NavigateMyPosts);
			this.NavigateMyUpvotesCommand = new Command (this.NavigateMyUpvotes);
		}		

		private void Logout() 
		{
			App.AppEventAggregator.GetEvent<SecurityResolverChangedEvent> ().Publish (new SecurityResolver ());
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new LoginView ());
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Publish (MenuToggleFlag.ToggleMenuToggleable);
		}

		private void NavigateMyPosts()
		{
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new MyPostsView ());
		}

		private void NavigateMyUpvotes()
		{
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new MyUpvotesView ());
		}
	}
}
