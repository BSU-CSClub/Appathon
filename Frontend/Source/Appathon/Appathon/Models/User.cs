using System;

namespace Appathon.Models
{
	public enum SecurityVerificationStatus { LoggedIn, AccessDenied, LoginExpired }

	public class User
	{
		public string Username { get; set; }
		public SecurityVerificationStatus SecurityStatus { get; set; }

	}
}

