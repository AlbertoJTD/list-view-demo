using ListViewDemo.Helpers;
using ListViewDemo.Model;
using ListViewDemo.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
		private Friend currentFriend;

		public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }
        public Command AddFriendCommand { get; set; }
        private INavigation Navigation { get; set; }
        public Command ItemTappedCommand { get; set; }
		public Friend CurrentFriend
		{
			get => currentFriend;
			set
			{
				currentFriend = value;
				OnPropertyChanged();
			}
		}

		public MainPageViewModel(INavigation navigation)
        {
            FriendRepository friendRepository = new FriendRepository();
            Friends = friendRepository.GetAllGrouped();
            Navigation = navigation;

            AddFriendCommand = new Command(async () => await NavigateToFriendView());
            ItemTappedCommand = new Command(async () => await NavigateToEditFriendView());
        }

		private async Task NavigateToEditFriendView()
		{
			await Navigation.PushAsync(new FriendView(CurrentFriend));
		}

		public async Task NavigateToFriendView()
		{
            await Navigation.PushAsync(new FriendView());
		}

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
		}
	}
}
