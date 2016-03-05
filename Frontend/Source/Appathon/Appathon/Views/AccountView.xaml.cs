using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Appathon
{
	using ViewModels;

	public partial class AccountView : ContentView
	{
		public AccountView ()
		{
			InitializeComponent ();
			BindingContext = new AccountViewModel ();
		}
	}
}

