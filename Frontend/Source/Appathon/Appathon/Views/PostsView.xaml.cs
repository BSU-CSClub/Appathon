using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Appathon
{	
	using ViewModels;

	public partial class PostsView : ContentView
	{
		
		public PostsView ()
		{
			InitializeComponent ();
			App.AppEventAggregator.GetEvent<PostsUpdatedEvent> ().Subscribe (this.UpdatePostDisplay);
			BindingContext = new PostsViewModel ();

		}

		private void UpdatePostDisplay(List<PostViewModel> posts)
		{
			this.Posts.ItemsSource = posts;
		}
	}
}

