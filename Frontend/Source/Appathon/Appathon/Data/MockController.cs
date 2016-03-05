using System;
using System.Collections;

namespace Appathon.Data
{
	public class MockController : IController
	{
		public MockController ()
		{
		}

		public IEnumerable<Post> GetPosts()
		{
			//* TODO return fake posts *//
		}
	}
}

