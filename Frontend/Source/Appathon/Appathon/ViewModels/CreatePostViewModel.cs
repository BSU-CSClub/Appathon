using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Appathon.ViewModels
{
	using Models;
	using Events;

	public class CreatePostViewModel : ViewModelBase
	{
		public string Title { get; set; }

		public string Contents { get; set; }

		public string Username { get; set; }

		public ICommand UploadPostCommand { get; set; }

		public CreatePostViewModel ()
		{
			this.UploadPostCommand = new Command (this.UploadPost);
		}

		private void UploadPost()
		{
			if (App.User.UserId == null) {
				return;
			}

			if (string.IsNullOrEmpty (this.Title) || string.IsNullOrEmpty (this.Contents)) {
				return;
			}

			Post newPost = new Post () {
				AuthorId = App.User.UserId,
				Title = this.Title,
				Contents = this.Contents,
				AddedDateTime = DateTime.Now
			};

			App.AppController.AddPost (newPost);

			App.AppEventAggregator.GetEvent<NavigateToViewEvent> ().Publish (new PostsView ());
		}
	}
}

