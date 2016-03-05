using System;
using System.Collections.Generic;
using System.Text;
namespace Appathon.Data
{
	using Models;

	//This is a change.
	public class MockController : IController
	{
		private List<Post> postRepository;

		public MockController ()
		{			
			this.postRepository = new List<Post> () {
				new Post(){
					AuthorId = Guid.NewGuid(),
					Title = "Post " + Guid.NewGuid().ToString().Substring(0,4).ToUpper(),
					Contents = this.RandString()
				},
				new Post(){
					AuthorId = Guid.NewGuid(),
					Title = "Post " + Guid.NewGuid().ToString().Substring(0,4).ToUpper(),
					Contents = this.RandString()
				},
				new Post(){
					AuthorId = Guid.NewGuid(),
					Title = "Post " + Guid.NewGuid().ToString().Substring(0,4).ToUpper(),
					Contents = this.RandString()
				},
				new Post(){
					AuthorId = Guid.NewGuid(),
					Title = "Post " + Guid.NewGuid().ToString().Substring(0,4).ToUpper(),
					Contents = this.RandString()
				},
				new Post(){
					AuthorId = Guid.NewGuid(),
					Title = "Post " + Guid.NewGuid().ToString().Substring(0,4).ToUpper(),
					Contents = this.RandString()
				},
				new Post(){
					AuthorId = Guid.NewGuid(),
					Title = "Post " + Guid.NewGuid().ToString().Substring(0,4).ToUpper(),
					Contents = this.RandString()
				},
				new Post(){
					AuthorId = Guid.NewGuid(),
					Title = "Post " + Guid.NewGuid().ToString().Substring(0,4).ToUpper(),
					Contents = this.RandString()
				}
			};

		}

		private string RandString()
		{
			string[] words = { "Apples", "Trump", "Austria", "Llama", "Hospital" };
			Random rng = new Random ();
			StringBuilder builder = new StringBuilder ();
			int length = rng.Next()%30 + 20;
			for (int i = 0; i < length; i++){
				builder.Append (words [rng.Next () % words.Length]);
			}
			return builder.ToString ();
		}


		public bool ValidateUser()
		{
			return true;
		}


		public List<Post> GetPosts()
		{
			return this.postRepository;
		}

		public void AddPost(Post newPost)
		{
			this.postRepository.Add (newPost);
		}
	}
}

