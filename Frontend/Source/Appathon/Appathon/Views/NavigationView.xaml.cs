using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Appathon
{
	using ViewModels;

	public partial class NavigationView : ContentView
	{
		public NavigationView ()
		{
			InitializeComponent ();
			BindingContext = new NavigationViewModel ();
		}
	}
}

