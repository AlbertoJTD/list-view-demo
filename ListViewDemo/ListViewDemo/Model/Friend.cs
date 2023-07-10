using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ListViewDemo.Model
{
    public class Friend: INotifyPropertyChanged
    {
		private string firstName;
		private string phone;
		private string email;

		[PrimaryKey, AutoIncrement]
        public int Id { get; set; }

		public string FirstName
		{
			get => firstName;
			set
			{
				firstName = value;
				OnPropertyChanged();
			}
		}

		public string Phone
		{
			get => phone;
			set
			{
				phone = value;
				OnPropertyChanged();
			}
		}

		public string Email
		{
			get => email;
			set
			{
				email = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
		}
	}
}
