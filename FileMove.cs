using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace FileMove
{
    class Setting
    {
        public string From { get; set; }
        public string To { get; set; }
        public string[] Extentions { get; set; }
        public bool IsCopy { get; set; }

        public Setting(string from, string to, string extentions, string copy)
        {
            this.From = from;
            this.To = to;
            this.Extentions = extentions.Split(',');
            this.IsCopy = (copy == "True");
        }
    }

    class FileMove
    {
        public static void Main(string[] args)
        {
            var settings = from setting in XElement.Load("setting.xml").Elements()
                           select new Setting(setting.Element("from").Value,
                               setting.Element("to").Value, setting.Element("extentions").Value,
                               setting.Element("copy").Value);

            foreach (var setting in settings)
            {
                DoMoveFiles(setting);
            }
        }

        public static void DoMoveFiles(Setting setting)
        {
            if (Directory.Exists(setting.From) == false)
                throw new ApplicationException("Fromディレクトリが存在しません。");

            if (Directory.Exists(setting.To) == false)
                throw new ApplicationException("Toディレクトリが存在しません。");
            
            foreach (string file in Directory.GetFiles(setting.From))
            {
                string extention = Path.GetExtension(file).ToLower();

                if (setting.Extentions.Contains(extention) == false)
                    continue;

                string fileName = Path.GetFileName(file);

                if (setting.IsCopy)
                {
                    File.Copy(file, setting.To + fileName);
                    Console.WriteLine(fileName + " has been copied!");
                }
                else
                {
                    File.Move(file, setting.To + fileName);
                    Console.WriteLine(fileName + " has been moved!");
                }
            }

            Console.WriteLine(" ");
        }
    }
}