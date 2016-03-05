﻿using System;
using System.Collections.Generic;

namespace Appathon.Data
{
	using Models;

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

