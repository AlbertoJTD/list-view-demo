using ListViewDemo.Data;
using ListViewDemo.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
	public partial class App : Application
	{
		private static FriendDatabase database;
		public static FriendDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new FriendDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db3"));
				}

				return database;
			}
		}

        public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
