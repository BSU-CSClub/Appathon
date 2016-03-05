using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Appathon
{
	using ViewModels;

	public partial class LoginView : ContentView
	{
		public LoginView ()
		{
			InitializeComponent ();
			BindingContext = new LoginViewModel ();
		}
	}
}

