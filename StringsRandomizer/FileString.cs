using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsRandomizer
{
    class FileString
    {
        private string text;
        private bool isUsed;

        public FileString(string str)
        {
            text = str;
            isUsed = false;
        }

        public bool isUsedString()
        {
            return isUsed;
        }

        public void WriteToFile(string path)
        {
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            StreamReader reader = new StreamReader(file);

            Console.WriteLine("***************************");
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            Console.WriteLine("***************************");
            
            writer.WriteLine(text);
            isUsed = true;

            writer.Close();
        }
    }
}
