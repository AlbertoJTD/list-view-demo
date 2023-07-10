using ListViewDemo.ViewModel;
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
			//this.BindingContext = new MainPageViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			this.BindingContext = new MainPageViewModel(Navigation);
		}
	}
}
