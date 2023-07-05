using ListViewDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListViewDemo.ViewModel
{
    public class MainPageViewModel
    {
        public List<Friend> Friends { get; set; }
        public MainPageViewModel()
        {
            FriendRepository friendRepository = new FriendRepository();
            Friends = friendRepository.GetAllFriends().ToList();
        }
    }
}
