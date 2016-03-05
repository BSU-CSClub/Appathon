using System;
using System.ComponentModel;

namespace Appathon.ViewModels
{
	using Models;

	public class PostViewModel : ViewModelBase
	{
		public Post PostModel { get; set; }

		public PostViewModel ()
		{			
		}			

		public PostViewModel(Post model)
		{
			this.PostModel = model;	
		}

	}
}

