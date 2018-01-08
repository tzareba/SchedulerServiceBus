using System.Collections.Generic;
using Scheduler.CsvParser.Interface;
using Scheduler.Model;
using System.IO;
using System.Linq;

namespace Scheduler.CsvParser
{
    public class CSVParserService : ICSVParserService
    {
        public static char[] Delimiter { get { return new char[] { ',' }; } }
        public static int MailParametersCounter { get { return typeof(Mail).GetFields().Count(); } }

        public IEnumerable<Mail> GetMessages()
        {
           ///TODO: path to app file or something
            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Resources\\mails.csv";
            return File.ReadLines(path)
                 .Skip(1)
                 .Where(x => x != null)
                 .Select(line =>
                 {
                     string[] mailProps = line.Split(Delimiter, MailParametersCounter, System.StringSplitOptions.None);
                     return (mailProps.Length == MailParametersCounter) ?
                         new Mail(mailProps[0], mailProps[1], mailProps[2], mailProps[3]) :
                         null;
                 });
        }
    }
}