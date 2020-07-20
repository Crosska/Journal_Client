using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Client
{
    class SystemInfoLogger
    {

        public void WriteNewDataline(string username, string data)
        {
            StreamWriter stream = new StreamWriter("data.lg", true, System.Text.Encoding.UTF8);
            DateTime current = DateTime.Now;
            stream.WriteLine(current + " | " + username + " | " + data);
            stream.Close();
        }

        public string ReadLogFile()
        {
            String data = "";
            StreamReader stream = new StreamReader("data.lg", System.Text.Encoding.UTF8);
            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                data += line;
            }
            return data;
        }

    }
}
