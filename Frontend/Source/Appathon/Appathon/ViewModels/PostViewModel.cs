using System;
using System.ComponentModel;

namespace Appathon.ViewModels
{
	using Models;

	public class PostViewModel : ViewModelBase
	{
		public string Content { get; set; }

		public PostViewModel ()
		{
			this.Content = Guid.NewGuid ().ToString ().Substring (0, 8);
		}			

	}
}

