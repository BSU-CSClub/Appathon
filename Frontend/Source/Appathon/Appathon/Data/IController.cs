using System;
using System.Collections.Generic;

namespace Appathon.Data
{
	using Models;

	public interface IController
	{
		bool ValidateUser();
		List<Post> GetPosts();
		void AddPost(Post newPost);

	}
}

