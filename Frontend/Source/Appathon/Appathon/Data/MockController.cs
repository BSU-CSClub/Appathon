using System;
using System.Collections.Generic;

namespace Appathon.Data
{
	using Models;

	//This is a change.
	public class MockController : IController
	{
		public MockController ()
		{			


		}

		public bool ValidateUser()
		{
			return true;
		}


		public List<Post> GetPosts()
		{
			return new List<Post> ();
		}

		public void AddPost(Post newPost)
		{
		}
	}
}

