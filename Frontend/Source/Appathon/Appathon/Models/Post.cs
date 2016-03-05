using System;

namespace Appathon.Models
{
	public class Post
	{
		public Guid PostId { get; set; }

		public string Title { get; set; }

		public string Contents { get; set; }

		public Guid ImageId { get; set; }

		public Guid AuthorId { get; set; } 


	}
}

