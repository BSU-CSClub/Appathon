using System;
using System.Collections;

namespace Appathon.Data
{
	public interface IController
	{
		bool ValidateUser();
		IEnumerable<Post> GetPosts();

	}
}

