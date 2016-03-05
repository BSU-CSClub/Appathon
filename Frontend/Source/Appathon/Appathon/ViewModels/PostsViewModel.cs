using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace Appathon.ViewModels
{
	using Models;

	public class PostsViewModel : ViewModelBase
	{
		List<PostViewModel> Posts { get; set; }

		public PostsViewModel ()
		{
			this.Posts = new List<PostViewModel> ();
			this.RefreshPosts ();
		}			

		private void RefreshPosts()
		{
			this.Posts = App.AppController.GetPosts ().OrderByDescending(t => t.AddedDateTime).Select(t => new PostViewModel(t)).ToList();
			App.AppEventAggregator.GetEvent<PostsUpdatedEvent> ().Publish (this.Posts);
		}

	}
}

