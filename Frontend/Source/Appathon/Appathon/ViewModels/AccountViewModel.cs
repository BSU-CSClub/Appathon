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

		public AccountViewModel ()
		{
			this.LogoutCommand = new Command (this.Logout);
		}		

		private void Logout() 
		{
			App.AppEventAggregator.GetEvent<SecurityResolverChangedEvent> ().Publish (new SecurityResolver ());
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new LoginView ());
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Publish (MenuToggleFlag.ToggleMenuToggleable);
		}
	}
}
