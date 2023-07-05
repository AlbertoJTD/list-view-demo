using Foundation.ObjectHydrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewDemo.Model
{
    public class FriendRepository
    {
        public IList<Friend> Friends { get; set; }

        public FriendRepository()
        {
            // Populate a list based on Friend model attributes
            Hydrator<Friend> _friendHydrator = new Hydrator<Friend>();
            Friends = _friendHydrator.GetList(50);
        }

        public IList<Friend> GetAllFriends()
        {
            return Friends;
        }
    }
}
