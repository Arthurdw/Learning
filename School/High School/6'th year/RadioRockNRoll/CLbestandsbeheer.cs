using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioRockNRoll
{
    class CLbestandsbeheer
    {
        private readonly string _root;

        public CLbestandsbeheer(string rootDir)
        {
            _root = rootDir;
        }

        public List<string[]> GetData()
        {
            List<string[]> data = new List<string[]>();

            StreamReader sr = null;
            if (!File.Exists(_root)) return data;
            sr = new StreamReader(File.OpenRead(_root));
            while (!sr.EndOfStream)
            {
                string row = sr.ReadLine();
                if (row != null) data.Add(row.Split(';'));
            }
            sr.Dispose();

            return data;
        }

        public void SetFile(List<string[]> data)
        {
            TextWriter tw = new StreamWriter(_root, false);
            foreach (string[] value in data)
            {
                tw.WriteLine(string.Join(";", value));
            }
            tw.Dispose();
        }

        public void AddLine(params string[] args)
        {
            string data = string.Join(";", args);
            TextWriter tw = new StreamWriter(_root, true);
            tw.Write(data + Environment.NewLine);
            tw.Dispose();
        }

        public void RemoveLine(int index)
        {
            List<string[]> data = GetData();

            data[index] = null;

            SetFile(data);
        }
    }
}

