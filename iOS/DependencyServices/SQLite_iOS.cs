﻿using System;
using System.IO;
using amcom.DemoApp.iOS;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace amcom.DemoApp.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLiteConnection GetConn()
		{
			var sqliteFilename = "amcomDatabase.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(libraryPath, sqliteFilename);
			var conn = new SQLiteConnection(path);

			return conn;
		}
	}
}