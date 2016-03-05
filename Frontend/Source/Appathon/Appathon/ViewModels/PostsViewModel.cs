using System;
using System.ComponentModel;
using System.Collections.Generic;


namespace Appathon.ViewModels
{
	using Models;

	public class PostsViewModel : ViewModelBase
	{
		List<PostViewModel> Posts { get; set; }

		public PostsViewModel ()
		{
			this.Posts = new List<PostViewModel> ();
			for (int i = 0; i < 5; i++) {
				this.Posts.Add (new PostViewModel ());
			}
			App.AppEventAggregator.GetEvent<PostsUpdatedEvent> ().Publish (this.Posts);
		}			

	}
}

