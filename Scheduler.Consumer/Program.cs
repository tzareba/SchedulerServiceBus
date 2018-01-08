using Scheduler.CsvParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var csv = new CSVParserService();
                var xd = csv.GetMessages();
        }
    }
}
