using ListViewDemo.Helpers;
using ListViewDemo.Model;
using ListViewDemo.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }
        public Command AddFriendCommand { get; set; }
        private INavigation Navigation { get; set; }

        public MainPageViewModel(INavigation navigation)
        {
            FriendRepository friendRepository = new FriendRepository();
            Friends = friendRepository.GetAllGrouped();
            Navigation = navigation;

            AddFriendCommand = new Command(async () => await NavigateToFriendView());
        }

		public async Task NavigateToFriendView()
		{
            await Navigation.PushAsync(new FriendView());
		}
	}
}
