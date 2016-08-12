﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\windows";
			ShowLargeFilesQWithoutLinq(path);
		}

		private static void ShowLargeFilesQWithoutLinq(string path)
		{
			DirectoryInfo directory = new DirectoryInfo(path);
			FileInfo[] files = directory.GetFiles();
			//sorttinf dec
			Array.Sort(files, new FileInfoComparer());

			for (var i = 0; i<5; i++)
			{
				FileInfo file = files[i];
				Console.WriteLine($"{file.Name,-20} : {file.Length,10}");
			}
			
		}
	}

	public class FileInfoComparer : IComparer<FileInfo>
	{
		public int Compare(FileInfo x, FileInfo y)
		{
			return y.Length.CompareTo(x.Length);
		}
	}
}
