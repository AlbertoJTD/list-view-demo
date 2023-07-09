using ListViewDemo.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDemo.Data
{
	public class FriendDatabase
	{
		readonly SQLiteAsyncConnection database;

        public FriendDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friend>().Wait();
        }

        public async Task<List<Friend>> GetItemsAsync()
        {
            return await database.Table<Friend>().ToListAsync();
        }

        public Task<Friend> GetItemAsync(int id)
        {
            return database.Table<Friend>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Friend item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Friend item)
        {
            return database.DeleteAsync(item);
        }
    }
}
