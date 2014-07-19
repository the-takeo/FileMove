using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace FileMove
{
	class FileMove
	{
		static Dictionary<string,List<string>> Infos = new Dictionary<string,List<string>> ();
		static string Movefrom=@"/Users/takeo/Downloads/";

		public static void Main (string[] args)
		{
			using(StreamReader sr = new StreamReader ("Setting.txt"))
			{
				string setting;
				bool is1stRow=true;

				while ((setting = sr.ReadLine ()) != null) 
				{
					if(is1stRow)
					{
						Movefrom=setting;
						is1stRow=false;
					}

					var info = setting.Split (',');
					var moveToDirectory = info [0];

					if (Infos.ContainsKey (moveToDirectory)==false)
						Infos.Add (moveToDirectory, new List<string> ());

					for (int i = 1; i < info.Length; i++) 
					{
						Infos [moveToDirectory].Add (info [i]);
					}
				}
			}

			foreach (var moveTo in Infos.Keys) 
			{
				string[] fileNames = Directory.GetFiles (Movefrom);

				foreach (string file in fileNames) 
				{
					string Extention = Path.GetExtension (file).ToLower ();

					if (Infos [moveTo].Contains (Extention) == false)
						continue;

					string fileName = Path.GetFileName (file);
					File.Move (file, moveTo + fileName);
					Console.WriteLine (fileName + " has moved!");
				}

				Console.WriteLine (" ");
			}
		}
	}
}
