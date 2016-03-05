using System;
using System.Collections.Generic;
namespace Appathon
{
	using Events;
	using ViewModels;

	public class PostsUpdatedEvent : AppEvent<List<PostViewModel>> { }
}

