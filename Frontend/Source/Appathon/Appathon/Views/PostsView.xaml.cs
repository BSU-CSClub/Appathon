using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
			this.Posts.Children.Clear ();
			List<PostView> views = posts.Select (t => new PostView (){ BindingContext = t }).ToList ();
			foreach (View view in views) {
				this.Posts.Children.Add (view);
			}
		}
	}
}

