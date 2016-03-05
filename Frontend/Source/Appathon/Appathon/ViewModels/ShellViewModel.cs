using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Appathon.ViewModels
{
	using Models;
	using Events;

	public class ShellViewModel : ViewModelBase
	{		
		public ICommand ToggleMenuCommand { get; set; }

		public ICommand NavigateAccountCommand { get; set; }

		public ICommand NavigatePostsCommand { get; set; }

		public ICommand NavigateCreatePostCommand { get; set; }

		public ICommand NavigateNavigatorCommand { get; set; } 

		public ShellViewModel ()
		{			
			ContentView loginView = new LoginView ();
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new LoginView ());
			this.ToggleMenuCommand = new Command (() => App.AppEventAggregator.GetEvent<ToggleMenuEvent>().Publish(MenuToggleFlag.ToggleMenuOpen));
			this.NavigateAccountCommand = new Command (this.NavigateAccount);
			this.NavigatePostsCommand = new Command (this.NavigatePosts);
			this.NavigateCreatePostCommand = new Command (this.NavigateCreatePost);
			this.NavigateNavigatorCommand = new Command (this.NavigateNavigator);
		}			

		private void NavigateAccount()
		{
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new AccountView ());
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Publish (MenuToggleFlag.ToggleMenuOpen);
		}

		private void NavigatePosts()
		{
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new PostsView ());
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Publish (MenuToggleFlag.ToggleMenuOpen);
		}

		private void NavigateCreatePost()
		{
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new CreatePostView ());
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Publish (MenuToggleFlag.ToggleMenuOpen);
		}

		private void NavigateNavigator()
		{
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new NavigationView ());
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Publish (MenuToggleFlag.ToggleMenuOpen);
		}

	}
}

