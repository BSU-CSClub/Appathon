using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Appathon
{
	using ViewModels;

	public partial class CreatePostView : ContentView
	{
		public CreatePostView ()
		{
			InitializeComponent ();
			BindingContext = new CreatePostViewModel ();
		}
	}
}

