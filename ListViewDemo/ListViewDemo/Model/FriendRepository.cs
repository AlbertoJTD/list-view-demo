using Foundation.ObjectHydrator;
using ListViewDemo.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDemo.Model
{
    public class FriendRepository
    {
        public IList<Friend> Friends { get; set; }

        public FriendRepository()
        {
            // Populate a list based on Friend model attributes
            //Hydrator<Friend> _friendHydrator = new Hydrator<Friend>();
            //Friends = _friendHydrator.GetList(50);

            Task.Run(async () => Friends = await App.Database.GetItemsAsync()).Wait();
        }

        public IList<Friend> GetAllFriends()
        {
            return Friends;
        }

        public IList<Friend> GetAllByFirstLetter(string firstLetter)
        {
            var query = from q in Friends
						where q.FirstName.StartsWith(firstLetter)
                        select q;

            return query.ToList();
        }

        public ObservableCollection<Grouping<string, Friend>> GetAllGrouped()
        {
            IEnumerable<Grouping<string, Friend>> sortedData = new Grouping<string, Friend>[0];

            if (sortedData != null)
            {
                sortedData = from f in Friends
                                 orderby f.FirstName
                                 group f by f.FirstName[0].ToString()
                                 into data
                                 select new Grouping<string, Friend>(data.Key, data);
            }

            return new ObservableCollection<Grouping<string, Friend>>(sortedData);
        }
    }
}
