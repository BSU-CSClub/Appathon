using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Appathon
{
	using ViewModels;
	using Events;

	public enum MenuToggleFlag { ToggleMenuOpen, ToggleMenuToggleable }

	public partial class ShellView : ContentPage
	{
		private GridLength previousLength;

		public ShellView ()
		{
			InitializeComponent ();
			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Subscribe (this.UpdateContent);
			BindingContext = new ShellViewModel ();
			this.previousLength = new GridLength (200);
			App.AppEventAggregator.GetEvent<ToggleMenuEvent> ().Subscribe (this.ToggleMenu);
		}

		private void ToggleMenu(MenuToggleFlag flag)
		{
			if (flag == MenuToggleFlag.ToggleMenuOpen) {
				GridLength temp = this.MenuColumn.Width;
				this.MenuColumn.Width = this.previousLength;
				this.previousLength = temp;
			} else {
				this.MenuToggleButton.IsVisible = !this.MenuToggleButton.IsVisible;
			}
		}

		private void UpdateContent(ContentView content)
		{
			this.ContentControl.Content = content;
		}
	}
}

