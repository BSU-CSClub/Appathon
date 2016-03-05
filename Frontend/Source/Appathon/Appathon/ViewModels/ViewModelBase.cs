using System;
using System.ComponentModel;

namespace Appathon.ViewModels
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public ViewModelBase ()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}

