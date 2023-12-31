﻿using Foundation;
using ListViewDemo.iOS.Services;
using ListViewDemo.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace ListViewDemo.iOS.Services
{
	public class FileHelper : IFileHelper
	{
		public string GetLocalFilePath(string fileName)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Databases");

			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}

			return Path.Combine(libFolder, fileName);
		}
	}
}