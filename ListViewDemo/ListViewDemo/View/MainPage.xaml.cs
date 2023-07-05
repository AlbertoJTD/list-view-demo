using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new[]
			{
				new
				{
					FirstName = "JohnJohnJohnJohnJohnJohnJohnJohnJohnJohn",
					Phone = "(123)45678",
					Email = "john1@hotmail.com",
				},
				new
				{
					FirstName = "Gavi",
					Phone = "(123)45678",
					Email = "Gavi@hotmail.com",
				},
				new
				{
					FirstName = "Scarlett",
					Phone = "(123)45678",
					Email = "scarlett@hotmail.com",
				},
			}.ToList();
		}
	}
}
