using System;

namespace Appathon.Models
{
	public class Post
	{
		public Guid PostId { get; set; }

		public string Title { get; set; }

		public string Contents { get; set; }

		public Image ImageItem { get; set; }

		public User Author { get; set; } 


	}
}

