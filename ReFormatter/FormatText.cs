using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReFormatter
{
    class FormatText
    {
        public FormatText(string[] lines, string format, char splitter)
        {
            Lines = lines;
            Format = format;
            Splitter = splitter;

            ReturnFormatedText();
        }

        public string[] ReturnFormatedText()
        {
            string[] line = new string[Lines.Length];
            string[] splitLines;
            for (var i = 0; i < Lines.Length; i++)
            {
                splitLines = Lines[i].Split(Splitter);

                line[i] = Format;
                for (var j = 0; j < splitLines.Length; j++)
                {
                    
                    splitLines[j].Trim();
                    line[i] = line[i].Replace($"[{j}]", splitLines[j]);
                }

            }
            return line;
        }


        private static string[] OutputList { get; set; }
        private  string[] Lines { get; set; }
        private  string Format { get; set; }
        private  char Splitter { get; set; }

    }
}
