using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LinqXml2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "input.txt";
            String output = "output.xml";
            var a = File.ReadAllLines(input, Encoding.GetEncoding("windows-1251"));
            XDocument d = new XDocument(
              new XDeclaration(null, "windows-1251", null),

              new XElement("root",
                a.Select((e, index) => new XElement("line" + (index + 1), e) as XNode)));

            d.Save(output);
            Process.Start(input);
            Process.Start(output);
        }
    }
}
