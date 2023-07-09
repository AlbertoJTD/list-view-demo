using ListViewDemo.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
